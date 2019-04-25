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

namespace ParcInfo.ucParametre
{
    public partial class ListUtilisateur : UserControl
    {
        public ListUtilisateur()
        {
            InitializeComponent();
        }
        //get id of selected 'utilisateur'
    

        private void ListUtilisateur_Load(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var u = context.Utilisateurs.Where(d => d.IsDeleted == 0).ToList();

                dgUtilisateur.DataSource = Methods.ToDataTable(u.Select(s => new { s.IdUser, s.Id, s.Nom, s.Prenom, s.Adresse, s.Ville, s.Tel, s.Email }).ToList());
            }
            Methods.Nice_grid(
                            new string[] { "IdUser", "Nom", "Prenom","Adresse", "Ville", "Tel", "Email" },
                            new string[] { "ID Utilisateur", "Nom", "Prenom", "Adresse", "Ville", "Tel", "Email" },
                            dgUtilisateur
                            );
            Methods.FilterDataGridViewIni(dgUtilisateur, txtFind, btnFind);
        }

        private void dgUtilisateur_DoubleClick(object sender, EventArgs e)
        {
            if (dgUtilisateur.SelectedRows.Count > 0)
            {
                int iduser = Convert.ToInt32(dgUtilisateur.Rows[dgUtilisateur.CurrentRow.Index].Cells["id"].Value);
                GlobVars.frmindex.ShowControl(new CreateUser(iduser));
                //GlobVars.frmindex.ShowControl(new CardUsers(iduser));
            }
        }
    }
}
