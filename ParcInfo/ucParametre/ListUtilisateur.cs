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

                dgUtilisateur.DataSource = Methods.ToDataTable(u.Select(s => new
                {
                    s.IdUser,
                    s.Id,
                    s.Nom,
                    s.Prenom,
                    s.Adresse,
                    s.Ville,
                    s.Tel,
                    s.Email,
                    userMod = s.Utilisateur3 != null ? s.Utilisateur3.Nom : "aucune",
                    dateMod = s.Datemodification != null ? s.Datemodification.ToString() : "**-**-****",
                }).ToList());
                MyGrid();

            }

        }
        private void dgUtilisateur_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgUtilisateur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int iduser = Convert.ToInt32(dgUtilisateur.Rows[dgUtilisateur.CurrentRow.Index].Cells["id"].Value);
                GlobVars.frmindex.ShowControl(new CreateUser(iduser));
                //GlobVars.frmindex.ShowControl(new CardUsers(iduser));
            }
        }

        private void dgUtilisateur_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var myrow = dgUtilisateur.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    // Modifier par / date modification
                    string nomUser = myrow.Cells["userMod"].Value.ToString();
                    string date = myrow.Cells["dateMod"].Value.ToString();
                    int loc = 334;
                    lblEdited.Text = nomUser;
                    loc += lblEdited.Width;
                    lblMod.Location = new Point(loc, 459);
                    lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 459);
                    lblEditedDate.Text = date;
                }
            }
        }

        private void chDelIntr_CheckedChanged(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var li = context.Utilisateurs.ToList();
                var listUser = (from emp in li
                                select new 
                               {
                                   emp.IdUser,
                                   emp.Id,
                                   emp.Nom,
                                   emp.Prenom,
                                   emp.Email,
                                   emp.password_u,
                                   emp.IsDeleted,
                                   userMod = emp.Utilisateur3 != null ? emp.Utilisateur3.Nom : "aucune",
                                   dateMod = emp.Datemodification != null ? emp.Datemodification.ToString() : "**-**-****",
                               }).ToList();

                if (ckDeleted.Checked)
                {
                    var UserDeleted = listUser.Where(d => d.IsDeleted == 1).ToList();
                    dgUtilisateur.DataSource = Methods.ToDataTable(UserDeleted);
                    MyGrid();
                }
                else
                {
                    var Users = listUser.Where(d => d.IsDeleted == 0).ToList();
                    dgUtilisateur.DataSource = Methods.ToDataTable(Users);
                    MyGrid();

                }
            }
        }




        public void MyGrid()
        {
            Methods.Nice_grid(
                new string[] { "IdUser", "Nom", "Prenom", "Adresse", "Ville", "Tel", "Email" },
                new string[] { "ID Utilisateur", "Nom", "Prenom", "Adresse", "Ville", "Tel", "Email" },
                dgUtilisateur
                );
            Methods.FilterDataGridViewIni(dgUtilisateur, txtFind, btnFind);
        }
    }
}
