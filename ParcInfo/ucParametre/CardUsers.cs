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
        List<UserActivity> listA = new List<UserActivity>();
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
                dgClient.DataSource = Methods.ToDataTable(cl.Where(c => c.IsDeleted == 0).Select(c => new
                {
                    c.Client.IdCLient,
                    c.Client.id,
                    c.Client.Nom,
                    c.Client.Ville,
                    c.Client.Tel,
                    c.Client.IsDeleted
                }).ToList());

                Methods.Nice_grid(
                    new string[] { "IdCLient", "id", "Nom", "Ville", "Tel" },
                    new string[] { "ID Client", "id", "Nom", "Ville", "Tel"   },
                    dgClient
                    );
                listA = currentuser.UserActivities.OrderByDescending(i => i.Id).ToList();
                //foreach (var item in currentuser.UserActivities.OrderByDescending(i=> i.Id))
                //{

                //}

            }
        }
        public void CreateUserHistory(string activity,Color pnlColor)
        {
            userHistory uc = new userHistory();
            uc.Name = "activiy" + uaName;
            uc.LblActiv = activity;
            uc.LeftColor = pnlColor;
            pnlActivites.Controls.Add(uc);
            pnlActivites.Height += 30;
            if (pnlActivites.Size == pnlActivites.MaximumSize)
            {
                pnlActivites.AutoScroll = true;

            }
            uaName++;
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
           
        }

        public Color GetColor(string activ)
        {
            Color b = Color.Black;
            if (activ.Contains("Produit"))
            {
                b = Color.FromArgb(136, 84, 208);
            }
            else if  (activ.Contains("Client"))
            {
                b = Color.FromArgb(235, 59, 90);
            }
            else if (activ.Contains("Employé") )
            {
                b = Color.FromArgb(38, 222, 129);
            }
         
            else if (activ.Contains("Client"))
            {
                b = Color.FromArgb(235, 59, 90);
            }
            else if (activ.Contains("Utilisateur"))
            {
                b = Color.FromArgb(254, 211, 48);
            }
            return b;
        }


        private void CardUsers_Load(object sender, EventArgs e)
        {
            if (dgClient.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgClient.Rows)
                {

                    var t = item.Cells["IsDeleted"].Value.ToString();
                    if (int.Parse(t) == 1)
                    {
                        item.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 71, 87);
                        item.DefaultCellStyle.SelectionForeColor = Color.White;

                        item.DefaultCellStyle.BackColor = Color.FromArgb(255, 71, 87);
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }
                 
                }
            }
            HistoryLoad();

        }
        public void HistoryLoad()
        {
            if (listA.Count > 0)
            {
                foreach (var item in listA)
                {
                    CreateUserHistory(item.Activity, GetColor(item.Activity));
                }
            }
        }
        public void Show(string Name)
        {
            HistoryLoad();
            var lblDep = (from x in pnlActivites.Controls.OfType<userHistory>()
                          where x.LblActiv.Contains(Name)
                          select x
                            ).ToList();
            //var usAll = (from x in pnlActivites.Controls.OfType<userHistory>()
            //              select x
            //              ).ToList();

            //var ListVis = usAll.Except(lblDep);

            //foreach (var item in ListVis)
            //{
            //    item.Visible = false;
            //}
            pnlActivites.Controls.Clear();
            foreach (var item in lblDep)
            {
                pnlActivites.Controls.Add(item);
            }
        }
        private void PnlProduit_Click(object sender, EventArgs e)
        {
            Show("Produit");
        }

        private void PnlEmploye_Click(object sender, EventArgs e)
        {
            Show("Employé");

        }

        private void PnlClient_Click(object sender, EventArgs e)
        {
            Show("Client");
        }

        private void pnlUtilisateur_Click(object sender, EventArgs e)
        {
            Show("Utilisateur");
        }
    }
}
