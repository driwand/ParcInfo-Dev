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
using ParcInfo.ucControls;

namespace ParcInfo.ucParametre
{
    public partial class CardUsers : UserControl
    {
        int idus;
        int uaName = 1;
        public CardUsers(int iduser)
        {
            InitializeComponent();
            idus = iduser;

            using (var db = new ParcInformatiqueEntities())
            {
                var currentuser = db.Utilisateurs.Find(iduser);

                lblUser.Text = currentuser.IdUser;

                txtNom.Text = currentuser.Nom;
                txtPrenom.Text = currentuser.Prenom;
                txtAdr.Text = currentuser.Adresse;
                txtVille.Text = currentuser.Ville;
                txtTel.Text = currentuser.Tel;
                txtEmail.Text = currentuser.Email;
                var cl = currentuser.AffectationClients1.ToList();
                dgClient.DataSource = Methods.ToDataTable(cl.Where(c => c.Client.IsDeleted == 0 && c.IsDeleted == 0).Select(c => new
                {
                    c.Client.IdCLient,
                    c.Client.id,
                    c.Client.Nom,
                    c.Client.Ville,
                    c.Client.Tel,
                }).ToList());

                Methods.Nice_grid(
                    new string[] { "IdCLient", "id", "Nom", "Ville", "Tel"  },
                    new string[] { "ID Client", "id", "Nom", "Ville", "Tel"   },
                    dgClient
                    );
                
                foreach (var item in currentuser.UserActivities.OrderByDescending(i=> i.Id))
                {
                    userHistory uc = new userHistory();
                    uc.Name = "activiy" + uaName;
                    uc.LblActiv = item.Activity;
                    pnlActivites.Controls.Add(uc);
                    pnlActivites.Height  += 30;
                    if (pnlActivites.Size == pnlActivites.MaximumSize)
                    {
                        pnlActivites.AutoScroll = true;

                    }
                }
               
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
           
        }
    }
}
