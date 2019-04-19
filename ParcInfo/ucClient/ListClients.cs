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

                //var vr = context.Clients.Where(c => c.IsDeleted != 1).ToList();
                //var s = (from c in vr
                //         where c.IsDeleted != 1
                //         select new { c.IdCLient, c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c = c.Debutcontract }).ToList();
                dgClients.DataSource = Methods.ToDataTable(vr.Select(c=>new
                { c.IdCLient, c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c = c.Debutcontract, }).ToList());

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
            var myrow = dgClients.Rows[dgClients.CurrentRow.Index];

            int id = int.Parse(myrow.Cells["id"].Value.ToString());
            string nom = myrow.Cells["Nom"].Value.ToString();
            GlobVars.frmindex.ShowControl(new ListDemande(id,nom));

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
            int index = dgClients.CurrentRow.Index;

            int id = int.Parse(dgClients.Rows[index].Cells["id"].Value.ToString());
            //GlobVars.selectedClient = id;

            GlobVars.frmindex.ShowControl(new NewIntervention(id));
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
                                          select new { c.IdCLient, c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c = c.Debutcontract }).ToList();
                    dgClients.DataSource = Methods.ToDataTable(ClientsDeleted);
                    myGrid();
                }
                else
                {
                    var Clients = (from c in vr
                                   where c.IsDeleted != 1
                                   select new { c.IdCLient, c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c = c.Debutcontract }).ToList();
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
                    var Cli = context.Clients.Where(c => c.id == id).FirstOrDefault();


                    var clt = (from c in context.Clients
                               where c.id == id && c.Modifierpar != null
                               join u in context.Utilisateurs on c.Modifierpar equals u.Id
                               select new { u.Nom, c.Datemodification }).FirstOrDefault();
                    if (clt != null)
                    {
                        lblEdited.Text = clt.Nom;
                        lblEditedDate.Text = clt.Datemodification.ToString();
                    }
                    else
                    {
                        lblEdited.Text = "aucune";
                        lblEditedDate.Text = "****-**-**";
                    }
                    // Count
                    lblEmpC.Text = Cli.Employees.Count.ToString();
                    lblInterC.Text = Cli.Interventions.Count.ToString();

                    var demC = (from c in Cli.Employees
                                select new { c.Demandes }).ToList();

                    lblDemC.Text = demC.Count().ToString();
                    lblProdC.Text = Cli.ProduitClients.Count.ToString();
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

    }
}
