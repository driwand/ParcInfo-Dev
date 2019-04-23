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

namespace ParcInfo.ucClient
{
    public partial class ListProduitClient : UserControl
    {

        public int idEmp;
        public ListProduitClient(int idEmploye)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (idEmploye > 0)
                {
                    idEmp = idEmploye;
                    var listProd = (from c in context.ProduitUtilisers
                                    where c.IdEmployee == idEmploye
                                    join p in context.ProduitClients on c.IdProduitClient equals p.Id
                                    join pr in context.Produits on p.Idproduit equals pr.id
                                    select new { pr, p, c }).ToList();
                    var d = (from c in listProd
                             select new { c.pr.CodeP,c.c.Id,idP= c.pr.id, c.pr.TypeProduit.Nom, c.pr.Marque, c.c.Login_u, c.c.Password_u, c.c.Dateaffectation }).ToList();
                    dgProduit.DataSource = Methods.ToDataTable(d);
                    //dgProduit.Columns["idP"].Visible = false;
                    Methods.Nice_grid(
                                   new string[] { "CodeP", "id", "idP", "Nom", "Marque", "Login_u", "Password_u", "Dateaffectation" },
                                   new string[] { "Code Produit", "id", "idP", "Type", "Marque", "Login", "Password", "Date d'affectation" },
                                   dgProduit
                                   );
                    Methods.FilterDataGridViewIni(dgProduit, txtFind, btnFind);
                }
            }
        }
        public ListProduitClient(int idClient, string code)
        {
            InitializeComponent();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (idClient > 0)
                {
                    lblClient.Text = $"[{code}]";
                    lblClient.Visible = true;
                    var c = context.Clients.Find(idClient);
                    var listProduitC = context.ProduitClients.Where(d => d.IsDeleted == 0).ToList();
                    var listProduit = (from f in listProduitC
                                       where idClient == f.Idclient
                                       join d in context.Produits on f.Idproduit equals d.id
                                       //join pu in context.ProduitUtilisers on f.Id equals pu.IdProduitClient
                                       select new
                                       {
                                           d.CodeP,
                                           id = f.Idclient,
                                           idP = f.Idproduit,
                                           d.TypeProduit.Nom,
                                           d.Marque,
                                           d.Model,
                                           hardware = d.IsHardware == 1 ? "Oui" : "Non"
/*                                           employe = pu.Employee.Nom + pu.Employee.Prenom*/  ,
                                           f.Dateaffectation
                                       }).ToList();

                    dgProduit.DataSource = Methods.ToDataTable(listProduit);

                    dgProduit.Columns["idP"].Visible = false;
                    Methods.Nice_grid(
                                   new string[] { "CodeP", "id", "idP", "Nom", "Adresse", "Marque", "Model", "hardware", "Dateaffectation" },
                                   new string[] { "Code Produit", "id", "idP", "Type", "Marque", "Model", "hardware", "Date d'affectation" },
                                   dgProduit
                                   );
                    Methods.FilterDataGridViewIni(dgProduit, txtFind, btnFind);
                }

            }
        }
        private void ListProduitClient_Load(object sender, EventArgs e)
        {

        }

        private void dgProduit_DoubleClick(object sender, EventArgs e)
        {
            if (dgProduit.SelectedRows.Count > 0)
            {
                var myrow = dgProduit.Rows[dgProduit.CurrentRow.Index];
                if (idEmp > 0)
                {
                    int id = int.Parse(myrow.Cells["id"].Value.ToString());
                    string idE = idEmp.ToString();
                    GlobVars.frmindex.ShowControl(new DetailProduit(id, idE));
                }
                else
                {

                    int id = int.Parse(myrow.Cells["id"].Value.ToString());
                    int idP = int.Parse(myrow.Cells["idP"].Value.ToString());
                    GlobVars.frmBack = this;
                    GlobVars.frmindex.ShowControl(new DetailProduit(id, idP));
                }

            }
        }

        private void dgProduit_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var myrow = dgProduit.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["idP"].Value.ToString());


                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                   // var cli = context.ProduitClients.Where(c => c.Idproduit == id).FirstOrDefault();
                    var clt = (from c in context.ProduitClients
                               where c.Idproduit == id && c.Modifierpar != null
                               join u in context.Utilisateurs on c.Modifierpar equals u.Id
                               select new { u.Nom, c.Datemodification }).FirstOrDefault();
                    if (clt != null)
                    {
                        int loc = 389;
                        lblEdited.Text = clt.Nom;
                        loc += clt.Nom.Length;
                        lblMod.Location = new Point(loc, 462);
                        // MessageBox.Show(clt.Nom.Length.ToString());
                        lblEditedDate.Location = new Point(439 + 20, 462);
                        lblEditedDate.Text = clt.Datemodification.ToString();
                    }
                    else
                    {
                        lblEdited.Text = "aucune";
                        lblEditedDate.Text = "****-**-**";
                    }
                }

            }


        }
    }
}
