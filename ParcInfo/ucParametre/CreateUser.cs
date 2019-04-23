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
        public string stringMsg(string nom, string prenom,string email,string password)
        {
            string msg = $"<p>Hello <b>{nom} {prenom}</b></p><br>" +
                $"you have been registered successfully <br>" +
                $"Here Your Login credentials <br> " +
                $"<b>Email : {email}</b> <br>" +
                $"<b>Password : {password} </b>";
            return msg;
        }
        public void sendEmail(string email,string msg)
        {
            MailMessage mail = new MailMessage("parcinfoit@gmail.com",email);
            mail.Subject = "subj";
            mail.Body = msg;
            mail.IsBodyHtml = true;
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))    
            {               client.EnableSsl = true;   

              client.Credentials = new System.Net.NetworkCredential("parcinfoit@gmail.com", "parc123456");
              client.Send(mail);           
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
                    string password = CreatePassword(8);
                    int isAdmin = 0;
                    if (ckAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    var haspass = MD5Hash(password);
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
                        var body = stringMsg(Nom, Prenom, Email, password);
                        sendEmail(Email, body);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("email already exists");
                    }
                 
                }
                    
            }

        }
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
