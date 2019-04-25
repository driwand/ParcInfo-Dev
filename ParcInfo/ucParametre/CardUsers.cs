using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucParametre
{
    public partial class CardUsers : UserControl
    {
        int idus;
        public CardUsers(int iduser)
        {
            InitializeComponent();
            idus = iduser;

            using (var db = new ParcInformatiqueEntities())
            {
                var currentuser = db.Utilisateurs.Find(iduser);

                lblUser.Text = currentuser.IdUser;

                lblNom.Text = currentuser.Nom;
                lblPrenom.Text = currentuser.Prenom;
                lblAdresse.Text = currentuser.Adresse;
                lblVille.Text = currentuser.Ville;
                lblTel.Text = currentuser.Tel;
                lblEmail.Text = currentuser.Tel;

                if (currentuser.Utilisateur3 != null)
                {
                    lblEdited.Text = currentuser.Utilisateur3.Nom;
                    lbldateedit.Text = currentuser.Datemodification.ToString();
                }

                if (currentuser.Utilisateur2 != null)
                {
                    lblCreated.Text = currentuser.Utilisateur2.Nom;
                    lbldatecreaton.Text = currentuser.Datecreation.ToString();
                }

                var interv = db.Interventions.Where(user => user.Idutilisateur == iduser).ToList();
                if (interv != null)
                {

                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }
    }
}
