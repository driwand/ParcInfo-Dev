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
        public int idC;
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
                             where c.c.IsDeleted == 0
                             select new {
                                 c.pr.CodeP,
                                 c.pr.id,
                                 c.pr.TypeProduit.Nom,
                                 c.pr.Marque,
                                 c.c.Login_u,
                                 c.c.Password_u,
                                 c.c.Dateaffectation,
                                userMod = c.c.Utilisateur1 != null ? c.c.Utilisateur1.Nom : "aucune",
                                 dateMod = c.c.Datemodification != null ? c.c.Datemodification.ToString() : "**-**-****",
                             }).ToList();
                    dgProduit.DataSource = Methods.ToDataTable(d);
                   
                    Methods.Nice_grid(
                                   new string[] { "CodeP", "id", "Nom", "Marque", "Login_u", "Password_u", "Dateaffectation" },
                                   new string[] { "Code Produit", "id","Type", "Marque", "Login", "Password", "Date d'affectation" },
                                   dgProduit
                                   );
            //        dgProduit.Columns["idP"].Visible = false;
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
                    idC = idClient;
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
                                           idPC = f.Id,
                                           id = f.Idclient,
                                           idP = f.Idproduit,
                                           d.TypeProduit.Nom,
                                           d.Marque,
                                           d.Model,
                                           count = f.ProduitUtilisers.Count(),
                                           f.Dateaffectation,
                                           userMod = f.Utilisateur1 != null ? f.Utilisateur1.Nom : "aucune",
                                           dateMod = f.Datemodification != null ? f.Datemodification.ToString() : "**-**-****",
                                       }).ToList();

                    dgProduit.DataSource = Methods.ToDataTable(listProduit);

                    myGrid();
                

                }

            }
        }
        private void ListProduitClient_Load(object sender, EventArgs e)
        {

        }

        private void dgProduit_DoubleClick(object sender, EventArgs e)
        {
    
        }
    
        private void dgProduit_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var myrow = dgProduit.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                string nomUser = myrow.Cells["userMod"].Value.ToString();
                string date = myrow.Cells["dateMod"].Value.ToString();

                    // var cli = context.ProduitClients.Where(c => c.Idproduit == id).FirstOrDefault();

                    //var clt = (from c in context.ProduitClients
                    //           where c.Idproduit == id && c.Modifierpar != null
                    //           join u in context.Utilisateurs on c.Modifierpar equals u.Id
                    //           select new { u.Nom, c.Datemodification }).FirstOrDefault();
                    //var pu = (from c in context.ProduitUtilisers
                    //           where c.Id == idPU && c.Modifierpar != null
                    //           join u in context.Utilisateurs on c.Modifierpar equals u.Id
                    //           select new { u.Nom, c.Datemodification }).FirstOrDefault();
                  
                        int loc = 331;
                        lblEdited.Text = nomUser;
                        loc += lblEdited.Width ;
                        lblMod.Location = new Point(loc, 462);
                        // MessageBox.Show(clt.Nom.Length.ToString());
                        lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
                        lblEditedDate.Text = date;
       
            }
        }

        private void dgProduit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
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
                    int idPC = int.Parse(myrow.Cells["idPC"].Value.ToString());

                    
                    GlobVars.frmindex.ShowControl(new DetailProduit(id, idP,idPC));
                }
            }
        }

        private void CkDeletedClient_CheckedChanged(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var c = context.ProduitClients.Where(i => idC == i.Idclient).ToList() ;
                var listProduit = (from f in c
                                   join d in context.Produits on f.Idproduit equals d.id
                                   //join pu in context.ProduitUtilisers on f.Id equals pu.IdProduitClient
                                   select new
                                   {
                                       d.CodeP,
                                       idPC = f.Id,
                                       id = f.Idclient,
                                       idP = f.Idproduit,
                                       d.TypeProduit.Nom,
                                       d.Marque,
                                       d.Model,
                                       count = f.ProduitUtilisers.Count(),
                                       f.Dateaffectation,
                                       userMod = f.Utilisateur1 != null ? f.Utilisateur1.Nom : "aucune",
                                       dateMod = f.Datemodification != null ? f.Datemodification.ToString() : "**-**-****",
                                       f.IsDeleted
                                   }).ToList();
                if (ckDeleteProd.Checked)
                {
                    var ProduitDeleted = listProduit.Where(d => d.IsDeleted == 1).ToList();
                    dgProduit.DataSource = Methods.ToDataTable(ProduitDeleted);
                }
                else
                {
                    var Produit = listProduit.Where(d => d.IsDeleted != 1).ToList();
                    dgProduit.DataSource = Methods.ToDataTable(Produit);
                }
                myGrid();
            }
        }



        public void myGrid()
        {
            Methods.Nice_grid(
                                new string[] { "CodeP", "id", "idP", "Nom", "Adresse", "Marque", "Model", "count", "Dateaffectation" },
                                new string[] { "Code Produit", "id", "idP", "Type", "Marque", "Model", "Totale des emplyees affecter", "Date d'affectation" },
                                dgProduit
                                );
            Methods.FilterDataGridViewIni(dgProduit, txtFind, btnFind);
            dgProduit.Columns["idP"].Visible = false;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            int loc = 331;
            loc += lblEdited.Width;
            lblMod.Location = new Point(loc, 462);
            // MessageBox.Show(clt.Nom.Length.ToString());
            lblEditedDate.Location = new Point(lblMod.Location.X + lblMod.Width, 462);
            lblEdited.Text = "aucune";
            lblEditedDate.Text = "**-**-****";
        }
    }
}
