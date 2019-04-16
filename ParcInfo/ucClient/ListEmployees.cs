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

namespace ParcInfo.ucClient
{
    public partial class ListEmployees : UserControl
    {
        public ListEmployees()
        {
            InitializeComponent();
        }

        private void ListEmployees_Load(object sender, EventArgs e)
        {

            // Show List Employe [Client]
            if (GlobVars.selectedClient > 0 && GlobVars.BtnName == "gpEmploye")
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    int id = GlobVars.selectedClient;
                    Client c = context.Clients.Find(id);
                    lblClientName.Visible = true;
                    lblClientName.Text = $"[{c.Nom}]";


                    var listEmp = (from emp in c.Employees
                                   join d in c.Departements on emp.IdDep equals d.id
                                   select new { emp.Id, emp.Nom, emp.Prenom, emp.Email, emp.Login_e, emp.Password_e, departement = d.Nom }).ToList();
                    dgEmployees.DataSource = listEmp;
                }

            }
        }



        private void gpDemandeEnCours_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedEmploye = int.Parse(id);
                GlobVars.BtnName = "gpDemandeEncours";
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListDemande(), true);
            }
        }

        private void gpDemandeRetard_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedEmploye = int.Parse(id);
                GlobVars.BtnName = "gpDemandeEnRetard";
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListDemande(), true);
            }
        }

        private void gpDemande_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedEmploye = int.Parse(id);
                GlobVars.BtnName = "gpDemandeE";
                GlobVars.frmBack = this;
                GlobVars.frmindex.ShowControl(new ListDemande(), true);
            }
        }

        private void gpProduits_Click(object sender, EventArgs e)
        {
        }

        private void btnNewEmploye_Click(object sender, EventArgs e)
        {
            frmCreateEmploye frm = new frmCreateEmploye();
            frm.ShowDialog();
        }

        private void btnEditEmploye_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count > 0)
            {
                var myrow = dgEmployees.Rows[dgEmployees.CurrentRow.Index];
                string id = myrow.Cells[0].Value.ToString();
                GlobVars.selectedEmploye = int.Parse(id);
                GlobVars.BtnName = "editEmploye";

                frmCreateEmploye frm = new frmCreateEmploye();

                frm.Show();


            }
        }

        private void dgEmployees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var myrow = dgEmployees.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells[0].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
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

                }
            }
        }

        private void cbDeleted_CheckedChanged(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {


                int id = GlobVars.selectedClient;
                Client c = context.Clients.Find(id);



                var listEmp = (from emp in c.Employees
                               join d in c.Departements on emp.IdDep equals d.id
                               select new { emp.Id, emp.Nom, emp.Prenom, emp.Email, emp.Login_e, emp.Password_e, departement = d.Nom, emp.IsDeleted }).ToList();
                dgEmployees.DataSource = listEmp;

                if (cbDeleted.Checked)
                {

                    var EmployeesDeleted = listEmp.Where(d => d.IsDeleted == 1).ToList();
                    dgEmployees.DataSource = EmployeesDeleted;
                }
                else
                {
                    var Employees = listEmp.Where(d => d.IsDeleted != 1).ToList();
                    dgEmployees.DataSource = Employees;
                }
            }
        }
    }
}
