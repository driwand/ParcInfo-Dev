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
                var listType = (from c in context.Produits
                                select new { c.id, c.CodeProduit, c.TypeProduit.Nom, c.Marque, c.Model, c.Prix }).ToList();
                dgProduits.DataSource = Methods.ToDataTable(listType);
               
                Methods.Nice_grid(
                    new string[] { "id", "CodeProduit", "Nom", "Marque", "Model", "Prix" },
                    new string[] { "id", "Code Produit", "Type", "Marque", "Model", "Prix" },
                    dgProduits
                    );
                Methods.FilterDataGridViewIni(dgProduits, txtFind, btnFind);
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
                string pcode = $"{pMarq}-{pModel}-{pType}";

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {

                    var prod = new Produit
                    {
                        CodeProduit = pcode,
                        Marque = pMarq,
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

        }
    }
}
