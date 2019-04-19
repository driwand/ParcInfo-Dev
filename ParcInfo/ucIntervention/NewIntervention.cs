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
                Interventions(currentInterv,source);
            }
            if (selCli != 0)
            {
                selectedClient = selCli;
                startInterClient();
            }
            if (selReq != 0)
            {
                selectedRequest = selReq;
                startInterRequest();
            }
        }

        public int selectedRequest;
        public int selectedClient;
        public int currentInterv;
        private void NewIntervention_Load(object sender, EventArgs e)
        {

        }
        public void startInterRequest()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                //create first empty intervention - assigned to a request
                Intervention intr = new Intervention()
                {
                    IdDemande = selectedRequest,
                    Idutilisateur = GlobVars.currentUser,
                    Idclient = selectedClient
                };
                context.Interventions.Add(intr);

                //create first observetion that contain date and who started the intervention
                observation obs = new observation()
                {
                    IdIntervention = intr.Id,
                    Textobservation = "new intervention get started"
                };
                context.observations.Add(obs);
                context.SaveChanges();

                var getRequest = context.Demandes.Find(selectedRequest); //current request


                //show request description and details
                AddTxtDescription(getRequest.Employee.Nom,getRequest.Datedemande.ToString(),getRequest.Description_d,pnlObservetion);


                //to fill with first intervention informations

            }
        }
        public void startInterClient()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                //create first empty intervention - assigned to a client
                Intervention intr = new Intervention
                {
                    Idclient = selectedClient,
                    Idutilisateur = GlobVars.currentUser
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

                AddTxtDescription("parc info", DateTime.Now.ToString(), obs.Textobservation, pnlObservetion);
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var currentIntervention = context.Interventions.Find(currentInterv);

                string def;
                def = "1";
                DialogResult result = new DialogResult();
                object dr = Interaction.InputBox("Autre information", "Enter les heurs", currentIntervention.Duree.ToString());
                if (dr is "")
                {
                    dr = def;
                }
                else
                {
                    if (currentIntervention.Demande != null)
                    {
                        result = MessageBox.Show("Do you want to confirm both of intervention nand revelent request ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (result != DialogResult.Cancel)
                        {
                            if (result == DialogResult.Yes)
                                currentIntervention.Demande.Statut = "terminer";

                            int toHours = int.Parse(dr.ToString());
                            currentIntervention.Duree = toHours;
                            currentIntervention.Statut = "terminer";
                        }
                    }
                    else
                    {
                        int toHours = int.Parse(dr.ToString());
                        currentIntervention.Duree = toHours;
                        currentIntervention.Statut = "terminer";
                    }
                    context.SaveChanges();
                    tmrDone.Start();
                }
               
            }
            
        }

        private void btnAddDexcription_Click(object sender, EventArgs e)
        {
            AddDescription();
        }
        void AddDescription()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var interv = (from it in context.Interventions
                              where it.Id == currentInterv
                              select it).FirstOrDefault();
                
                //add new description to an exesiting intervention of selected client
                observation obs = new observation()
                {
                    Textobservation = txtAddDescription.Text,
                    IdUser = GlobVars.currentUser.ToString(),
                    TypeOb = cbType.Text,
                    IdIntervention = interv.Id
                };
                
                context.observations.Add(obs);

                context.SaveChanges();

                interv.Idutilisateur.ToString();
                
                AddTxtDescription(interv.Idutilisateur.ToString(), DateTime.Now.ToString(), obs.Textobservation,pnlObservetion);
                txtAddDescription.Clear();
                pnlObservetion.VerticalScroll.Value = pnlObservetion.VerticalScroll.Maximum;
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
                context.SaveChanges();
                MessageBox.Show("Done");
            }
        }

        private void tmrDone_Tick(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var intr = context.Interventions.Find(currentInterv);
                if (intr.Statut == "terminer")
                {
                    pnlStatut.BackColor = Color.FromArgb(32, 191, 107);
                    btnDone.Hide();

                    observation obs = new observation()
                    {
                        TypeOb = "Parc Info",
                        IdIntervention = currentInterv,
                        Textobservation = "Intervention terminer"
                    };
                    context.observations.Add(obs);
                    context.SaveChanges();
                    AddTxtDescription("parc info", DateTime.Now.ToString(), obs.Textobservation,pnlObservetion);
                }
                lblStatut.Text = "terminer";
                lblStatut.Location = new Point(103, 8);
            }
            tmrDone.Stop();
        }


        private void lblSource_Click(object sender, EventArgs e)
        {
            if (selectedRequest != 0)
                GlobVars.frmindex.ShowControl(new FichDemande(selectedRequest));
            else
                GlobVars.frmindex.ShowControl(new CreateClient(selectedClient));
        }

        public void Interventions(int selectedInre,int source)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                Intervention currentintr = context.Interventions.Find(selectedInre); //the selected intervention from datagrid
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
                    }
                    CheckStatut(currentintr.Statut);
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
                        AddTxtDescription(currentintr.Demande.Employee.Nom,
                            currentintr.Demande.Datedemande.ToString(),
                            currentintr.Demande.Description_d,
                            pnlObservetion);
                    }

                    var activities = (from d in context.observations
                               where d.IdIntervention == currentInterv
                               select d).ToList(); //observetions of selected intervention


                    if (activities != null)
                    {
                        foreach (var v in activities) //fill pnlObservetion of each item in activities
                        {
                            AddTxtDescription(v.IdUser,
                                v.Dateobservation.ToString(),
                                v.Textobservation,
                                pnlObservetion);
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
                    pnlStatut.BackColor = Color.FromArgb(254, 211, 48);
                    break;
            }
        }
        public void AddTxtDescription(string userInfo, string details, string description, Panel container)
        {
            MultiLineLabel ml = new MultiLineLabel();

            //adding description with more details to panel
            TxtDescription us = new TxtDescription();

            ml.Parent = us.pnlText;
            ml.AutoSize = true;
            ml.MultiLine = true;
            us.lblUser.Text = userInfo; //show name of current user in description
            us.lblDetails.Text = details; //datetime.now in description

            ml.Text = description;//show text of description
            int o = ml.Height;

            us.pnlText.Size = new Size(300, o); //make size of panel as the height of text

            ml = new MultiLineLabel();
            container.Controls.Add(us);
        }

    }
}
