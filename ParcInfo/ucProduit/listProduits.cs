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
        ProduitInfo pd;
        public listProduits()
        {

            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listType = context.Produits.Where(c => c.IsDeleted == 0).ToList();
                var listProduitClient = context.ProduitClients.ToList();
                var listProduit = (from p in listType
                                   where !(listProduitClient.Any(it => it.Idproduit == p.id))
                                   select new { p.CodeP, p.id, p.TypeProduit.Nom, p.Marque, p.Model, p.Prix, p.Datefabrication }).ToList();

                    dgProduits.DataSource = Methods.ToDataTable(listProduit);

                Methods.Nice_grid(
                    new string[] { "CodeP", "id", "Nom", "Marque", "Model", "Prix", "Datefabrication" },
                    new string[] { "Code Produit", "id", "Type", "Marque", "Model", "Prix", "Date de fabrication" },
                    dgProduits
                    );
                Methods.FilterDataGridViewIni(dgProduits, txtFind, btnFind);
                dgProduits.MultiSelect = true;
            }
        }
        private void listProduits_Load(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                pd = new ProduitInfo(context.TypeProduits.ToList());
                pd.Location = new Point(18, 50);
                this.Controls.Add(pd);
            }
        }
        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            int txtEmpty = 0;
            txtEmpty = Methods.Focus(pd);
            if (txtEmpty == 0)
            {
                //get values
                int pType = int.Parse(pd.cbType.SelectedValue.ToString());
                var pMarq = pd.txtMarque.Text;
                var pModel = pd.txtModel.Text;
                var pPrix = pd.txtPrix.Text;
                DateTime pDate = pd.DateProduit.Value;
                var pQte = pd.txtQte.Value;
                int isHardware = 0;
                if (pd.isHardware.Checked)
                {
                    isHardware = 1;
                }
                //string pcode = $"{pMarq}-{pModel}-{pType}";

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                   
                    
                   
                        Produit prod = new Produit
                        {
                            Marque = pMarq.ToUpper(),
                            Model = pModel,
                            Prix = float.Parse(pPrix),
                            Datefabrication = pDate,
                            IsHardware = isHardware,
                            IdType = pType,
                            IsDeleted = 0

                        };
                        context.Produits.Add(prod);
                   
                    
                    foreach (Control c in pd.pnlProp.Controls)
                    {
                        if (c is lblProduit)
                        {
                            lblProduit lb = (lblProduit)c;
                            context.ValeurProps.Add(new ValeurProp { Valeur = lb.TxtValue, IdProduit = prod.id, IdPropriete = int.Parse(lb.LblID) });
                        }
                    }
                    context.SaveChanges();
                }
            }
        }

        private void dgProduits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int c = dgProduits.SelectedRows.Count;
            if (c> 0)
            {
                nuAffecter.Value = c;

                var myrow = dgProduits.Rows[e.RowIndex];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());


                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var p = context.Produits.Find(id);
                    if (p != null)
                    {
                        pd.txtMarque.Text = p.Marque;
                        pd.txtModel.Text = p.Model;
                        pd.txtPrix.Text = p.Prix.ToString();
                        pd.DateProduit.Text = p.Datefabrication.ToString();
                        if (p.IsHardware == 1)
                        {
                            pd.isHardware.Checked = true;
                        }
                        else
                        {
                            pd.isHardware.Checked = false;

                        }
                        GetValue(pd.pnlProp, p);
                    }
                }
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

            List<int> listAff = new List<int>();

            foreach (DataGridViewRow row in dgProduits.SelectedRows)
            {
                int idprod = int.Parse(row.Cells["id"].Value.ToString());
                listAff.Add(idprod);
            }
            
            frmselectuser frm = new frmselectuser(listAff);
            frm.ShowDialog();



            //List<AffectC> afc = new List<AffectC>();
            //foreach (DataGridViewRow row in dgProduits.SelectedRows)
            //{
            //    int idprod = int.Parse(row.Cells["id"].Value.ToString());
            //    float Prix = int.Parse(row.Cells["Prix"].Value.ToString());
            //    afc.Add(new AffectC { IdProduit = idprod, Prix = Prix });
            //}
            //frmselectuser frm = new frmselectuser(true,afc);
            //frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pd);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                pd = new ProduitInfo(context.TypeProduits.ToList());
                pd.Location = new Point(18, 50);
                this.Controls.Add(pd);
            }
        
        }
    }
}
