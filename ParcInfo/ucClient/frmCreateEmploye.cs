using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucClient
{
    public partial class frmCreateEmploye : Form
    {

        public int idE = 0;
        public int idC = 0;
        public frmCreateEmploye(int idEmploye, int idClient)
        {
            InitializeComponent();
            idC = idClient;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                // Edit Employee
                if (idEmploye > 0)
                {
                    idE = idEmploye;
                    btnAjouter.Text = "Enregistrer";
                    btnDelEmp.Visible = true;

                    var emp = context.Employees.Find(idEmploye);
                    if (emp != null)
                    {

                        txtNom.Text = emp.Nom;
                        txtPrenom.Text = emp.Prenom;
                        txtTel.Text = emp.Tel;
                        txtEmail.Text = emp.Email;
                        txtDeaprt.Text = emp.Departement.Nom;
                        if (emp.IsResponsable == 1)
                        {
                            cbRespo.Checked = true;
                        }
                        else
                        {
                            cbRespo.Checked = false;
                        }
                    }
                }

                else
                {
                    btnAjouter.Text = "Ajouter";
                }
                txtDeaprt.DataSource = context.Departements.Where(c => c.IdCLient == idClient).ToList();
                txtDeaprt.ValueMember = "id";
                txtDeaprt.DisplayMember = "Nom";
            }
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int txtEmpty = 0;
              //  txtEmpty += Methods.Foucs(gbEmploye);
                if (btnAjouter.Text == "Enregistrer")
                {
                    // get values 

                    var idEmp = context.Employees.Find(idE);
                    idEmp.Nom = txtNom.Text;
                    idEmp.Prenom = txtPrenom.Text;
                    idEmp.Tel = txtTel.Text;
                    idEmp.Email = txtEmail.Text;
                    idEmp.IdDep = int.Parse(txtDeaprt.SelectedValue.ToString());
                    int Respo = 0;
                    if (cbRespo.Checked)
                    {
                        Respo = 1;
                    }
                    idEmp.IsResponsable = Respo;
                    idEmp.Modifierpar = 1;
                    idEmp.Datemodification = DateTime.Now;
                    
                    context.SaveChanges();
                    Close();
                }
                else if (btnAjouter.Text == "Ajouter")
                {
                    if (txtEmpty == 0)
                    {
                        // get values 
                        string Nom = txtNom.Text;
                        string Prenom = txtPrenom.Text;
                        string Tel = txtTel.Text;
                        string Email = txtEmail.Text;
                        int Departement = int.Parse(txtDeaprt.SelectedValue.ToString());
                        int Respo = 0;
                        if (cbRespo.Checked)
                        {
                            Respo = 1;
                        }

                        Employee emp = new Employee { Nom = Nom, Prenom = Prenom, Tel = Tel, Email = Email, IdDep = Departement, Idclient = idC, IsResponsable = Respo };
                        context.Employees.Add(emp);
                        context.SaveChanges();
                        MessageBox.Show("L'Employé a été ajouté");
                        // clear textbox 
                        Methods.Clear(this);
                        Close();
                    }
                }


            }
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            int id = GlobVars.selectedEmploye;

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                Employee c = context.Employees.Find(id);

                DialogResult result = MessageBox.Show("Voulez-vous supprimer le Employé suivant ?", "confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    c.IsDeleted = 1;
                    context.SaveChanges();
                    MessageBox.Show("Employé supprimé");
                    Methods.Clear(this);
                    Close();
                }
                else if (result == DialogResult.No)
                {

                }


            }
        }
    }
}
