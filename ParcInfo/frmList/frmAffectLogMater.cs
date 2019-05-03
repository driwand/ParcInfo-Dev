using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.frmList
{
    public partial class frmAffectLogMater : Form
    {
        frmListProducts pubfrm;
        int idpr;
        public frmAffectLogMater(frmListProducts frm,int idcli,int idprod)
        {
            InitializeComponent();

            lblmodel.Text = frm.modele;
            lblproduct.Text = frm.code;
            lbltype.Text = frm.type;

            idpr = idprod;
            pubfrm = frm;

            using (var db = new ParcInformatiqueEntities())
            {
                var listType = db.Produits.Where(c => c.IsDeleted == 0).ToList();
                var listProduitClient = db.ProduitClients.Where(c => c.Idclient == idcli).ToList();
                var listProduit = (from p in listProduitClient
                                   select new {Idpclient = p.Id, p.Produit.CodeP, p.Produit.id, p.Produit.TypeProduit.Nom, p.Produit.Marque, p.Produit.Model, p.Produit.Prix, p.Produit.Datefabrication }).ToList();
                dgProdcuts.DataSource = Methods.ToDataTable(listProduit);

                Methods.Nice_grid(
                    new string[] { "CodeP", "id", "Nom", "Marque", "Model", "Prix", "Datefabrication" },
                    new string[] { "Code Produit", "id", "Type", "Marque", "Model", "Prix", "Date de fabrication" },
                    dgProdcuts
                    );
                dgProdcuts.Columns["Idpclient"].Visible = false;
                Methods.FilterDataGridViewIni(dgProdcuts, txtFind, btnFind);
            }
        }

        private void frmAffectLogMater_Load(object sender, EventArgs e)
        {
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
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                if (dgProdcuts.SelectedRows.Count > 0)
                {
                    
                    Installer inst = new Installer
                    {
                        Idhardsoft = idpr,
                        Idproduitclient = (int)dgProdcuts.Rows[dgProdcuts.CurrentRow.Index].Cells["Idpclient"].Value,
                        Creepar = GlobVars.cuUser.Id
                    };
                    db.Installers.Add(inst);
                    db.SaveChanges();

                    frmAffecter assign = new frmAffecter(idpr);
                    assign.Show();
                }
            }
        }
    }
}
