using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.Classes;
using ParcInfo.ucControls;

namespace ParcInfo.ucFacture
{
    public partial class FactureDetail : UserControl
    {
        FactureBoxV2 factBox;
        int idClient;
        int MonthF;
        public FactureDetail(int idC, int idFact)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
             
                btnPrint.Location = new Point(763, 450);
                btnPrint.Visible = true;
                btnPrint.BringToFront();
                btnGenerer.Location = new Point(471, 450);
                btnGenerer.Visible = false;
                var c = context.Clients.Find(idC);
                FillTextbox(c);
                var interv = (from cx in c.Interventions
                              where cx.IdFacture == idFact
                              select new
                              {
                                  cx.Id,
                                  cx.IdIntrv,
                                  cx.Duree,
                                  prodCount = cx.ProduitClients.Where(cf => cf.ParIntervention == cx.Id).Count(),
                                  PrixProd = cx.ProduitClients.Where(cf => cf.ParIntervention == cx.Id).Sum(p => p.Prixvente),
                              }).ToList();
                dgFacture.DataSource = interv;

                Methods.Nice_grid(
                new string[] { "Id", "IdIntrv", "Duree", "prodCount", "PrixProd" },
                new string[] { "id", "Id Interventions", "Durée d'intervention", "produit affecté au cours de l'intervention", "Prix total des produits" },
                dgFacture);

                if (dgFacture.Rows.Count > 0)
                {
                    var valeur = 0;
                    float PrixProduitTotal = 0;
                    foreach (DataGridViewRow item in dgFacture.Rows)
                    {
                        float prixInterv = 0;
                        // Calc Total Interv
                        var HerureContract = int.Parse(txtHeureContract.Text);
                        valeur += int.Parse(item.Cells["Duree"].Value.ToString());
                        var HeureInterv = valeur > HerureContract ? (valeur - HerureContract) : 0;
                        txtTotalInterv.Text = (HeureInterv).ToString();
                        prixInterv = HeureInterv * int.Parse(txtHeurePrix.Text);

                        // Calc Produit
                        PrixProduitTotal += int.Parse(item.Cells["PrixProd"].Value.ToString());
                        float PrixContract = float.Parse(txtPrixContract.Text);

                        txtTotalHt.Text = (prixInterv + PrixProduitTotal + PrixContract).ToString();
                        float TotalHT = float.Parse(txtTotalHt.Text);
                        txtTotal.Text = (TotalHT + (TotalHT * 0.2)).ToString();
                    }
                }
                else
                {
                    float PrixContract = float.Parse(txtPrixContract.Text);
                    txtTotalHt.Text = txtPrixContract.Text;
                    float TotalHT = PrixContract;
                    txtTotal.Text = (TotalHT + (TotalHT * 0.2)).ToString();
                }

            }
        }

        public void FillTextbox(Client c)
        {
            
            lblClient.Text = $"[{c.IdCLient}]";
            lblClient.Visible = true;
            lblClient.Text = $"[{c.IdCLient}]";
            lblClient.Visible = true;
            txtNom.Text = c.Nom;
            txtAdr.Text = c.Adresse;
            txtVille.Text = c.Ville;
            txtPrixContract.Text = c.Prixcontrat.ToString();
            txtHeurePrix.Text = c.Prixheur.ToString();
            txtDebut.Text = c.Debutcontract.Value.ToShortDateString();
            txtHeureContract.Text = c.Heurecontract.ToString();
        }
        public FactureDetail(int idC, string month, FactureBoxV2 fb)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var c = context.Clients.Find(idC);
                
                FillTextbox(c);
                btnPrint.Visible = false;

                var mois = int.Parse(month);
                factBox = fb;
                if (mois == DateTime.Now.Month || mois > DateTime.Now.Month)
                {
                    btnGenerer.Visible = false;
                }
                idClient = idC;
                MonthF = mois;
                var interv = (from cx in c.Interventions
                              where cx.DateIntervention.Value.Year == DateTime.Now.Year
                              && cx.Statut == "terminer"
                              && cx.Fin.Value.Month == mois
                              select new
                              {
                                  cx.Id,
                                  cx.IdIntrv,
                                  cx.Duree,
                                  prodCount = cx.ProduitClients.Where(cf => cf.ParIntervention == cx.Id).Count(),
                                  PrixProd = cx.ProduitClients.Where(cf => cf.ParIntervention == cx.Id).Sum(p => p.Prixvente),
                              }).ToList();
                dgFacture.DataSource = interv;

                Methods.Nice_grid(
                new string[] { "Id", "IdIntrv", "Duree", "prodCount", "PrixProd" },
                new string[] { "id", "Id Interventions", "Durée d'intervention", "produit affecté au cours de l'intervention", "Prix total des produits" },
                dgFacture);


                if (dgFacture.Rows.Count > 0)
                {
                    var valeur = 0;
                    float PrixProduitTotal = 0;
                    foreach (DataGridViewRow item in dgFacture.Rows)
                    {
                        float prixInterv = 0;
                        // Calc Total Interv
                        var HerureContract = int.Parse(txtHeureContract.Text);
                        
                        valeur += int.Parse(item.Cells["Duree"].Value.ToString());
                        var HeureInterv = valeur > HerureContract ? (valeur - HerureContract) : 0;
                        txtTotalInterv.Text = (HeureInterv).ToString();
                        prixInterv = HeureInterv * int.Parse(txtHeurePrix.Text);

                        // Calc Produit
                       
                        PrixProduitTotal += int.Parse(item.Cells["PrixProd"].Value.ToString());
                        float PrixContract = float.Parse(txtPrixContract.Text);

                        txtTotalHt.Text = (prixInterv + PrixProduitTotal + PrixContract).ToString();
                        float TotalHT = float.Parse(txtTotalHt.Text);
                        txtTotal.Text = (TotalHT + (TotalHT * 0.2)).ToString();
                    }
                }
                else
                {
                    float PrixContract = float.Parse(txtPrixContract.Text);
                    txtTotalHt.Text = txtPrixContract.Text;
                    float TotalHT = PrixContract;
                    txtTotal.Text = (TotalHT + (TotalHT * 0.2)).ToString();
                }


            }
        }
        public FactureDetail()
        {
            InitializeComponent();
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var MontantV = float.Parse(txtTotal.Text);

                Facture fac = new Facture()
                {
                    IdClient = idClient,
                    Monatant = MontantV,
                    Mois = MonthF,
                    Anne = DateTime.Now.Year
                };
                context.Factures.Add(fac);
                context.SaveChanges();
                factBox.BackColor = Color.FromArgb(85, 230, 193);
                factBox.FacConfirm = true;
            }

        }
    }
}
