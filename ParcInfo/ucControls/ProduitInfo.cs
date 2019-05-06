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
        List<TypeProduit> listType;
        Produit prd;
        public ProduitInfo(List<TypeProduit> listT)
        {
            InitializeComponent();
            if (listT != null)
            {
                listType = listT.Where(d=> d.IsDeleted == 0).ToList();
            }
        }
        public ProduitInfo(Produit p,int idPc, List<TypeProduit> listT)
        {
            InitializeComponent();
            if (p != null)
            {
                prd = p;
                listType = listT.Where(d => d.IsDeleted == 0).ToList() ;
                txtMarque.Text = p.Marque;
                txtModel.Text = p.Model;
                txtPrix.Text = p.Prix.ToString();
                txtQte.Value = 1;
                txtQte.Visible = false;
                txtPrix.Enabled = false;
                txtPrix.Enabled = false;
                txtMarque.Enabled = false;
                txtModel.Enabled = false;
                isHardware.Enabled = false;
                DateProduit.Enabled = false;
                cbType.Enabled = false;
                DateProduit.Text = p.Datefabrication.ToString();
                txtModel.Text = p.Model;
               
                if (p.IsHardware == 1)
                {
                    isHardware.Checked = true;
                }
                else
                {
                    isHardware.Checked = false;
                }
             
            }
        }
        public ProduitInfo()
        {
            InitializeComponent();
          
        }
        private void ProduitInfo_Load(object sender, EventArgs e)
        {
            if (listType != null)
            {
                cbType.DataSource = listType;
                cbType.ValueMember = "Id";
                cbType.DisplayMember = "Nom";
            }
            if (prd != null)
            {
                GetValue(pnlProp, prd);
            }
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
                        //prop.Margin = new Padding(0, 0, 0, 12);
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

        // clear lblproduit
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
        // get Propriete Valeur
        public void GetValue(Control pnl, Produit prod)
        {
            var lblDep = (from x in pnl.Controls.OfType<lblProduit>()
                          select x
                            ).ToList();
            foreach (var item in prod.ValeurProps)
            {
                foreach (var lbl in lblDep)
                {
                    if (int.Parse(lbl.LblID) == item.IdPropriete)
                    {
                        lbl.TxtValue = item.Valeur;
                    }
                }
            }
        }
       
        private void txtMarque_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtMarque);

        }

        public void ChangeColor(TextBox txt)
        {
            if (txt.Text.Trim() != "")
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtModel);

        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            ChangeColor(txtPrix);

        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
