using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.Classes;
using ParcInfo.Properties;
using ParcInfo.ucControls;

namespace ParcInfo.ucClient
{
    public partial class CreateClient : UserControl
    {
        int userName = 1;
        int deparName = 1;
        int idC = 0;
        public CreateClient(int idClient,string Code)
        {
            InitializeComponent();
            //ControlsClass.CreateRadiusBorder(this);
            //Default lblTextbox
            lblTextbox user1 = new lblTextbox();
            user1.Name = "userC" + userName;
            user1.LblText = "Nom :";
            user1.Margin = new Padding(0, 0, 0, 12);
            user1.Lblid = "0";
            user1.LblAff = "0";
            userName++;
            //Default txtlblDepartement
            txtlblDepartement depr = new txtlblDepartement();
            depr.Name = "ucDepart" + deparName;
            depr.Lblname = "Nom :";
            depr.Margin = new Padding(0, 0, 0, 12);
            depr.Lblid = "0";
            deparName++;
            PnlUsers.Controls.Add(user1);
            PnlDepart.Controls.Add(depr);
            if (idClient > 0)
            {
                idC = idClient;
                // Hide Button Ajouter
                btnAddClient.Visible = false;
                btnAddClient.Location = new Point(619, 443);
                btnEditClient.Visible = true;
                btnEditClient.Location = new Point(738, 443);
                btnDelClient.Visible = true;
                lblClient.Text = "Fiche du client : ";
                lblNameClient.Text =  Code;
                picHeader.Image = Resources.viewDetail;
                lblNameClient.Visible = true;
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var client = context.Clients.Find(idClient);
                    txtNom.Text = client.Nom;
                    txtAdr.Text = client.Adresse;
                    txtVille.Text = client.Ville;
                    txtTel.Text = client.Tel;
                    txtFax.Text = client.Fax;
                    txtSiteweb.Text = client.Siteweb;
                    dtDebutcontract.Text = client.Debutcontract.ToString();
                    txtHeure.Text = client.Heurecontract.ToString();
                    txtPrix.Text = client.Prixheur.ToString();

                    var listDepart = (from d in client.Departements
                                      where d.IdCLient == idClient && d.IsDeleted == 0
                                      select new { d.id, d.Nom }).ToList();
                    var listUtilisateur = (from c in client.AffectationClients
                                           where c.Idclient == idClient && c.IsDeleted == 0
                                           join d in context.Utilisateurs on c.Idutilisateur equals d.Id
                                           select new { idAff = c.Id, d.Id, d.Nom, d.Prenom }).ToList();
                    // DepartementID = listDepart.Select(c => c.id).ToList();
                    txtlblDepartement tbx = this.Controls.Find("ucDepart1", true).FirstOrDefault() as txtlblDepartement;
                    lblTextbox ltb = this.Controls.Find("userC1", true).FirstOrDefault() as lblTextbox;
                    //  Departement
                    if (listDepart != null && listDepart.Count > 0)
                    {
                        var depart = listDepart.FirstOrDefault();
                        tbx.TxtValue = depart.Nom;
                        tbx.Lblid = depart.id.ToString();
                        foreach (var item in listDepart.Skip(1))
                        {
                            txtlblDepartement depr1 = new txtlblDepartement();
                            depr1.Name = "ucDepart" + deparName;
                            depr1.TxtValue = item.Nom.ToString();
                            depr1.Lblname = "Nom :";
                            depr1.Lblid = item.id.ToString();
                            depr1.Margin = new Padding(0, 0, 0, 12);
                            deparName++;
                            PnlDepart.Controls.Add(depr1);
                        }
                    }
                    if (listUtilisateur != null && listUtilisateur.Count > 0)
                    {
                        var user = listUtilisateur.FirstOrDefault();
                        ltb.TxtValue = user.Nom + " " + user.Prenom;
                        ltb.Lblid = user.Id.ToString();
                        ltb.LblAff = user.idAff.ToString();
                        foreach (var item in listUtilisateur.Skip(1))
                        {
                            //first lblTexbox to fill user
                            lblTextbox user2 = new lblTextbox();
                            user2.TxtValue = item.Nom + " " + item.Prenom;
                            user2.Name = "userC" + userName;
                            user2.Lblid = item.Id.ToString();
                            user2.LblAff = item.idAff.ToString();
                            user2.LblText = "Nom :";
                            user2.Margin = new Padding(0, 0, 0, 12);
                            userName++;
                            PnlUsers.Controls.Add(user2);
                        }
                    }
                }
            }
        }
        private void CreateClient_Load(object sender, EventArgs e)
        {

        }
        // ADD lblTextbox Control
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            lblTextbox user1 = new lblTextbox();
            user1.Name = "userC" + userName;
            user1.LblText = "Nom :";
            user1.Lblid = "0";
            user1.LblAff = "0";
            user1.Margin = new Padding(0, 0, 0, 12);
            userName++;
            PnlUsers.Controls.Add(user1);
            PnlUsers.Height += 23;
            if (PnlUsers.Size == PnlUsers.MaximumSize)
            {
                PnlUsers.AutoScroll = true;

            }

        }
        //add txtlblDepartement Control
        private void btnAddDepartement_Click(object sender, EventArgs e)
        {
            txtlblDepartement depr = new txtlblDepartement();
            depr.Name = "ucDepart" + deparName;
            depr.Lblname = "Nom :";
            depr.Margin = new Padding(0, 0, 0, 12);
            depr.Lblid = "0";
            deparName++;
            PnlDepart.Controls.Add(depr);
            PnlDepart.Height += 23;
            if (PnlDepart.Size == PnlDepart.MaximumSize)
            {
                PnlDepart.AutoScroll = true;

            }
        }
        // Edit Client
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var labelControlList = Methods.GetidList(PnlDepart);
                var cli = context.Clients.Find(idC);
                //Departement
                foreach (var item in labelControlList)
                {
                    if (item.Id > 0 && !item.IsDeleted)
                    {
                        var dep = cli.Departements.Where(d => d.id == item.Id).FirstOrDefault();
                        dep.Nom = item.Value;
                    }
                    else if (item.Id == 0)
                    {
                        context.Departements.Add(new Departement { Nom = item.Value, IdCLient = idC });
                    }
                    else if (item.Id >= 0 && item.IsDeleted)
                    {
                        var dep = cli.Departements.Where(d => d.id == item.Id).FirstOrDefault();
                        dep.IsDeleted = 1;
                        txtlblDepartement tbx = this.Controls.Find(item.Controlname, true).FirstOrDefault() as txtlblDepartement;
                        PnlDepart.Controls.Remove(tbx);
                    }
                }
                //Utilisateur 
                var labelControlList2 = Methods.GetidList(PnlUsers);
                foreach (var item in labelControlList2)
                {
                    if (item.Idaffectation > 0 && !item.IsDeleted)
                    {
                        var aff = cli.AffectationClients.Where(d =>  item.Id == d.Idutilisateur && d.IsDeleted == 0).FirstOrDefault();
                        if (aff == null)
                        {
                            aff = cli.AffectationClients.Where(a => a.Id == item.Idaffectation).FirstOrDefault();
                            aff.IsDeleted = 1;
                            aff.Datemodification = DateTime.Now;
                            // aff.Modifierpar = 0;
                            context.AffectationClients.Add(new AffectationClient { Idclient = idC, Idutilisateur = item.Id,IsDeleted = 0});
                        }
                    }
                    else if (item.Idaffectation == 0)
                    {
                        var ac = cli.AffectationClients.Where(af => af.Idutilisateur == item.Id && af.IsDeleted == 0).FirstOrDefault();
                      
                        // check if user already 
                        if (ac != null)
                        {
                        }
                        else
                        {
                            context.AffectationClients.Add(new AffectationClient { Idclient = idC, Idutilisateur = item.Id,Dateaffectation = DateTime.Now, IsDeleted = 0 });
                        }
                    }
                    else if (item.Idaffectation >= 0 && item.IsDeleted)
                    {
                        var affectation = cli.AffectationClients.Where(d => d.Id == item.Idaffectation).FirstOrDefault();
                        affectation.IsDeleted = 1;
                        affectation.Datemodification = DateTime.Now;
                        //affectation.Modifierpar = 1;
                        lblTextbox tbx = this.Controls.Find(item.Controlname, true).FirstOrDefault() as lblTextbox;
                        PnlUsers.Controls.Remove(tbx);
                    }
                }
                // get Values From Textbox
                cli.Nom = txtNom.Text;
                cli.Adresse = txtAdr.Text;
                cli.Ville = txtVille.Text;
                cli.Tel = txtTel.Text;
                cli.Fax = txtFax.Text;
                cli.Siteweb = txtSiteweb.Text;
                cli.Datemodification = DateTime.Now;
                cli.Modifierpar = 11;
                cli.Debutcontract = DateTime.Parse(dtDebutcontract.Value.ToShortDateString());
                cli.Prixheur = float.Parse(txtPrix.Text);
                cli.Heurecontract = int.Parse(txtHeure.Text);
                context.SaveChanges();
                MessageBox.Show("Client modifié");
            }
        }
        
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Departement dt;
            AffectationClient user;
            //List
            List<LabelControl> DepartementList = new List<LabelControl>();
            List<LabelControl> UtilisateursList = new List<LabelControl>();
            int txtEmpty = 0;
            // Get Users && departement
            UtilisateursList = Methods.GetidList(PnlUsers);
            DepartementList = Methods.GetidList(PnlDepart);
            // check if user empty
            //txtEmpty = Methods.Focus2(PnlDepart);
            txtEmpty = Methods.Focus(this);
            // Fil list UtilisateurID
            if (txtEmpty == 0)
            { // get Values From Textbox
                string Nom = txtNom.Text;
                string Adr = txtAdr.Text;
                string Ville = txtVille.Text;
                string Tel = txtTel.Text;
                string Fax = txtFax.Text;
                string Siteweb = txtSiteweb.Text;
                DateTime Dtcontract = DateTime.Parse(dtDebutcontract.Value.ToShortDateString());
                float Prix = float.Parse(txtPrix.Text);
                int Heure = int.Parse(txtHeure.Text);
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    // Add Client
                    Client client = new Client
                    {
                        Nom = Nom,
                        Tel = Tel,
                        Fax = Fax,
                        Adresse = Adr,
                        Ville = Ville,
                        Siteweb = Siteweb,
                        Debutcontract = dtDebutcontract.Value,
                        Heurecontract = Heure,
                        Prixheur = Prix,
                        Datecreation = DateTime.Now,
                        IsDeleted = 0
                    };
                    context.Clients.Add(client);
                    // ADD Departement To Client 
                    foreach (var item in DepartementList)
                    {
                        if (item.Id == 0 && !item.IsDeleted && item.Value != "")
                        {
                            dt = new Departement { IdCLient = client.id, Nom = item.Value ,IsDeleted = 0 };
                            context.Departements.Add(dt);
                            //    MessageBox.Show("Nom du Département existant");
                      
                            
                        }
                        else if (item.Id == 0 && item.IsDeleted)
                        {
                            txtlblDepartement tbx = this.Controls.Find(item.Controlname, true).FirstOrDefault() as txtlblDepartement;
                            PnlDepart.Controls.Remove(tbx);
                        }
                    }
                    foreach (var item in UtilisateursList)
                    {
                        if (item.Id > 0 && !item.IsDeleted && item.Value != "")
                        {
                            var d = context.AffectationClients.Any(dd => dd.Idutilisateur == item.Id && dd.Idclient == client.id);

                            if (!d)
                            {
                                user = new AffectationClient { Idclient = client.id, Idutilisateur = item.Id, Dateaffectation = DateTime.Now, IsDeleted = 0 };
                                context.AffectationClients.Add(user);
                                context.SaveChanges();
                            }
                        }
                        else if (item.Id == 0 && item.IsDeleted)
                        {
                            lblTextbox tbx = this.Controls.Find(item.Controlname, true).FirstOrDefault() as lblTextbox;
                            PnlUsers.Controls.Remove(tbx);
                        }
                    }
                    //save Change
                    context.SaveChanges();
                    MessageBox.Show("Ajout d'un client effectué");
                    // clear textbox 
                    Methods.Clear(this);
                    Methods.ClearControls(this);
                }
            }
        }


        private void txtHeure_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_Validating(object sender, CancelEventArgs e)
        {
        }



        private void btnDelClient_Click(object sender, EventArgs e)
        {


            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                Client c = context.Clients.Find(idC);

                DialogResult result = MessageBox.Show("Voulez-vous supprimer le client suivant ?", "confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    c.IsDeleted = 1;
                    c.Datemodification = DateTime.Now;
                    c.Modifierpar = 1;
                    context.SaveChanges();
                    MessageBox.Show("client supprimé");
                    Methods.Clear(this);
                }
                else if (result == DialogResult.No)
                {

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var labelControlList2 = Methods.GetidList(PnlUsers);

            foreach (var item in labelControlList2)
            {
                MessageBox.Show($"{item.Id}, {item.Controlname},{item.Idaffectation}");
            }
        }
    }
}
