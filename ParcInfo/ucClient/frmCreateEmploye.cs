using ParcInfo.Classes;
using ParcInfo.Properties;
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
        DataGridView dgEmp;
        public frmCreateEmploye(int idEmploye, int idClient,string code,DataGridView dg)
        {
            InitializeComponent();
            idC = idClient;
            dgEmp = dg;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                // Edit Employee
                if (idEmploye > 0)
                {
                    idE = idEmploye;
                    lblHeading.Text = "Modifier employee";
                    lblEMP.Text = $"[{code}]";
                    picEmp.Image = Resources.EditEmp;

                    txtDeaprt.Location = new Point(89, 201);
                    lblDepart.Location = new Point(9, 206);
                    txtPass.Location = new Point(89, 166);
                    lblPassword.Location = new Point(9, 170);
                    cbRespo.Location = new Point(92, 239);
                    lblPassword.Visible = true;
                    txtPass.Visible = true;


                    //lblEMP.Location = new Point(195, 21);
                    lblEMP.Visible = true;
                    lblEMP.ForeColor = Color.FromArgb(0, 168, 255);
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
                    this.Text = "Modifier employee";
                    // get values 
                    var idEmp = context.Employees.Find(idE);
                    string pass = txtPass.Text;

                    idEmp.Nom = txtNom.Text;
                    idEmp.Prenom = txtPrenom.Text;
                    idEmp.Tel = txtTel.Text;
                    

                    idEmp.Password_e = Methods.MD5Hash(pass);
                    idEmp.IdDep = int.Parse(txtDeaprt.SelectedValue.ToString());
                    int Respo = 0;
                    if (cbRespo.Checked)
                    {
                        Respo = 1;
                    }
                    idEmp.IsResponsable = Respo;
                    idEmp.Modifierpar = GlobVars.currentUser;
                    idEmp.Datemodification = DateTime.Now;
                    context.SaveChanges();
                    var msg = Methods.stringMsg(idEmp.Nom, idEmp.Prenom, idEmp.Email, pass);
                    Methods.sendEmail(idEmp.Email, msg);
                    Close();
                    updateGrid();
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
                        string login = txtPass.Text;
                       
                        int Respo = 0;
                        if (cbRespo.Checked)
                        {
                            Respo = 1;
                        }

                        string pass = Methods.CreatePassword(8);
                        string msg = Methods.stringMsg(Nom, Prenom, Email, pass);
                         pass = Methods.MD5Hash(pass);
                        var emailE = context.Employees.Any(t => t.Email == Email);
                        var emailU = context.Utilisateurs.Any(t => t.Email == Email);
                        if (!emailE && !emailU)
                        {
                            Employee emp = new Employee
                            {
                                Nom = Nom,
                                Prenom = Prenom,
                                Tel = Tel,
                                Email = Email,
                                IdDep = Departement,
                                Idclient = idC,
                                IsResponsable = Respo,
                                Datecreation = DateTime.Now,
                                Password_e = pass
                            };
                            context.Employees.Add(emp);
                            context.SaveChanges();
                           // Methods.sendEmail(Email, msg);
                            MessageBox.Show("L'Employé a été ajouté");
                            // clear textbox 
                            Methods.Clear(this);
                            Close();
                            updateGrid();
                        }
                        else
                        {
                            MessageBox.Show("email already exists");
                        }
                  
                    }
                }


            }
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                Employee c = context.Employees.Find(idE);

                DialogResult result = MessageBox.Show("Voulez-vous supprimer le Employé suivant ?", "confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    c.IsDeleted = 1;
                    c.Modifierpar = 1;
                    c.Datemodification = DateTime.Now;
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

        public void updateGrid()
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var c = context.Clients.Find(idC);
                var listEmp = (from emp in c.Employees
                               join d in c.Departements on emp.IdDep equals d.id
                               where emp.IsDeleted != 1
                               select new { emp.IdEmploye, emp.Id, emp.Nom, emp.Prenom, emp.Email , emp.Password_e, departement = d.Nom }).ToList();
                dgEmp.DataSource = listEmp;
               Methods.Nice_grid(
               new string[] { "IdEmploye", "Id", "Nom", "Prenom", "Email", "Login_e", "Password_e", "departement" },
               new string[] { "ID Employee", "id", "Nom", "Prenom", "Email", "Login", "Password", "Departement" },
               dgEmp
               );
            }
        }

       
    }
}
