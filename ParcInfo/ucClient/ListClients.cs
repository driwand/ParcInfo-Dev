using ParcInfo.Classes;
using ParcInfo.ucInterevntion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace ParcInfo.ucClient
{
    public partial class ListClients : UserControl
    {
        string GetRoleName;
        public ListClients()
        {
            InitializeComponent();
            
            Methods.CheckRoles(Controls);
            var t = GlobVars.cuUser.RoleUtilisateurs1;
            foreach (var v in t)
                if (v.Nom.Contains("Consulter") && v.Nom.Contains("client") && v.IsDeleted != 1)
                    GetRoleName = v.Nom;
        }
        private void ListClients_Load(object sender, EventArgs e)
        {
       
            if (GlobVars.cuUser.isAdmin == 0)
                if (GetRoleName == "Consulter tous les client")
                    GetAllClients();
                else
                    GetAssignedClients();
            else
                GetAllClients();

        }

        public void GetAllClients()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var vr = context.Clients.Where(c => c.IsDeleted == 0).ToList();
                dgClients.DataSource = Methods.ToDataTable(vr.Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                }).ToList());
                myGrid();
            }
        }
        public void GetAllDeletedClients()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var vr = context.Clients.Where(c => c.IsDeleted == 1).ToList();
                dgClients.DataSource = Methods.ToDataTable(vr.Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                }).ToList());
                myGrid();
            }
        }

        public void GetAssignedClients()
        {
            using (var context = new ParcInformatiqueEntities())
            {
                var clt = (from c in context.Clients
                          join af in context.AffectationClients on c.id equals af.Idclient
                          where af.Idutilisateur == GlobVars.cuUser.Id
                          select c).ToList();
                
                dgClients.DataSource = Methods.ToDataTable(clt.Where(c => c.IsDeleted == 0).Select(c => new
                {
                    c.IdCLient,
                    c.id,
                    c.Nom,
                    c.Adresse,
                    c.Tel,
                    c.Fax,
                    c.Siteweb,
                    c.Prixheur,
                    c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                    dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                }).ToList());
                myGrid();
            }
        }

        public void GetAssigneDeletedClients()
        {
            var vr = GlobVars.cuUser.AffectationClients;
            var cl = new List<Client>();
            foreach (var c in vr)
            {
                cl.Add(c.Client);
            }
            dgClients.DataSource = Methods.ToDataTable(cl.Where(c => c.IsDeleted == 1).Select(c => new
            {
                c.IdCLient,
                c.id,
                c.Nom,
                c.Adresse,
                c.Tel,
                c.Fax,
                c.Siteweb,
                c.Prixheur,
                c.Heurecontract,
                c.Debutcontract,
                userMod = c.Utilisateur1 != null ? c.Utilisateur1.Nom : "aucune",
                dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
            }).ToList());
            myGrid();
        }

        private void gpEmployee_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListEmployees(id), true);
            }
        }
        private void btnNewClient_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new CreateClient(0, ""));
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();

                GlobVars.frmindex.ShowControl(new CreateClient(id, code));
            }
        }
        private void gpIntervention_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListeIntervention(id, code));
            }

        }
        private void gpDemande_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string nom = myrow.Cells["IdCLient"].Value.ToString();
                GlobVars.frmindex.ShowControl(new ListDemande(id, nom));
            }
        }
        private void gpProduit_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListProduitClient(id, code));
            }
        }

        //start new intervention for seelcted request
        private void btnStartIntervention_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                int index = dgClients.CurrentRow.Index;
                int id = int.Parse(dgClients.Rows[index].Cells["id"].Value.ToString());
                //GlobVars.selectedClient = id;

                GlobVars.frmindex.ShowControl(new NewIntervention(id));
            }
        }
        private void CkDeletedClient_CheckedChanged(object sender, EventArgs e)
        {
            btnStartIntervention.Click -= btnStartIntervention_Click;
            gpEmployee.Click -= gpEmployee_Click;
            gpProduit.Click -= gpProduit_Click;
            gpIntervention.Click -= gpIntervention_Click;
            gpDemande.Click -= gpDemande_Click;

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (GlobVars.cuUser.isAdmin == 0)
                    if (GetRoleName == "Consulter tous les client")
                        if (CkDeletedClient.Checked)
                            GetAllDeletedClients();
                        else
                        {
                            GetAllClients();  
                        }
                    else
                        if (CkDeletedClient.Checked)
                            GetAssigneDeletedClients();
                        else
                            GetAssignedClients();
                else
                    if (CkDeletedClient.Checked)
                    GetAllDeletedClients();
                else
                {
                    GetAllClients();
                    btnStartIntervention.Click += btnStartIntervention_Click;
                    gpEmployee.Click += gpEmployee_Click;
                    gpProduit.Click += gpProduit_Click;
                    gpIntervention.Click += gpIntervention_Click;
                    gpDemande.Click += gpDemande_Click;
                }
                  
            }
        }

        private void dgClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var myrow = dgClients.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    // Modifier par / date modification
                    string nomUser = myrow.Cells["userMod"].Value.ToString();
                    string date = myrow.Cells["dateMod"].Value.ToString();
                    int loc = 325;
                    lblEdited.Text = nomUser;
                    loc += lblEdited.Width;
                    lblMod.Location = new Point(loc, 462);
                    lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
                    lblEditedDate.Text = date;
                    var Cli = context.Clients.Where(c => c.id == id).FirstOrDefault();
                    if (Cli != null)
                    {
                        lblEmpC.Text = Cli.Employees.Where(d => d.IsDeleted == 0).Count().ToString();
                        lblInterC.Text = Cli.Interventions.Where(d => d.IsDeleted == 0).Count().ToString();
                        var demC = (from c in Cli.Employees
                                    from d in c.Demandes
                                    select d).ToList();
                        lblDemC.Text = demC.Where(d => d.IsDeleted == 0).Count().ToString();
                        lblProdC.Text = Cli.ProduitClients.Where(d => d.IsDeleted == 0).Count().ToString();
                    }

                }
            }

        }

        public void myGrid()
        {


            Methods.Nice_grid(
                new string[] { "IdCLient", "id", "Nom", "Adresse", "Tel", "Fax", "Siteweb", "Prixheur", "Heurecontract", "Debutcontract" },
                new string[] { "ID Client", "id", "Nom", "Adresse", "Tel", "Fax", "Site web ", "Prix Heure", "Heure Contract", "Debut Contract" },
                dgClients
                );

            Methods.FilterDataGridViewIni(dgClients, txtFind, btnFind);

        }

        private void dgClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //if (dgClients.SelectedRows.Count > 0)
                //{
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();
                GlobVars.frmindex.ShowControl(new CreateClient(id, code));
                //}
            }
        }
        public void CountToZero()
        {
            if (dgClients.Rows.Count == 0)
            {
                lblDemC.Text = "0";
                lblEmpC.Text = "0";
                lblInterC.Text = "0";
                lblProdC.Text = "0";
            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            CountToZero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
            int id = int.Parse(myrow.Cells["id"].Value.ToString());
            MessageBox.Show(id.ToString());
        }
    }
}
