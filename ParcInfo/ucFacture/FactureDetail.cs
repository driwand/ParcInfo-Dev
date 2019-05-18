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
using ParcInfo.frmList;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ExportOptions = CrystalDecisions.Shared.ExportOptions;

namespace ParcInfo.ucFacture
{
    public partial class FactureDetail : UserControl
    {
        FactureBoxV2 factBox;
        int idClient;
        int MonthF;
        string idFacture;
        int RealID;
        string Tel;
        public FactureDetail(int idC, int idFact)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var facture = context.Factures.Find(idFact);
                idFacture = $"{facture.Anne}{GetMonth(facture.Mois)}{facture.Id}";
                RealID = idFact;
                btnPrint.Location = new Point(763, 450);
                btnPrint.Visible = true;
                btnPrint.BringToFront();
                btnGenerer.Location = new Point(471, 450);
                btnGenerer.Visible = false;
                var c = context.Clients.Find(idC);
                FillTextbox(c);
                idClient = idC;
                Tel = c.Tel;
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

                       // txtTotalHt.Text = String.Format("{0:0.0#}", (prixInterv + PrixProduitTotal + PrixContract).ToString());
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
        public string GetMonth(int? n)
        {
            return n <= 9 ? $"0{n}" : $"{n}";
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
                var interv = (from cx in context.Interventions
                              where cx.Idclient == fac.IdClient
                              where cx.DateIntervention.Value.Year == fac.Anne
                              && cx.Statut == "terminer"
                              && cx.Fin.Value.Month == fac.Mois
                              select cx);
                interv.ToList().ForEach(ex =>
                {
                    ex.IdFacture = fac.Id;
                });
                context.SaveChanges();
                factBox.BackColor = Color.FromArgb(85, 230, 193);
                factBox.FacConfirm = true;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //fm f = new fm();

            //crptFacture crp = new crptFacture();
            //TextObject txtName = (TextObject)crp.ReportDefinition.Sections["Section2"].ReportObjects["txtName"];
            //txtName.Text = txtNom.Text;
            //crp.Refresh();
            //f.crystalReportViewer1.ReportSource = crp;
            //f.Show();

            ReportDocument rdReport = new ReportDocument();
            rdReport.Load( @"I:\Project Stage\n\ParcInfo-Dev\ParcInfo\frmList\CrystalFacture.rpt");


            DataTable dt = new DataTable();
            dt.Columns.Add("NomClient",typeof(string));
            dt.Columns.Add("Adresse", typeof(string));
            dt.Columns.Add("Ville", typeof(string));
            dt.Columns.Add("FactureID", typeof(string));
            dt.Columns.Add("TotalHT", typeof(string));
            dt.Columns.Add("TotalMontant", typeof(string));
            dt.Columns.Add("Tel", typeof(string));
            
            dt.Rows.Add(txtNom.Text, txtAdr.Text, txtVille.Text, idFacture, txtTotalHt.Text,txtTotal.Text,Tel);

            rdReport.Database.Tables["FactureInfo"].SetDataSource(dt);
            dt = new DataTable();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var c = context.Clients.Find(idClient);
                var interv = (from cx in c.Interventions
                              where cx.IdFacture == RealID
                              select new
                              {
                                  IdIntrv = cx.IdIntervINT,
                                  cx.Duree,
                                  prodCount = cx.ProduitClients.Where(cf => cf.ParIntervention == cx.Id).Count(),
                                  PrixProd = cx.ProduitClients.Where(cf => cf.ParIntervention == cx.Id).Sum(p => p.Prixvente),
                              }).ToList();
                dt = Methods.ToDataTable(interv);
                rdReport.Database.Tables["intervInfo"].SetDataSource(dt);

            }



            //rdReport.SetParameterValue("ClientID",idClient.ToString());
            //rdReport.SetParameterValue("FactureN", idFacture);
            //rdReport.SetParameterValue("idFacture", RealID);


            ExportOptions exportOption;
            DiskFileDestinationOptions diskFileDestination = new DiskFileDestinationOptions();

            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Pdf Files |*.pdf";
            sfd.FileName = $"FACTURE N° FA{idFacture}";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                diskFileDestination.DiskFileName = sfd.FileName ;
            }
            exportOption = rdReport.ExportOptions;
            {
                exportOption.ExportDestinationType = ExportDestinationType.DiskFile;
                exportOption.ExportFormatType = ExportFormatType.PortableDocFormat;
                exportOption.DestinationOptions = diskFileDestination;
                exportOption.ExportFormatOptions = new PdfRtfWordFormatOptions();
                

            }
            rdReport.Export();

        }
    }
}
