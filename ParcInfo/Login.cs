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
using ParcInfo.frmDefault;
namespace ParcInfo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ControlsClass.CreateRadiusBorder(pnlLogin,14,14);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var pass = txtPassword.Text;

            string hasPass = Methods.MD5Hash(pass);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var user = (from c in context.Utilisateurs
                            where c.Email == email && c.Password_u == hasPass
                            select c).FirstOrDefault();

                if (user != null)
                {
                    GlobVars.currentUser = user.Id;
                    this.Hide();
                    FrmDefault frm = new FrmDefault();
                    frm.ShowDialog();
                }

            }
        }
    }
}
