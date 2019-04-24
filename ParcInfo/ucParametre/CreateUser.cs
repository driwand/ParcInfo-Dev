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
using System.Security.Cryptography;
using System.Net.Mail;

namespace ParcInfo.ucParametre
{
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();

            using (ParcInformatiqueEntities context  = new ParcInformatiqueEntities())
            {
                var c = context.Clients.Where(d => d.IsDeleted == 0).ToList();
                dgClient.DataSource = Methods.ToDataTable(c.Select(cl => new { cl.IdCLient,cl.id, cl.Nom, cl.Tel }).ToList());
                Methods.Nice_grid(
                                 new string[] { "IdCLient", "id", "Nom", "Tel" },
                                 new string[] { "ID Client", "id", "Nom", "Tel" },
                                 dgClient
                                 );
                Methods.FilterDataGridViewIni(dgClient, txtFind, btnFind);
            }
        }

     
        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int txtEmpty = 0;
                txtEmpty = Methods.Focus(this);
                if (txtEmpty == 0)
                {
                    // get values
                    string Nom = txtNom.Text;
                    string Prenom = txtPrenom.Text;
                    string Adr = txtAdresse.Text;
                    string Ville = txtVille.Text;
                    string Tel = txtTel.Text;
                    string Email = txtEmail.Text;
                    string password = Methods.CreatePassword(8);
                    int isAdmin = 0;
                    if (ckAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    var haspass = Methods.MD5Hash(password);
                    context.Utilisateurs.Add(new Utilisateur
                    {
                        Nom = Nom,
                        Prenom = Prenom,
                        Adresse = Adr,
                        Ville = Ville,
                        Tel = Tel,
                        Email = Email,
                        isAdmin = isAdmin,
                        Datecreation = DateTime.Now,
                        
                       Password_u = haspass
                    });

                    var emailEs = context.Utilisateurs.Any(i => i.Email == Email);
                    if (!emailEs)
                    {
                        var body = Methods.stringMsg(Nom, Prenom, Email, password);
                        Methods.sendEmail(Email, body);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("email already exists");
                    }
                }
                    
            }

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
