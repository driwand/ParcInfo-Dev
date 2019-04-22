using ParcInfo.Classes;
using ParcInfo.ucInterevntion;
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
    public partial class frmListProducts : Form
    {
        NewIntervention clt;
        public frmListProducts(NewIntervention ctr)
        {
            InitializeComponent();
            clt = ctr;

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listType = context.Produits.Where(c => c.IsDeleted == 0).ToList();
                var listProduitClient = context.ProduitClients.ToList();
                var listProduit = (from p in listType
                                   where !(listProduitClient.Any(it => it.Idproduit == p.id))
                                   select new { p.CodeP, p.id, p.TypeProduit.Nom, p.Marque, p.Model, p.Prix, p.Datefabrication }).ToList();

                dgProdcuts.DataSource = Methods.ToDataTable(listProduit);

                Methods.Nice_grid(
                    new string[] { "CodeP", "id", "Nom", "Marque", "Model", "Prix", "Datefabrication" },
                    new string[] { "Code Produit", "id", "Type", "Marque", "Model", "Prix", "Date de fabrication" },
                    dgProdcuts
                    );
                Methods.FilterDataGridViewIni(dgProdcuts, txtFind, btnFind);
                dgProdcuts.MultiSelect = true;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (dgProdcuts.SelectedRows.Count > 0)
            {
                int index = dgProdcuts.CurrentRow.Index;
                int Id = Convert.ToInt32(dgProdcuts.Rows[index].Cells["id"].Value);
                string code = dgProdcuts.Rows[index].Cells[0].Value.ToString();
                clt.IdPeoduct = Id;
                clt.CodeProduct = code;
            }
        }
    }
}
