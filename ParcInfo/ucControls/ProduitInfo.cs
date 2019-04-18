using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucControls
{
    public partial class ProduitInfo : UserControl
    {
        int nameProp = 1;
        public ProduitInfo()
        {
            InitializeComponent();
        }

        private void ProduitInfo_Load(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listType = context.TypeProduits.ToList();

                cbType.DataSource = listType;
                cbType.ValueMember = "Id";
                cbType.DisplayMember = "Nom";
            }
            //first lblTexbox to fill user
            //lblProduit prop = new lblProduit();
            //prop.Name = "propC" + nameProp;
            //prop.Margin = new Padding(0, 0, 0, 12);
            //nameProp++;
            //flowLayoutPanel2.Controls.Add(prop);
            //flowLayoutPanel2.Height += 23;

            //if (flowLayoutPanel2.Size == flowLayoutPanel2.MaximumSize)
            //{
            //    flowLayoutPanel2.AutoScroll = true;

            //}
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Clear(pnlProp);
            if (int.TryParse(cbType.SelectedValue.ToString(), out id))
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                    var d = context.TypeProduits.Find(id);

                    foreach (var item in d.ProprietesProduits)
                    {
                        lblProduit prop = new lblProduit();
                        prop.Name = "propC" + nameProp;
                        prop.Margin = new Padding(0, 0, 0, 12);
                        prop.lblName = item.Nom;
                        prop.LblID = item.Id.ToString(); ;
                        nameProp++;
                        pnlProp.Controls.Add(prop);
                        pnlProp.Height += 23;

                        if (pnlProp.Size == pnlProp.MaximumSize)
                        {
                            pnlProp.AutoScroll = true;
                        }
                    }
                }
            }
        }
        public void Clear(Control control)
        {
            var lblDep = (from x in control.Controls.OfType<lblProduit>()
                          select x
                   ).ToList();
            foreach (var item in lblDep)
            {
                control.Controls.Remove(item);
            }

        }
    }
}
