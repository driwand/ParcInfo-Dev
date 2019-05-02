using ParcInfo.Classes;
using ParcInfo.frmDefault;
using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

            lblForget.Text = "Forget Password ?";
        }
        private void lblForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword frm = new ForgetPassword();
            if (lblForget.Text == "Forget Password ?")
            {
                pnlContainer.Controls.Add(frm);
                frm.BringToFront();
                lblForget.Text = "Retour";
                lblForget.Location = new Point(249, 23);
            }
            else
            {
                pnlContainer.Controls.RemoveAt(0);
                lblForget.Text = "Forget Password ?";
                lblForget.Location = new Point(225, 23);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var pass = txtPassword.Text;
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
                      
                        GlobVars.cuUser = user;
                        GoToDefault();

                        this.Hide();
                    }
                    else
                    {
                        pnlError.Location = new Point(58, 43);
                        lblHead.Location = new Point(224, 11);
                        pnlError.Visible = true;
                    }
                }
            }
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        public void GoToDefault()
        {
            FrmDefault deffrm = new FrmDefault();
            using (var db = new ParcInformatiqueEntities())
            {
                var par = db.ParametreParcinfoes.FirstOrDefault();
                if (par != null)
                {
                    if (par.Logoapp != null)
                    {

                        deffrm.logoPic.BringToFront();
                        deffrm.logoPic.Image = Methods.ByteArrayToImage(par.Logoapp);
                        deffrm.logoPic.SizeMode = PictureBoxSizeMode.Zoom;
                        if (par.Iconapp != null)
                        {
                            System.Drawing.Bitmap bitmap = Methods.ByteArrayToImage(par.Iconapp) as System.Drawing.Bitmap;
                            IntPtr ico = bitmap.GetHicon();
                            Icon icon = Icon.FromHandle(ico);

                            deffrm.Icon = icon;
                        }

                    }
                }
            }
            deffrm.Show();
        }
    }
}
