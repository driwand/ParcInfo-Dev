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
using System.Text.RegularExpressions;

namespace ParcInfo.ucClient
{
    public partial class listProduits : UserControl
    {
        ProduitInfo pd;
        public listProduits()
        {
            InitializeComponent();

        }
        private void listProduits_Load(object sender, EventArgs e)
        {
            Methods.CheckRoles(Controls);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                pd = new ProduitInfo(context.TypeProduits.ToList());
                pd.Location = new Point(14, 45);
                this.Controls.Add(pd);
            }
            displayData();
        }
        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int txtEmpty = 0;
                txtEmpty = Methods.Focus(pd);
                // Ajoute Nouveau Produit
                if (int.Parse(pd.lblID.Text) == 0)
                {
                    // check Prix
                    if (pd.txtPrix.Text != "")
                    {
                        if (int.Parse(pd.txtPrix.Text) == 0)
                        {
                            pd.txtPrix.Focus();
                            pd.txtPrix.BackColor = Color.FromArgb(235, 77, 75);
                            MessageBox.Show("Prix Must Be > 0");
                            txtEmpty++;
                        }
                    }
                    if (txtEmpty == 0)
                    {
                        //get values
                        int pType = int.Parse(pd.cbType.SelectedValue.ToString());
                        var pMarq = pd.txtMarque.Text.Trim();
                        var pModel = pd.txtModel.Text.Trim();
                        var pPrix = pd.txtPrix.Text;
                        DateTime pDate = pd.DateProduit.Value;
                        var pQte = pd.txtQte.Value;

                        int isHardware = 0;

                        Produit prod;
                        ValeurProp vp;

                        if (pd.isHardware.Checked)
                        {
                            isHardware = 1;
                        }
                       
                        for (int i = 0; i < pQte; i++)
                        {
                             prod = new Produit
                            {
                                Marque = Methods.RemoveSpace(pMarq.ToUpper()),
                                Model = Methods.RemoveSpace(pModel),
                                Prix = float.Parse(pPrix),
                                Datefabrication = pDate,
                                IsHardware = isHardware,
                                IdType = pType,
                                IsDeleted = 0,
                                Datecreation = DateTime.Now,
                                Creepar = GlobVars.cuUser.Id
                            };
                            context.Produits.Add(prod);
                            context.SaveChanges();
                            var d = prod.id;
                            foreach (Control c in pd.pnlProp.Controls)
                            {
                                if (c is lblProduit)
                                {
                                    lblProduit lb = (lblProduit)c;
                                     vp = new ValeurProp
                                    {
                                        Valeur = Methods.RemoveSpace(lb.TxtValue),
                                        IdProduit = prod.id,
                                        IdPropriete = int.Parse(lb.LblID)
                                    };
                                    //context.ValeurProps.Add(new ValeurProp
                                    //{
                                    //    Valeur = Methods.RemoveSpace(lb.TxtValue.Trim()),
                                    //    IdProduit = prod.id,
                                    //    IdPropriete = int.Parse(lb.LblID)
                                    //});
                                    context.ValeurProps.Add(vp);
                                }
                            }
                        }

                        context.SaveChanges();
                        displayData();
                    }
                }
                // Edit Produit
                else
                {
                    if (txtEmpty == 0)
                    {
                        int idProd = int.Parse(pd.lblID.Text);
                        var p = context.Produits.Find(idProd);
                        p.IdType = int.Parse(pd.cbType.SelectedValue.ToString());
                        p.Marque = Methods.RemoveSpace(pd.txtMarque.Text);
                        p.Model = Methods.RemoveSpace(pd.txtModel.Text);
                        p.Prix = float.Parse(pd.txtPrix.Text);
                        p.Datefabrication = pd.DateProduit.Value;
                        p.Modifierpar = GlobVars.cuUser.Id;
                        p.Datemodification = DateTime.Now;
                        var lblDep = (from x in pd.pnlProp.Controls.OfType<lblProduit>()
                                      select x
                             ).ToList();

                        foreach (var item in p.ValeurProps)
                        {
                            foreach (var lb in lblDep)
                            {
                                if (item.IdPropriete == int.Parse(lb.LblID))
                                {
                                    item.Valeur = lb.TxtValue;
                                }
                            }
                        }
                        context.SaveChanges();
                        displayData();
                    }

                }
            }
        }

        private void dgProduits_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int c = dgProduits.SelectedRows.Count;
        
            if (e.RowIndex > -1)
            {
                if (c > 0)
                {
                    nuAffecter.Value = c;
                }
                ShowInfo(e.RowIndex);
                var myrow = dgProduits.Rows[e.RowIndex];
                string nomUser = myrow.Cells["userMod"].Value.ToString();
                string date = myrow.Cells["dateMod"].Value.ToString();
                int isDeleted = int.Parse(myrow.Cells["isDeleted"].Value.ToString());
                if (isDeleted == 1)
                {
                    btnDelP.Visible = false;
                    btnNewType.Location = new Point(354, 435);
                    btnAddProduct.Visible = false;
                }
                else
                {
                    btnDelP.Visible = true;
                    btnNewType.Location = new Point(240, 435);
                    btnAddProduct.Visible = true;
                }
                int loc = 522;
                lblUser.Text = nomUser;
                loc += lblUser.Width;
                lblM.Location = new Point(loc, 454);
                lblDateMod.Text = date;
                lblDateMod.Location = new Point(lblM.Location.X + lblM.Width, 454);
            }
        }

        private void nuAffecter_ValueChanged(object sender, EventArgs e)
        {
            int d = int.Parse(nuAffecter.Value.ToString());
            if (dgProduits.SelectedRows.Count > 0)
            {
                int index = dgProduits.CurrentRow.Index;
                int count = dgProduits.Rows.Count;
                for (int i = index; i < d + index; i++)
                {
                    if (i < count)
                    {
                        dgProduits.Rows[i].Selected = true;
                    }
                }
            }
            nuAffecter.Maximum = dgProduits.Rows.Count;
        
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
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                //dgClients.DataSource = vr;

                if (cbDelete.Checked)
                {
                    displayData(1);
                    if (dgProduits.Rows.Count > 0)
                    {
                        dgProduits.Rows[0].Selected = true;
                    }
                }
                else
                {
                    displayData();
                    if (dgProduits.Rows.Count > 0)
                    {
                        dgProduits.Rows[0].Selected = true;
                    }

                }
            }
        }

        private void btnDelP_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int idProd = int.Parse(pd.lblID.Text);
                Produit c = context.Produits.Find(idProd);

                DialogResult result = MessageBox.Show("Voulez-vous supprimer le produit suivant ?", "confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    c.IsDeleted = 1;
                    c.Datemodification = DateTime.Now;
                    c.Modifierpar = GlobVars.cuUser.Id;
                    context.SaveChanges();
                    MessageBox.Show("produit supprimé");
                    Clear();
                    //   dgProduits.ClearSelection();

                    displayData();
                    if (dgProduits.Rows.Count > 0)
                    {
                        dgProduits.Rows[0].Selected = true;
                    }
                }
                else if (result == DialogResult.No)
                {

                }


            }
        }

        /// Methoods
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
                                       dateMod = p.Datemodification != null ? p.Datemodification.ToString() : "**-**-****",
                                   }).ToList();
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
        public void Clear()
        {
            pd.cbType.SelectedItem = 0;
            pd.txtMarque.Text = "";
            pd.txtModel.Text = "";
            pd.txtQte.Value = 1;
            pd.txtPrix.Text = "";
            pd.txtQte.Visible = true;
            pd.lblQte.Visible = true;
            pd.lblID.Text = "0";
            btnDelP.Visible = false;
            pd.isHardware.Checked = false;
            var lblProduit = (from x in pd.pnlProp.Controls.OfType<lblProduit>()
                              select x
                      ).ToList();

            foreach (var item in lblProduit)
            {
                item.TxtValue = "";
                // item.LblID = "0";
            }
        }
        public void ShowInfo(int index)
        {

            var myrow = dgProduits.Rows[index];
            int id = int.Parse(myrow.Cells["id"].Value.ToString());
            btnDelP.Visible = true;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var p = context.Produits.Find(id);
                if (p != null)
                {
                    pd.cbType.SelectedValue = p.IdType;
                    pd.txtMarque.Text = p.Marque;
                    pd.txtModel.Text = p.Model;
                    pd.txtPrix.Text = p.Prix.ToString();
                    pd.DateProduit.Text = p.Datefabrication.ToString();
                    pd.lblID.Text = p.id.ToString();
                    pd.txtQte.Visible = false;
                    pd.lblQte.Visible = false;
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
   

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (dgProduits.Rows.Count == 0)
            {
                Clear();
            }
        }


    }
}
