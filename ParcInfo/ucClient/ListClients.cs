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
using ParcInfo.frmDefault;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq.Dynamic;
using ParcInfo.ucInterevntion;
using System.Reflection;

namespace ParcInfo.ucClient
{
    public partial class ListClients : UserControl
    {
        public ListClients()
        {
            InitializeComponent();

            // ControlsClass.CreateRadiusBorder(this);
        }
        private void ListClients_Load(object sender, EventArgs e)
        {
            
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var vr = context.Clients.Where(c=> c.IsDeleted == 0).ToList();
                dgClients.DataSource = Methods.ToDataTable(vr.Select(c=>new
                { c.IdCLient, c.id, c.Nom,
                    c.Adresse, c.Tel, c.Fax,
                    c.Siteweb, c.Prixheur, c.Heurecontract,
                    c.Debutcontract,
                    userMod = c.Utilisateur1 != null ? c.Utilisateur.Nom : "aucune",
                     dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                }).ToList());
                myGrid();
            }
        }
        private void GridListClient_DoubleClick(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string code = myrow.Cells["IdCLient"].Value.ToString();
                GlobVars.frmindex.ShowControl(new CreateClient(id,code));
            }
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
            GlobVars.frmindex.ShowControl(new CreateClient(0,""));
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
                GlobVars.frmindex.ShowControl(new ListeIntervention(id,code));
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
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                var vr = (from c in context.Clients
                          select c).ToList();
                //dgClients.DataSource = vr;

                if (CkDeletedClient.Checked)
                {
                    var ClientsDeleted = (from c in vr
                                          where c.IsDeleted == 1
                                          select new { c.IdCLient, c.id, c.Nom, c.Adresse,
                                              c.Tel, c.Fax, c.Siteweb, c.Prixheur,
                                              c.Heurecontract, c.Debutcontract,
                                              userMod = c.Utilisateur1 != null ? c.Utilisateur.Nom : "aucune",
                                              dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                                          }).ToList();
                    dgClients.DataSource = Methods.ToDataTable(ClientsDeleted);
                    myGrid();
                }
                else
                {
                    var Clients = (from c in vr
                                   where c.IsDeleted == 0
                                   select new { c.IdCLient, c.id, c.Nom, c.Adresse,
                                       c.Tel, c.Fax, c.Siteweb, c.Prixheur,
                                       c.Heurecontract, c.Debutcontract,
                                       userMod = c.Utilisateur1 != null ? c.Utilisateur.Nom : "aucune",
                                       dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****",
                                   }).ToList();
                    dgClients.DataSource = Methods.ToDataTable(Clients);
                    myGrid();
                }
              
            }
        }

        private void dgClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
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
                    lblEmpC.Text = Cli.Employees.Where(d=> d.IsDeleted == 0).Count().ToString();
                    lblInterC.Text = Cli.Interventions.Where(d => d.IsDeleted == 0).Count().ToString();
                    var demC = (from c in Cli.Employees
                                from d in c.Demandes
                                select d).ToList();
                    lblDemC.Text = demC.Where(d=> d.IsDeleted == 0).Count().ToString();
                    lblProdC.Text = Cli.ProduitClients.Where(d=> d.IsDeleted == 0).Count().ToString();
                }
            }

        }

        public void myGrid()
        {


            Methods.Nice_grid(
                new string[] { "IdCLient", "id", "Nom", "Adresse", "Tel", "Fax", "Siteweb", "Prixheur", "Heurecontract", "Debutcontract","userMod","dateMod" },
                new string[] { "ID Client", "id", "Nom", "Adresse", "Tel", "Fax", "Site web ", "Prix Heure", "Heure Contract", "Debut Contract","user","datemod" },
                dgClients
                );
            dgClients.Columns["userMod"].Visible = false;
            dgClients.Columns["dateMod"].Visible = false;
            Methods.FilterDataGridViewIni(dgClients, txtFind, btnFind);

        }

    }
}
