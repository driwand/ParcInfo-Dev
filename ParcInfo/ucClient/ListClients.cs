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

                
                var vr = (from c in context.Clients
                          where c.IsDeleted != 1
                          select new { c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c.Debutcontract, }).ToList();
                dgClients.DataSource = vr;

            }

        }



        private void GridListClient_DoubleClick(object sender, EventArgs e)
        {

            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells[0].Value.ToString());
               
                GlobVars.frmindex.ShowControl(new CreateClient(id));
            }

        }

        private void gpEmployee_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id = int.Parse(myrow.Cells[0].Value.ToString());
            
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListEmployees(id), true);
            }
        }
      
        private void btnNewClient_Click(object sender, EventArgs e)
        {
            
            GlobVars.frmindex.ShowControl(new CreateClient(0));
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                int id =int.Parse(myrow.Cells[0].Value.ToString());
                //GlobVars.selectedClient = int.Parse(id);
                //GlobVars.BtnName = ((Control)sender).Name;

                GlobVars.frmindex.ShowControl(new CreateClient(id));
            }
        }

        private void gpIntervention_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new ListeIntervention());
          
        }

        private void gpDemande_Click(object sender, EventArgs e)
        {
            int index = dgClients.CurrentRow.Index;

            string nom = dgClients.Rows[index].Cells[0].Value.ToString();

            GlobVars.NomClient = nom;
            GlobVars.SearchValue = txtFind.Text;
            GlobVars.frmindex.ShowControl(new ListDemande("",0));

        }

        private void gpProduit_Click(object sender, EventArgs e)
        {
            int index = dgClients.CurrentRow.Index;

            string nom = dgClients.Rows[index].Cells[0].Value.ToString();

            GlobVars.NomClient = nom;

            GlobVars.frmindex.ShowControl(new ListProduit());

        }

        //start new intervention for seelcted request
        private void btnStartIntervention_Click(object sender, EventArgs e)
        {
            int index = dgClients.CurrentRow.Index;

            int id = int.Parse(dgClients.Rows[index].Cells[0].Value.ToString());
            //GlobVars.selectedClient = id;

            GlobVars.frmindex.ShowControl(new NewIntervention() { selectedClient = id });
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
                                          select new { c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c.Debutcontract }).ToList();
                    dgClients.DataSource = ClientsDeleted;
                }
                else
                {
                    var Clients = (from c in vr
                                   where c.IsDeleted != 1
                                   select new { c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c.Debutcontract }).ToList();
                    dgClients.DataSource = Clients;
                }
            }
        }

        private void dgClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var myrow = dgClients.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells[0].Value.ToString());
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
    }
}
