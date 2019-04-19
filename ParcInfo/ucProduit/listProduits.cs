using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucControls;
using ParcInfo.Classes;

namespace ParcInfo.ucClient
{
    public partial class listProduits : UserControl
    {
        public listProduits()
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listType = context.Produits.Where(c => c.IsDeleted != 1).ToList();
                var listProduit = (from p in listType
                                   select new { p.CodeP, p.id, p.TypeProduit.Nom, p.Marque, p.Model, p.Prix, p.Datefabrication }).ToList();
                if (listType != null)
                {
                    dgProduits.DataSource = Methods.ToDataTable(listProduit);
                }


                Methods.Nice_grid(
                    new string[] { "CodeP", "id", "Nom", "Marque", "Model", "Prix", "Datefabrication" },
                    new string[] { "Code Produit", "id", "Type", "Marque", "Model", "Prix", "Date de fabrication" },
                    dgProduits
                    );
                Methods.FilterDataGridViewIni(dgProduits, txtFind, btnFind);
                dgProduits.MultiSelect = true;
            }
        }


        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            int txtEmpty = 0;
            txtEmpty = Methods.Focus(produitInfo1);
            if (txtEmpty == 0)
            {
                //get values
                int pType = int.Parse(produitInfo1.cbType.SelectedValue.ToString());
                var pMarq = produitInfo1.txtMarque.Text;
                var pModel = produitInfo1.txtModel.Text;
                var pPrix = produitInfo1.txtPrix.Text;
                DateTime pDate = produitInfo1.DateProduit.Value;
                var pQte = produitInfo1.txtQte.Text;
                int isHardware = 0;
                if (produitInfo1.isHardware.Checked)
                {
                    isHardware = 1;
                }
                //string pcode = $"{pMarq}-{pModel}-{pType}";

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var prod = new Produit
                    {
                        Marque = pMarq.ToUpper(),
                        Model = pModel,
                        Prix = float.Parse(pPrix),
                        Datefabrication = pDate,
                        IsHardware = isHardware,
                        IdType = pType
                    };
                    context.Produits.Add(prod);
                    foreach (Control c in produitInfo1.pnlProp.Controls)
                    {
                        if (c is lblProduit)
                        {
                            lblProduit lb = (lblProduit)c;
                            context.ValeurProps.Add(new ValeurProp { Valeur = lb.TxtValue, IdProduit = prod.id, IdPropriete = pType });
                        }
                    }
                    context.SaveChanges();
                }
            }
        }

        private void dgProduits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int c = dgProduits.SelectedRows.Count;
            if (e.RowIndex >= 0)
            {
                nuAffecter.Value = c;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dgProduits.SelectedRows)
            //{
            //    MessageBox.Show(row.Cells["id"].Value.ToString());
            //}
            var myrow = dgProduits.Rows[dgProduits.CurrentRow.Index];
            MessageBox.Show(myrow.Cells["id"].Value.ToString());
        }

        private void nuAffecter_ValueChanged(object sender, EventArgs e)
        {
            int d = int.Parse(nuAffecter.Value.ToString());
            if (dgProduits.SelectedRows.Count > 0)
            {
                int index = dgProduits.CurrentRow.Index;
                int count = dgProduits.Rows.Count;
                for (int i = index; i < d; i++)
                {
                    if (i < count)
                    {
                        dgProduits.Rows[i].Selected = true;
                    }
                }
            }

        }

           

        private void dgProduits_MultiSelectChanged(object sender, EventArgs e)
        {

           
            
        }

        private void btnAffecter_Click(object sender, EventArgs e)
        {
            List<AffectC> afc = new List<AffectC>();
            foreach (DataGridViewRow row in dgProduits.SelectedRows)
            {
                int idprod = int.Parse(row.Cells["id"].Value.ToString());
                float Prix = int.Parse(row.Cells["Prix"].Value.ToString());
                afc.Add(new AffectC { IdProduit = idprod, Prix = Prix });
            }
            frmselectuser frm = new frmselectuser(true,afc);
            frm.ShowDialog();
        }
    }
}
