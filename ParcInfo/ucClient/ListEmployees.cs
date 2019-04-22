using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucClient;
using ParcInfo.Classes;

namespace ParcInfo.ucClient
{
    public partial class ListEmployees : UserControl
    {


        public int idC = 0;
        public ListEmployees(int idClient)
        {
            InitializeComponent();
            if (idClient > 0)
            {
                idC = idClient;
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                    Client c = context.Clients.Find(idClient);
                    lblClientName.Visible = true;
                    lblClientName.Text = $"[{c.Nom}]";


                    var listEmp = (from emp in c.Employees
                                   join d in c.Departements on emp.IdDep equals d.id
                                   where emp.IsDeleted != 1
                                   select new { emp.IdEmploye, emp.Id, emp.Nom, emp.Prenom, emp.Email, emp.Login_e, emp.Password_e, departement = d.Nom }).ToList();
                    dgEmployees.DataSource = Methods.ToDataTable(listEmp);
                    myGrid();
                   
                }
            }

        }

        private void ListEmployees_Load(object sender, EventArgs e)
        {

        }
        // Employe demande en cours
        private void gpDemandeEnCours_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListDemande("en cours",0,id), true);
            }
        }
        //Employe Demande En retard
        private void gpDemandeRetard_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListDemande("en retard", 0, id), true);
            }
        }
        // Employe demandes
        private void gpDemande_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListDemande("", 0, id), true);
            }
        }
        // Employe Produits
        private void gpProduits_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListProduitClient(id), true);
            }
        }


        // Create Employe 
        private void btnNewEmploye_Click(object sender, EventArgs e)
        {
            frmCreateEmploye frm = new frmCreateEmploye(0,idC,"");
            frm.ShowDialog();
        }
        // Edit Employe
        private void btnEditEmploye_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
               string code =myrow.Cells["IdEmploye"].Value.ToString();
                //GlobVars.selectedEmploye = int.Parse(id);
                //GlobVars.BtnName = "editEmploye";
                frmCreateEmploye frm = new frmCreateEmploye(id,idC,code);
                frm.Show();


            }
        }

        private void dgEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var myrow = dgEmployees.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                    var Cli = context.Employees.Where(c => c.Id == id).FirstOrDefault();
                    var clt = (from c in context.Employees
                               where c.Id == id && c.Modifierpar != null
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
                    // Employe Count


                   
                    encoursCount.Text = context.GetRequestCours.Where(req => req.IdEmployee == Cli.Id).Count().ToString();
                    enretardCount.Text = context.GetRequestRetard.Where(req => req.IdEmployee == Cli.Id).Count().ToString();
                   allCount.Text = Cli.Demandes.Count().ToString();
                   produitCount.Text = Cli.ProduitUtilisers.Count.ToString();


                }
            }
        }

        private void cbDeleted_CheckedChanged(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

            
                Client c = context.Clients.Find(idC);



                var listEmp = (from emp in c.Employees
                               join d in c.Departements on emp.IdDep equals d.id
                               select new { emp.IdEmploye, emp.Id, emp.Nom, emp.Prenom, emp.Email, emp.Login_e, emp.Password_e, departement = d.Nom, emp.IsDeleted }).ToList();
                if (cbDeleted.Checked)
                {

                    var EmployeesDeleted = listEmp.Where(d => d.IsDeleted == 1).ToList();
                    dgEmployees.DataSource = Methods.ToDataTable(EmployeesDeleted);
                    myGrid();
                }
                else
                {
                    var Employees = listEmp.Where(d => d.IsDeleted != 1).ToList();
                    dgEmployees.DataSource = Methods.ToDataTable(Employees);
                    myGrid();
                }
            }
        }

        public void myGrid()
        {
           
            Methods.Nice_grid(
                new string[] { "IdEmploye", "Id", "Nom", "Prenom", "Email", "Login_e", "Password_e", "departement" },
                new string[] { "ID Employee", "id", "Nom", "Prenom", "Email", "Login", "Password", "Departement" },
                dgEmployees
                );
            Methods.FilterDataGridViewIni(dgEmployees, txtFind, btnFind);
        }

     
    }
}
