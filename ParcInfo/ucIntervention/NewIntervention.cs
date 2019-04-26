using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ParcInfo.ucControls;
using ParcInfo.ucClient;
using ParcInfo.ucDemande;
using System.Text.RegularExpressions;
using ParcInfo.frmList;

namespace ParcInfo.ucInterevntion
{

    public partial class NewIntervention : UserControl
    {
        public NewIntervention(int selCli = 0,int selReq = 0,int curInter = 0,int source = 0)
        {
            InitializeComponent();
            if (curInter != 0)
            {
                currentInterv = curInter;
                lblIntervention.Text = currentInterv.ToString();
                Interventions(currentInterv, source);
            }
            if (selReq != 0)
            {
                selectedRequest = selReq;
                selectedClient = selCli;
                StartInterRequest();
            }else if (selCli != 0)
            {
                selectedClient = selCli;
                StartInterClient();
            }
        }

        public string codeproduct;
        public int selectedRequest;
        public int selectedClient;
        public int currentInterv;

        Func<string, bool> condition = (line) => line.Length > 1;

        private void NewIntervention_Load(object sender, EventArgs e)
        {

        }

        public void StartInterRequest()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                //create first empty intervention - assigned to a request
                Intervention intr = new Intervention()
                {
                    IdDemande = selectedRequest,
                    Idutilisateur = GlobVars.currentUser,
                    Idclient = selectedClient,
                    Statut = "en cours",
                    Modifierpar = GlobVars.currentUser,
                    Datemodification = DateTime.Now
                };
                context.Interventions.Add(intr);

                //create first observetion that contain date and who started the intervention
                observation obs = new observation()
                {
                    IdUser = "Parc Info",
                    IdIntervention = intr.Id,
                    Textobservation = "new intervention get started"
                };
                context.observations.Add(obs);
                

                var getRequest = context.Demandes.Find(selectedRequest); //current request
                if (getRequest.Statut == "en attente")
                    getRequest.Statut = "en cours";
              
                context.SaveChanges();
                currentInterv = intr.Id;

                //show request description and details
                AddTxtDescription(
                    getRequest.Employee.Nom,
                    getRequest.Datedemande.Value,
                    getRequest.Description_d,
                    0,
                    pnlObservetion);


                //to fill with first intervention informations
                AddTxtDescription("Parc Info", obs.Dateobservation, obs.Textobservation,obs.Id, pnlObservetion);

                lblSource.Text = intr.Demande.IdReq;
            }
        }
        public void StartInterClient()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                //create first empty intervention - assigned to a client
                Intervention intr = new Intervention
                {
                    Idclient = selectedClient,
                    Idutilisateur = GlobVars.currentUser,
                    Statut = "en cours",
                    Modifierpar = GlobVars.currentUser,
                    Datemodification = DateTime.Now
                };
                context.Interventions.Add(intr);

                //create first observetion that contain date and who started the intervention
                observation obs = new observation()
                {
                    IdUser = "Parc Info",
                    IdIntervention = intr.Id,
                    Textobservation = "new intervention get started"
                };
                context.observations.Add(obs);


                context.SaveChanges();
                currentInterv = intr.Id;

                var clt = context.Clients.Find(selectedClient);

                AddTxtDescription("Parc Info", DateTime.Now, obs.Textobservation,obs.Id, pnlObservetion);

                lblSource.Text = intr.Client.IdCLient.ToString();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbType.Text == "" || cbPlace.Text == "")
                MessageBox.Show("Required fields");
            else
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var currentIntervention = context.Interventions.Find(currentInterv);

                    int totHours = Convert.ToInt32(numHeur.Value);

                    bool verify = false;
                    string res = "";

                    bool done = false;

                    DialogResult result = new DialogResult();
                    if (totHours == 0)
                    {
                        while (!verify)
                        {
                            res = Interaction.InputBox("Autre information", "Enter les heurs");
                            if (res == "")
                            {
                                break;
                            }
                            if (Regex.IsMatch(res, @"\d"))
                            {
                                verify = true;
                            }
                            else
                            {
                                verify = false;
                                MessageBox.Show("input should be a number");
                            }
                        }
                    }
                    if (verify || totHours != 0)
                    {
                        if (currentIntervention.Demande != null)
                        {
                            result = MessageBox.Show("Do you want to confirm both of intervention nand revelent request ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (result != DialogResult.Cancel)
                            {
                                if (result == DialogResult.Yes)
                                    currentIntervention.Demande.Statut = "terminer";

                                if (res != "")
                                    totHours = int.Parse(res.ToString());

                                done = true;
                            }
                        }
                        else
                        {
                            var rst = MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo);

                            if (rst == DialogResult.Yes)
                            {
                                if (res != "")
                                    totHours = int.Parse(res.ToString());

                                done = true;
                            }
                        }
                        if (done)
                        {
                            currentIntervention.Duree = totHours;
                            currentIntervention.Statut = "terminer";
                            numHeur.Value = totHours;

                            context.SaveChanges();
                            tmrDone.Start();
                        }
                    }
                }
            }
        }

        private void btnAddDexcription_Click(object sender, EventArgs e)
        {
            AddDescription();
        }

        public void AddDescription(string codeid = null,int idaffecattion = 0)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var interv = (from it in context.Interventions
                              where it.Id == currentInterv
                              select it).FirstOrDefault();

                observation obs = new observation()
                {
                    
                    IdUser = GlobVars.currentUser.ToString(),
                    TypeOb = cbType.Text,
                    IdIntervention = interv.Id
                };
                if (codeid == null)
                {
                    //add new description to an exesiting intervention of selected client
                    obs.Textobservation = txtAddDescription.Text;
                }
                else
                    obs.Detailproduit = codeid;



                context.observations.Add(obs);

                context.SaveChanges();

                interv.Idutilisateur.ToString();
                

                AddTxtDescription(
                    interv.Idutilisateur.ToString(),
                    DateTime.Now,
                    obs.Textobservation,
                    obs.Id,
                    pnlObservetion,
                    codeid ?? codeid,
                    selectedClient);

                if (codeid == null)
                    txtAddDescription.Clear();
            }
        }


        private void txtAddDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Shift && e.KeyCode == Keys.Enter)
            {
                AddDescription();
                e.SuppressKeyPress = true;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDetails();
            MessageBox.Show("done");
        }

        public void SaveDetails()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                string typeInter = cbType.Text;
                string placeInter = cbPlace.Text;
                DateTime dateDebut = dtDebut.Value;
                DateTime dateFin = dtFin.Value;
                int numberHours = Convert.ToInt32(numHeur.Value);


                var intrv = context.Interventions.Find(currentInterv);
                intrv.TypeIntervention = typeInter;
                intrv.Deplacement = placeInter;
                intrv.Debut = dateDebut;
                intrv.Fin = dateFin;
                intrv.Duree = numberHours;

                intrv.Datemodification = DateTime.Now;
                intrv.Modifierpar = GlobVars.currentUser;


                if (dtFin.Value.Date < dtDebut.Value.Date)
                {
                    MessageBox.Show("end date could not be less than starting date");
                }
                else
                {
                    context.SaveChanges();

                    lblDateModification.Text = intrv.Datemodification.ToString();
                    lblModifierPar.Text = intrv.UtilisateurEdit.Nom;
                }
            }
        }

        private void tmrDone_Tick(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                SaveDetails();

                var intr = context.Interventions.Find(currentInterv);
                if (intr.Statut == "terminer")
                {
                    pnlStatut.BackColor = Color.FromArgb(32, 191, 107);
                    btnDone.Hide();
                    btnAddProduct.Enabled = false;

                    observation obs = new observation()
                    {
                        IdUser = "Parc Info",
                        IdIntervention = currentInterv,
                        Textobservation = "Intervention terminer"
                    };
                    context.observations.Add(obs);
                    context.SaveChanges();

                    AddTxtDescription(
                        "Parc Info",
                        DateTime.Now,
                        obs.Textobservation,
                        obs.Id,
                        pnlObservetion);
                }
                if (intr.Statut == "terminer")
                {
                    lblStatut.Text = "terminer";
                    lblStatut.Location = new Point(103, 8);
                }
            }
            tmrDone.Stop();
        }


        private void lblSource_Click(object sender, EventArgs e)
        {
            if (selectedRequest != 0)
                GlobVars.frmindex.ShowControl(new FichDemande(selectedRequest));
            else
                GlobVars.frmindex.ShowControl(new CreateClient(selectedClient,""));
        }

        public void Interventions(int selectedInre,int source)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                Intervention currentintr = db.Interventions.Find(selectedInre); //the selected intervention from datagrid

                selectedClient = (int)currentintr.Idclient;
                if (source != 0)
                {
                    try
                    {
                        lblSource.Text = currentintr.Demande.IdReq;
                    }catch
                    {
                        lblSource.Text = currentintr.Client.IdCLient.ToString();
                    }
                }
                    
                if (currentintr != null)
                {

                    if (currentintr.Client != null)
                    {
                        lblDetails.Text = currentintr.Client.Nom;
                        
                        selectedClient = currentintr.Client.id;
                    }
                    
                    CheckStatut(currentintr.Getstatut);
                    lblIntervention.Text = currentintr.IdIntrv;
                    lblIntervention.ForeColor = Color.FromArgb(0, 168, 255);
                    lblIntervention.Show();

                    if (currentintr.TypeIntervention != null &&
                        currentintr.Deplacement != null &&
                        currentintr.Debut != null &&
                        currentintr.Fin.Value != null
                        )
                    {

                        cbType.Text = currentintr.TypeIntervention;
                        cbPlace.Text = currentintr.Deplacement;
                        dtDebut.Value = (DateTime)currentintr.Debut;
                        dtFin.Value = Convert.ToDateTime(currentintr.Fin.Value);
                        numHeur.Value = Convert.ToDecimal(currentintr.Duree.Value);
                        lblModifierPar.Text = currentintr.Modifierpar.ToString();
                        lblDateModification.Text = currentintr.Datemodification.ToString();
                    }

                    if (currentintr.IdDemande != null)
                    {
                        selectedRequest = currentintr.Demande.Id;

                        AddTxtDescription(
                            currentintr.Demande.Employee.Nom,
                            currentintr.Demande.Datedemande.Value,
                            currentintr.Demande.Description_d,
                            0,
                            pnlObservetion);
                    }

                    var activities = (from d in db.observations
                               where d.IdIntervention == currentInterv && d.IsDeleted == 0
                               select d).ToList(); //observetions of selected intervention


                    if (activities != null)
                    {
                        foreach (var v in activities) //fill pnlObservetion of each item in activities
                        {
                            AddTxtDescription(v.IdUser,
                                v.Dateobservation,
                                v.Textobservation,
                                v.Id,
                                pnlObservetion,
                                v.Detailproduit ?? v.Detailproduit,
                                selectedClient);
                        }
                    }
                }
            }
        }
        public void CheckStatut(string stt)
        {
            switch (stt)
            {
                case "terminer":
                    lblStatut.Text = "terminer";
                    lblStatut.Location = new Point(103, 8);
                    pnlStatut.BackColor = Color.FromArgb(32, 191, 107);
                    btnAddProduct.Enabled = false;
                    btnDone.Hide();
                    break;
                case "en retard":
                    lblStatut.Text = "en retard";
                    lblStatut.Location = new Point(90, 8);
                    pnlStatut.BackColor = Color.FromArgb(252, 92, 101);
                    break;
                case "en cours":
                    lblStatut.Text = "En cours";
                    lblStatut.Location = new Point(91, 8);
                    pnlStatut.BackColor = Color.FromArgb(241, 196, 15);
                    break;
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmListProducts frm = new frmListProducts(this);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnDelInt_Click(object sender, EventArgs e)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                var res = MessageBox.Show("Are you sure ?", "Confiramtion", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    db.Interventions.Find(currentInterv).IsDeleted = 1;
                    db.SaveChanges();

                    GlobVars.frmindex.ShowControl(GlobVars.frmBack);
                }
            }
        }

        int nametxt = 1;
        public void AddTxtDescription(string userInfo, DateTime date, string description,int idobs, Panel container,string details = null,int IdCli=0)
        {
            MultiLineLabel ml = new MultiLineLabel();

            //adding description with more details to panel
            TxtDescription us = new TxtDescription
            {
                Name = "us" + nametxt
            };

            ml.Parent = us.pnlText;
            ml.AutoSize = true;
            ml.MultiLine = true;
            us.lblUser.Text = userInfo; //show name of current user in description
            us.lblDetails.Text = date.ToString(); //datetime.now in description


            if (userInfo.ToLower() == "Parc Info".ToLower())
            {
                us.BackColor = Color.FromArgb(33, 150, 243);
                us.lblDetails.ForeColor = Color.White;
                us.lblIdAffecta.ForeColor = Color.White;
                us.lblUser.ForeColor = Color.White;
                us.pnlLine.BackColor = Color.White;

                ml.ForeColor = Color.White;
            }

            if (description != null)
                ml.Text = description; //show text of description

            if (details != null)
            {
                int idaffec = Convert.ToInt32(details.Split(' ').Take(3).LastOrDefault());
                us.lblIdAffecta.Text = idaffec.ToString();

                us.lblidobs.Text = idobs.ToString();
                us.BackColor = Color.FromArgb(33, 150, 243);
                us.lblDetails.ForeColor = Color.White;
                us.lblIdAffecta.ForeColor = Color.White;
                us.lblUser.ForeColor = Color.White;
                us.pnlLine.BackColor = Color.White;
                us.btnDelProd.Show();

                ml.Text = $"this product {details.Split(' ').Take(2).Last()} by {userInfo}";
                ml.ForeColor = Color.White;
                us.Click += new EventHandler((sender,e) => GetProduct(sender,e, IdCli, details.Split(' ').Take(1).Last()));
                //us.btnDelProd.Click += new EventHandler((sender, e) => Del(sender,e,IdAffe,"us"+nametxt));
            }

            int o = ml.Height;

            us.pnlText.Size = new Size(300, o); //make size of panel as the height of text

            ml = new MultiLineLabel();
            container.Controls.Add(us);

            nametxt++;

            container.VerticalScroll.Value = container.VerticalScroll.Maximum;
        }

        private void Del(object sender, EventArgs e,int idaf,string namectr)
        {
            var result = MessageBox.Show("Are you sure", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var db = new ParcInformatiqueEntities())
                {
                    //var faffc = db.ProduitClients.Find(idaf);
                    //db.ProduitClients.Remove(faffc);

                    MessageBox.Show(idaf.ToString());


                    var ct = pnlObservetion.Controls.Find(namectr, true).FirstOrDefault();
                    pnlObservetion.Parent.Controls.Remove(ct);
                    MessageBox.Show("done");
                }
            }
        }

        private void GetProduct(object sender, EventArgs e,int idcli,string idprod)
        {
            TxtDescription lbl = (TxtDescription)sender;
            lbl.Cursor = Cursors.Hand;

            GlobVars.frmindex.ShowControl(new DetailProduit(idcli, Convert.ToInt32(idprod)));
        }
    }
}