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

namespace ParcInfo.ucControls
{
    public partial class ForgetPassword : UserControl
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobVars.frmLogin.ShowControl(new loginCntrl());
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (txtEmail.Text != "")
                {
                    var userE = context.Utilisateurs.Where(em => txtEmail.Text == em.Email).FirstOrDefault();

                    if (userE != null)
                    {
                        lblErr.Visible = false;
                        var pass = Methods.CreatePassword(8);
                        var stringmsg = Methods.StringForget(userE.Nom, userE.Prenom, pass);

                        var hashPass = Methods.MD5Hash(pass);
                      
                        userE.Password_u = hashPass;
                        userE.PassChanged = 1;
                        Methods.sendEmail(txtEmail.Text, stringmsg);
                        txtEmail.Text = "";
                        context.SaveChanges();
                        MessageBox.Show("Password has been sent to your email.");
                    }
                    else
                    {
                        lblErr.Text = $"The email address '{txtEmail.Text}' is not registered for parcinfo. Please try again";
                    }
                }
                else
                {
                    txtEmail.Focus();
                }
            }
        
        }
    }
}
