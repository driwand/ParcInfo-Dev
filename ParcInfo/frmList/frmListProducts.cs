﻿using ParcInfo.Classes;
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
        public NewIntervention clt;
        public string code;
        public string modele;
        public string type;
        public int idassignedproduct;
        public int idprd;
        public frmListProducts(NewIntervention ctr)
        {
            InitializeComponent();
            clt = ctr;

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listType = context.Produits.Where(c => c.IsDeleted == 0).ToList();
                var listProduitClient = context.ProduitClients.ToList();
                var listProduit = (from p in listType
                                   where !(listProduitClient.Any(it => it.Idproduit == p.id && it.IsDeleted == 0))
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
                code = dgProdcuts.Rows[index].Cells[0].Value.ToString();

                
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    ProduitClient prd = new ProduitClient()
                    {
                        Idclient = clt.selectedClient,
                        Idproduit = Id,
                        ParIntervention = clt.currentInterv
                    };

                    context.ProduitClients.Add(prd);
                    context.SaveChanges();

                    idprd = prd.Id;

                    modele = dgProdcuts.Rows[index].Cells["Model"].Value.ToString();
                    type = dgProdcuts.Rows[index].Cells["Nom"].Value.ToString();

                    string codeid = Id + " " + code + " " + prd.Id; //id selected product, code of selected product and id of assingment in ProduitClient

                    if (rdAffect2.Checked)
                    {
                        frmAffectLogMater rm = new frmAffectLogMater(this, (int)prd.Idclient, prd.Id);
                        rm.Show();
                    }
                    else if (rdAffect1.Checked)
                    {
                        frmAffecter assign = new frmAffecter(prd.Id);
                        assign.Show();
                    }

                    this.Hide();
                    clt.AddDescription(codeid);
                }
            }
        }

        private void frmListProducts_Load(object sender, EventArgs e)
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

        private void Btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
