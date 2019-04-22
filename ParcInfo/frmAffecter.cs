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
        public frmAffecter()
        {
            InitializeComponent();
        }
        public frmAffecter(int idClient, List<int> prod)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (prod.Count > 0 && prod != null)
                {
                    idC = idClient;
                    var listprod = context.Produits.ToList();
                    foreach (var item in prod)
                    {
                        var p = listprod.Where(i => item == i.id).FirstOrDefault();
                        prixVente prop = new prixVente();
                        prop.LblCode = p.CodeP;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<LabelControl> list;
            list = Methods.GetidList(pnlCntrl);
            using (ParcInformatiqueEntities context= new ParcInformatiqueEntities())
            {
                foreach (var item in list)
                {
                    context.ProduitClients.Add(new ProduitClient { Idproduit = item.Id, Idclient = idC, Prixvente = float.Parse(item.Value)});
                }
                context.SaveChanges();
                this.Close();
            }
            
        }
    }
}
