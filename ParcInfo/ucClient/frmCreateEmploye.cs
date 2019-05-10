using ParcInfo.Classes;
using ParcInfo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucClient
{
    public partial class frmCreateEmploye : Form
    {

        public int idE = 0;
        public int idC = 0;
        DataGridView dgEmp;
        public frmCreateEmploye(int idEmploye, int idClient, string code, DataGridView dg)
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
                    if (emp.IsDeleted == 1)
                    {
                        btnDelEmp.Visible = false;
                        btnAnnuler.Visible = false;
                        btnAjouter.Visible = false;
                    }
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
                txtEmpty += Methods.Focus(this);
                if (btnAjouter.Text == "Enregistrer")
                {
                    this.Text = "Modifier employee";
                    // get values 
                    var idEmp = context.Employees.Find(idE);

                    string pass = Methods.RemoveSpace(txtPass.Text);
                    idEmp.Nom = Methods.RemoveSpace(txtNom.Text);
                    idEmp.Prenom = Methods.RemoveSpace(txtPrenom.Text);
                    idEmp.Tel = txtTel.Text;
                    if (txtPass.Text.Trim() != "")
                    {
                        idEmp.Password_e = Methods.MD5Hash(pass);
                        var msg = Methods.StringForget(idEmp.Nom, idEmp.Prenom, pass);
                        Methods.sendEmail(txtEmail.Text, msg);
                    }
                    idEmp.IdDep = int.Parse(txtDeaprt.SelectedValue.ToString());
                    int Respo = 0;
                    if (cbRespo.Checked)
                    {
                        Respo = 1;
                    }

                    context.UserActivities.Add(new UserActivity
                    {
                        Iduser = GlobVars.cuUser.Id,
                        Activity = $"Employé [{idEmp.IdEmploye}] Modifié le {DateTime.Now}"
                    });
                    idEmp.IsResponsable = Respo;
                    idEmp.Modifierpar = GlobVars.cuUser.Id;
                    idEmp.Datemodification = DateTime.Now;
                    context.SaveChanges();
                   
                    Close();
                    GlobVars.frmindex.ShowControl(new ListEmployees(idC));
                }
                else if (btnAjouter.Text == "Ajouter")
                {
                    if (txtEmpty == 0)
                    {
                        // get values 
                        string Nom = Methods.RemoveSpace(txtNom.Text);
                        string Prenom = Methods.RemoveSpace(txtPrenom.Text);
                        string Tel = Methods.RemoveSpace(txtTel.Text);
                        string Email = Methods.RemoveSpace(txtEmail.Text);
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

                        var emailValid = IsValid(Email);
                        if (emailValid)
                        {
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
                                    Password_e = pass,
                                    IsDeleted = 0,
                                    Creepar = GlobVars.cuUser.Id,
                                };
                                context.Employees.Add(emp);
                                context.UserActivities.Add(new UserActivity
                                {
                                    Iduser = GlobVars.cuUser.Id,
                                    Activity = $"Employé [{emp.IdEmploye}] Ajouté  le {DateTime.Now}"
                                });
                                context.SaveChanges();
                                Methods.sendEmail(Email, msg);
                                MessageBox.Show("L'Employé a été ajouté");
                                // clear textbox 
                                Methods.Clear(this);
                                Close();
                                GlobVars.frmindex.ShowControl(new ListEmployees(idC));
                            }
                            else
                            {
                                MessageBox.Show("email already exists");
                            }
                        }
                        else
                        {
                            txtEmail.BackColor = Color.FromArgb(235, 77, 75);
                            txtEmail.ForeColor = Color.White;
                            txtEmail.Focus();
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
                    c.Modifierpar = GlobVars.cuUser.Id;

                    c.Demandes.ToList().ForEach(cc =>
                    {
                        cc.IsDeleted = 1;
                    });
                    c.ProduitUtilisers.ToList().ForEach(pr =>
                    {
                        pr.IsDeleted = 1;
                        pr.Datemodification = DateTime.Now;
                        pr.Modifierpar = GlobVars.cuUser.Id;
                    });

                    c.Datemodification = DateTime.Now;
                    context.SaveChanges();
                    context.UserActivities.Add(new UserActivity
                    {
                        Iduser = GlobVars.cuUser.Id,
                        Activity = $"Employé [{c.IdEmploye}] Supprimé  le {DateTime.Now}"
                    });
                    MessageBox.Show("Employé supprimé");
                    Methods.Clear(this);
                    Close();
                    updateGrid();
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
                               select new
                               {
                                   emp.IdEmploye,
                                   emp.Id,
                                   emp.Nom,
                                   emp.Prenom,
                                   emp.Email,
                                   departement = d.Nom,
                                   userMod = c.Utilisateur1 != null ? c.Utilisateur.Nom : "aucune",
                                   userID = c.Utilisateur1 != null ? c.Utilisateur1.Id : 0,

                                   dateMod = c.Datemodification != null ? c.Datemodification.ToString() : "**-**-****"
                               }).ToList();
                dgEmp.DataSource = listEmp;
                Methods.Nice_grid(
                new string[] { "IdEmploye", "Id", "Nom", "Prenom", "Email", "departement" },
                new string[] { "ID Employee", "id", "Nom", "Prenom", "Email", "Departement" },
                dgEmp
                );

               
            }
        }

        private void frmCreateEmploye_Load(object sender, EventArgs e)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                var par = db.ParametreParcinfoes.FirstOrDefault();
                if (par != null)
                {
                    if (par.Iconapp != null)
                    {
                        System.Drawing.Bitmap bitmap = Methods.ByteArrayToImage(par.Iconapp) as System.Drawing.Bitmap;
                        IntPtr ico = bitmap.GetHicon();
                        Icon icon = Icon.FromHandle(ico);

                        this.Icon = icon;
                    }
                }
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtNom);
        }


        public void ChangeColor(TextBox txt)
        {
            if (txt.Text.Trim() != "")
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtPrenom);

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtTel);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtEmail);

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var s = IsValid(txtEmail.Text.Trim());
            if (!s)
            {
                txtEmail.Focus();
            }
        }


        public bool IsValid(string emailaddress)
        {
            //string email = emailaddress;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailaddress);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
