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
using System.Data.Entity;

namespace ParcInfo.ucParametre
{
    public partial class userProfile : UserControl
    {
        public userProfile()
        {
            InitializeComponent();

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                var u = context.Utilisateurs.Find(GlobVars.cuUser.Id);
                if (u != null)
                    {
                        txtNom.Text = u.Nom;
                        txtPrenom.Text = u.Prenom;
                        txtAdr.Text = u.Adresse;
                        txtVille.Text = u.Ville;
                        txtTel.Text = u.Tel;
                        txtEmail.Text = u.Email;
                        var dat =DateTime.Now.AddDays(-30);
                        //lblCountInterv.Text = u.Interventions.Where(d => d.DateIntervention >= dat).Count().ToString();
                        //lblCountDemande.Text = context.GetAssignedRequestbyStatut().Where(d=> d.Datedemande >= dat).Count().ToString();
                        //lblCountClient.Text = u.Clients.Count.ToString();
                      
                    }
                }

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // get value
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {



                int txtempty = 0;

                txtempty = Methods.Focus(gpInfo);
                var u = context.Utilisateurs.Find(GlobVars.cuUser.Id);
                if (txtempty > 0)
                {
                   
                    u.Nom = Methods.RemoveSpace(txtNom.Text);
                    u.Prenom = Methods.RemoveSpace(txtPrenom.Text);
                    u.Adresse = Methods.RemoveSpace(txtAdr.Text);
                    u.Ville = Methods.RemoveSpace(txtVille.Text);
                    u.Tel = txtTel.Text;
                  
                }
               int txtempty1 = 0;

      

                if (txtOldPass.Text != "" && txtNewPass.Text != "" && txtConfPass.Text != "")
                {
                        var hashPass = Methods.MD5Hash(txtOldPass.Text);
                        if (hashPass == u.password_u)
                        {
                            if (txtNewPass.Text == txtConfPass.Text)
                            {
                                u.password_u = Methods.MD5Hash(txtNewPass.Text);
                                u.PassChanged = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("password incorrect");
                        }
                 
                }
               
         
                context.SaveChanges();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
            
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
