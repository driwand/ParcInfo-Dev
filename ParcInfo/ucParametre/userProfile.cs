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
            if (GlobVars.cuUser.Id > 0)
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var u = GlobVars.cuUser;
                  
                    if (u != null)
                    {
                        txtNom.Text = u.Nom;
                        txtPrenom.Text = u.Prenom;
                        txtAdr.Text = u.Adresse;
                        txtVille.Text = u.Ville;
                        txtTel.Text = u.Tel;
                        txtEmail.Text = u.Email;
                        var dat =DateTime.Now.AddDays(-30);
                        lblCountInterv.Text = u.Interventions.Where(d => d.DateIntervention >= dat).Count().ToString();
                        lblCountDemande.Text = context.GetAssignedRequestbyStatut().Where(d=> d.Datedemande >= dat).Count().ToString();
                        lblCountClient.Text = u.Clients.Count.ToString();
                      
                    }
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            // get value
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {


                var u = GlobVars.cuUser;

                u.Nom = txtNom.Text;
                u.Prenom = txtPrenom.Text;
                u.Adresse = txtAdr.Text;
                u.Ville = txtVille.Text;
                u.Tel = txtTel.Text;

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
    }
}
