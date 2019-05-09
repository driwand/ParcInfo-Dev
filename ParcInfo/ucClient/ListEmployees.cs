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
                Methods.CheckRoles(Controls);
                idC = idClient;
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                    Client c = context.Clients.Find(idClient);
                    lblClientName.Visible = true;
                    lblClientName.Text = $"[{c.Nom}]";

                    if (c.IsDeleted == 1)
                    {
                        btnNewEmployee.Click -= btnNewEmploye_Click;
                    }
                    var listEmp = (from emp in c.Employees
                                   join d in c.Departements on emp.IdDep equals d.id
                                   where emp.IsDeleted == 0
                                   select new { emp.IdEmploye, emp.Id,
                                       emp.Nom, emp.Prenom,
                                       emp.Email,
                                       departement = d.Nom,
                                       userMod =  emp.Utilisateur1 != null ? emp.Utilisateur1.Nom : "aucune",
                                       dateMod = emp.Datemodification != null ? emp.Datemodification.ToString() : "**-**-****",
                                   }).ToList();
                    dgEmployees.DataSource = Methods.ToDataTable(listEmp);
                    myGrid();
                }
            }

        }

        private void ListEmployees_Load(object sender, EventArgs e)
        {
            Methods.CheckRoles(Controls);
        }
        // Employe demande en cours
        private void gpDemandeEnCours_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                GlobVars.lsback.Add(null);

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
                GlobVars.lsback.Add(null);
                
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

                GlobVars.lsback.Add(null);
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

                GlobVars.lsback.Add(null);
                GlobVars.frmindex.ShowControl(new ListProduitClient(id), true);
            }
        }


        // Create Employe 
        private void btnNewEmploye_Click(object sender, EventArgs e)
        {
            frmCreateEmploye frm = new frmCreateEmploye(0,idC,"",dgEmployees);
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
                frmCreateEmploye frm = new frmCreateEmploye(id,idC,code,dgEmployees);
                frm.Show();
            }
        }

        private void dgEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var myrow = dgEmployees.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var emp = context.Employees.Where(c => c.Id == id).FirstOrDefault();
                    string nomUser = myrow.Cells["userMod"].Value.ToString();
                    string date = myrow.Cells["dateMod"].Value.ToString();
                    int loc = 333;
                    lblEdited.Text = nomUser;
                    loc += lblEdited.Width;
                    lblMod.Location = new Point(loc, 462);
                    lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
                    lblEditedDate.Text = date;
                    // Employe Count
                    if (emp != null)
                    {
                        encoursCount.Text = context.GetRequestCours.Where(req => req.IdEmployee == emp.Id).Count().ToString();
                        enretardCount.Text = context.GetRequestRetard.Where(req => req.IdEmployee == emp.Id).Count().ToString();
                        allCount.Text = emp.Demandes.Where(d => d.IsDeleted == 0).Count().ToString();
                        produitCount.Text = emp.ProduitUtilisers.Where(d => d.IsDeleted == 0).Count().ToString();
                        //if (emp.IsDeleted == 1)
                        //{
                        //    gpDemande.Click -= gpDemande_Click;
                        //    gpProduits.Click -= gpProduits_Click;
                        //    gpDemandeEnCours.Click -= gpDemandeEnCours_Click;
                        //    gpDemandeRetard.Click -= gpDemandeRetard_Click;
                        //}
                    }
          
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
                               select new { emp.IdEmploye, emp.Id,
                                   emp.Nom, emp.Prenom,
                                   emp.Email , emp.Password_e,
                                   departement = d.Nom, emp.IsDeleted,
                                   userMod = emp.Utilisateur1 != null ? emp.Utilisateur1.Nom : "aucune",
                                   dateMod = emp.Datemodification != null ? emp.Datemodification.ToString() : "**-**-****",
                               }).ToList();
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
                new string[] { "IdEmploye", "Id", "Nom", "Prenom", "Email",  "departement"  },
                new string[] { "ID Employee", "id", "Nom", "Prenom", "Email",  "Departement" },
                dgEmployees
                );
            //dgEmployees.Columns["userMod"].Visible = false;
            //dgEmployees.Columns["dateMod"].Visible = false;
            Methods.FilterDataGridViewIni(dgEmployees, txtFind, btnFind);
        }

        private void dgEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {
                    var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                    int id = int.Parse(myrow.Cells["id"].Value.ToString());
                    string code = myrow.Cells["IdEmploye"].Value.ToString();
                    //GlobVars.selectedEmploye = int.Parse(id);
                    //GlobVars.BtnName = "editEmploye";
                    frmCreateEmploye frm = new frmCreateEmploye(id, idC, code, dgEmployees);
                    frm.Show();
            }
        }
        public void CountToZero()
        {
            if (dgEmployees.Rows.Count == 0)
            {
                encoursCount.Text = "0";
                enretardCount.Text = "0";
                allCount.Text = "0";
                produitCount.Text = "0";
                int loc = 333;
                loc += lblEdited.Width;
                lblMod.Location = new Point(loc, 462);
                lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
                lblEdited.Text = "aucune";
                lblEditedDate.Text = "**-**-****";

            }
        }
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            CountToZero();
        }

        private void cbDeleted_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
