using ParcInfo.Classes;
using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    
    public partial class frmAffecter : Form
    {
        int prixName = 1;

        int idC;

        lblTextbox lblx;
        loginPass lg;
        int idprd = 0;
        
        public frmAffecter()
        {
            InitializeComponent();
        }
        public frmAffecter(lblTextbox tbx, int id)
        {
            InitializeComponent();
            lblx = tbx;
             lg = new loginPass();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
               var e= context.Employees.Find(id);
                this.Text = $"{e.Nom} {e.Prenom}";
                this.Size = new Size(385, 180);
                btnSave.Location = new Point(239, 105);
                pnlCntrl.Size = new Size(344, 81);
                //   prop.Margin = new Padding(0, 0, 0, 12);
                prixName++;
                pnlCntrl.Controls.Add(lg);
            }
         
        }
        DataGridView dggrid;
        public frmAffecter(int idClient, List<int> prod,DataGridView dg)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (prod.Count > 0 && prod != null)
                {
                    dggrid = dg;
                    idC = idClient;
                    var listprod = context.Produits.ToList();
                    foreach (var item in prod)
                    {
                        this.Text = "produit";
                        var p = listprod.Where(i => item == i.id).FirstOrDefault();
                        prixVente prop = new prixVente();
                        prop.TxtValue = p.Prix.ToString();
                        prop.LblCode = $"{p.Marque} {p.Model}";
                      
                        prop.Lblid = item.ToString();
                        // prop.Margin = new Padding(0, 0, 0, 12);
                        prixName++;
                        pnlCntrl.Controls.Add(prop);
                        pnlCntrl.Height += 23;

                        if (pnlCntrl.Size == pnlCntrl.MaximumSize)
                        {
                            pnlCntrl.AutoScroll = true;
                        }
                    }
                }
            }
        }
        public frmAffecter(int Idproduct)
        {
            InitializeComponent();
            using (var context = new ParcInformatiqueEntities())
            {
                var prodinfo = context.ProduitClients.Find(Idproduct);
                prixVente prop = new prixVente();
                prop.LblCode = prodinfo.CodeProduit;
                prop.Lblid = Idproduct.ToString();
                prop.Name = "txtproductid";
                pnlCntrl.Controls.Add(prop);

                prixVente tx = pnlCntrl.Controls.Find("txtproductid", true).FirstOrDefault() as prixVente;
                tx.TxtValue = prodinfo.Produit.Prix.ToString();
                idprd = Idproduct;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lg != null)
            {
                if (lg.TxtLogin != "" && lg.TxtPass != "")
                {
                    lblx.LblUser = lg.TxtLogin;
                    lblx.LblPass = lg.TxtPass;
                    this.Close();
                }
                else
                {
                    lg.Focus();
                }
            
            }else if(idprd > 0){
                using (var context = new ParcInformatiqueEntities())
                {
                    var produicli = context.ProduitClients.Find(idprd);
                    prixVente tx = pnlCntrl.Controls.Find("txtproductid", true).FirstOrDefault() as prixVente;
                    produicli.Prixvente = float.Parse(tx.TxtValue);
                    context.SaveChanges();
                }
            }
            else
            {
                List<LabelControl> list;
                list = Methods.GetidList(pnlCntrl);
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var c = context.Clients.Find(idC);
                    foreach (var item in list)
                    {
                         ProduitClient prod = new ProduitClient()
                        {
                            Idproduit = item.Id,
                            Idclient = idC,
                            Prixvente = float.Parse(item.Value),
                            Dateaffectation = DateTime.Now,
                            Creepar = GlobVars.cuUser.Id,
                            IsDeleted = 0
                        };
                        context.ProduitClients.Add(prod);
                        var p = context.Produits.Find(item.Id);
                      
                        context.UserActivities.Add(new UserActivity
                        {
                            Iduser = GlobVars.cuUser.Id,
                            Activity = $"Le Produit [{p.CodeP}] a été affecté au Client [{c.IdCLient}] Le [{DateTime.Now}]"
                        });
                    }

                    context.SaveChanges();
                    this.Close();
                    if (dggrid != null)
                    {
                        displayData();
                    }
                }
            }
            this.Close();
        }

        public void displayData(int deleted = 0)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listType = context.Produits.Where(c => c.IsDeleted == deleted).ToList();
                var listProduitClient = context.ProduitClients.ToList();
                var listProduit = (from p in listType
                                   where !(listProduitClient.Any(it => it.Idproduit == p.id && it.IsDeleted == 0))
                                   select new
                                   {
                                       p.CodeP,
                                       p.id,
                                       p.TypeProduit.Nom,
                                       p.Marque,
                                       p.Model,
                                       p.Prix,
                                       p.Datefabrication,
                                       p.IsDeleted,
                                       userMod = p.Utilisateur1 != null ? p.Utilisateur1.Nom : "aucune",
                                       userID = p.Utilisateur1 != null ? p.Utilisateur1.Id : 0,
                                       dateMod = p.Datemodification != null ? p.Datemodification.ToString() : "**-**-****",
                                   }).ToList();
                dggrid.DataSource = Methods.ToDataTable(listProduit);

                Methods.Nice_grid(
                    new string[] { "CodeP", "id", "Nom", "Marque", "Model", "Prix", "Datefabrication" },
                    new string[] { "Code Produit", "id", "Type", "Marque", "Model", "Prix", "Date de fabrication" },
                    dggrid
                    );
                if (dggrid.Rows.Count > 0)
                {
                    dggrid.Rows[0].Selected = true;
                }

            }
        }
        private void frmAffecter_Load(object sender, EventArgs e)
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
    }
}
