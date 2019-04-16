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
        public frmCreateEmploye()
        {
            InitializeComponent();

               
                int idClient = GlobVars.selectedClient;
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                // var listClient = context.Clients.ToList();
                btnAjouter.Text = "Ajouter";
                var Cli = context.Clients.Where(c=> c.id == idClient).FirstOrDefault();
                


                    txtDeaprt.DataSource = Cli.Departements.Where(d => d.IdDeleted != 1).ToList();
                    txtDeaprt.ValueMember = "id";
                    txtDeaprt.DisplayMember = "Nom";


                if (GlobVars.selectedEmploye > 0)
                {
                    btnAjouter.Text = "Enregistrer";
                    btnDelEmp.Visible = true;
                    int idEmp = GlobVars.selectedEmploye;
                    var emp = Cli.Employees.Where(e => e.Id == idEmp).FirstOrDefault();
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
            }
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int idC = GlobVars.selectedClient;
            int idE = GlobVars.selectedEmploye;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {


                int txtEmpty = 0;


                txtEmpty += Methods.Foucs(gbEmploye);
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
                    idEmp.Datemodification = DateTime.Now;
                    context.SaveChanges();
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
