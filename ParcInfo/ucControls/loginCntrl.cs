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
using ParcInfo.frmDefault;

namespace ParcInfo.ucControls
{
    public partial class loginCntrl : UserControl
    {
        public loginCntrl()
        {
            InitializeComponent();
        }
        public int Focus(Control pnl)
        {
            int count = 0;
            var em = (from x in pnl.Controls.OfType<TextBox>()
                      where x.Text == "" && x.Tag != null
                      select x
                                  ).LastOrDefault();
            if (em != null)
            {

                em.Focus();
                count++;
            }
            return count++;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = "p";
            var pass = "ifwxswIc";

            var hasPass = Methods.MD5Hash(pass);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int txtEmpty = 0;
                txtEmpty = Focus(this);
                if (txtEmpty == 0)
                {
                    var user = (from c in context.Utilisateurs
                                where c.Email == email && c.Password_u == hasPass
                                select c).FirstOrDefault();
                    if (user != null)
                    {
                        pnlError.Visible = false;
                        GlobVars.currentUser = user.Id;
                        GlobVars.cuUser = user;
                        this.Hide();
                        FrmDefault frm = new FrmDefault();
                        frm.ShowDialog();
                    }
                    else
                    {
                        pnlError.Visible = true;
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void closeError_Click(object sender, EventArgs e)
        {
            pnlError.Visible = false;
        }

        private void lblForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobVars.frmLogin.ShowControl(new ForgetPassword());
        }
    }
}
