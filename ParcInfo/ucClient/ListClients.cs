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
        }
        

        
        private void ListClients_Load(object sender, EventArgs e)
        {
            
            ControlsClass.CreateRadiusBorder(this);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                //var listClient = (from c in context.Clients
                //                  select new {c.id,c.Nom,c.Tel,c.Fax,c.Adresse,c.Ville,c.Siteweb,c.Debutcontract,c.Heurecontract,c.Prixheur,c.Datecreation,c.Datemodification,c.Creepar,c.Modifierpar }).ToList();
               

                dgClients.DataSource = context.Clients.ToList();



                //DataTable dataTable = new DataTable("kkh");
                //object jjj = vr.First();
                //Type myt = jjj.GetType();
                
                ////Get all the properties
                //PropertyInfo[] Props = myt.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                //foreach (PropertyInfo prop in Props)
                //{
                //    //Setting column names as Property names
                //    dataTable.Columns.Add(prop.Name);
                //}
                //foreach (var item in vr)
                //{
                //    var values = new object[Props.Length];
                //    for (int i = 0; i < Props.Length; i++)
                //    {
                //        //inserting property values to datatable rows
                //        values[i] = Props[i].GetValue(item, null);
                //    }
                //    dataTable.Rows.Add(values);
                //}
                //put a breakpoint here and check datatable

                //dgClients.DataSource = dataTable;


 
            }
            

        }



        private void GridListClient_DoubleClick(object sender, EventArgs e)
        {

            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedClient = int.Parse(id);
                GlobVars.BtnName = "btnCons";
                GlobVars.frmindex.ShowControl(new CreateClient());
            }

        }

        private void gpEmployee_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedClient = int.Parse(id);
                GlobVars.BtnName = "gpEmploye";
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListEmployees(), true);
            }
        }
      
        private void btnNewClient_Click(object sender, EventArgs e)
        {
            
            GlobVars.frmindex.ShowControl(new CreateClient());
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            if (dgClients.SelectedRows.Count > 0)
            {
                var myrow = dgClients.Rows[dgClients.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedClient = int.Parse(id);
                GlobVars.BtnName = ((Control)sender).Name;
                GlobVars.frmindex.ShowControl(new CreateClient());
            }
        }

        private void gpIntervention_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new ListeIntervention("",0));
          
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
                          select new { c.id, c.Nom, c.Adresse, c.Tel, c.Fax, c.Siteweb, c.Prixheur, c.Heurecontract, c.Debutcontract, c.IsDeleted }).ToList();
                dgClients.DataSource = vr;

                if (CkDeletedClient.Checked)
                {

                    var ClientsDeleted = vr.Where(d => d.IsDeleted == 1).ToList();
                    dgClients.DataSource = ClientsDeleted;
                }
                else
                {
                    var Clients = vr.Where(d => d.IsDeleted != 1).ToList();
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

                    //var demC = (from c in Cli.Employees
                    //            select new { c.Demandes.Count }).ToList() ;
                    //lblDemC.Text = demC.Count().ToString();
                    lblProdC.Text = Cli.ProduitClients.Count.ToString();
                }
            }

        }
    }
}
