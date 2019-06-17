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
using ParcInfo.Properties;

namespace ParcInfo.ucFacture
{
    public partial class FactureClient : UserControl
    {
        public FactureClient()
        {
            InitializeComponent();
        }
        Client cli = null;
        int idClient;
        public FactureClient(int idC)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var client = context.Clients.Find(idC);
                cli = client;
                idClient = idC;
                lblClient.Visible = true;
                lblClient.Text = client.IdCLient;
                txtAdr.Text = client.Adresse;
                txtNom.Text = client.Nom;
                txtDebut.Text = client.Debutcontract.Value.ToShortDateString();
                lblYear.Text = DateTime.Now.Year.ToString();
                FactureBoxGen(client);
                GetOldFacture(client, client.Factures.ToList());
            }
        }
        public void GetOldFacture(Client c, List<Facture> fc)
        {
            var listFact = pnlContainer.Controls.OfType<FactureBoxV2>().Where(x => x.Visible);
            foreach (var lf in listFact)
            {
                foreach (var f in fc)
                {
                    var d = int.Parse(GetMonth(f.Mois));
                    var l = int.Parse(lf.LblMonth);
                    if (d == l)
                    {
                        lf.LblMontant = String.Format("{0:0.00}", f.Monatant) ;
                        lf.LblTotalI = GetIntervTotal(c, DateTime.Now.Year, d).ToString();
                        lf.LblTotalP = GetProdTotal(c, DateTime.Now.Year, d).ToString();
                        lf.LblID = f.Id.ToString();
                        lf.BackColor = Color.FromArgb(85, 230, 193);
                        lf.FacConfirm = true;
                        lf.PickInt = Resources.Communicate_48px;
                        lf.PickMonth = Resources.Calendar_52px;
                        lf.PickProduit = Resources.Product_52px;
                    }
                    else if (l == DateTime.Now.Month)
                    {
                        lf.LblTotalI = GetIntervTotal(c, DateTime.Now.Year, DateTime.Now.Month).ToString();
                        lf.LblTotalP = GetProdTotal(c, DateTime.Now.Year, DateTime.Now.Month).ToString();
                    }
                }
            }
        }
        public int GetProdTotal(Client c, int year, int month)
        {


            int dx = c.ProduitClients
                    .Where(d => d.Dateaffectation.Value.Year == year && d.Dateaffectation.Value.Month == month)
                    .Where(d => d.IsDeleted == 0 && d.ParIntervention != null)
                    .ToList().Count();

            return dx;
        }
        public int GetIntervTotal(Client c, int year, int month)
        {
            int? ix = 0;

            int dx = (int)c.Interventions
                    .Where(d => d.DateIntervention.Value.Year == year && d.DateIntervention.Value.Month == month)
                    .Where(d => d.Statut == "terminer")
                    .Sum(d => d.Duree);
            ix = dx > c.Heurecontract ? (dx - c.Heurecontract) : 0;
            return (int)ix;
        }

        public void FactureBoxGen(Client c)
        {
            for (int i = 1; i < 13; i++)
            {
                FactureBoxV2 fac = new FactureBoxV2();
                fac.Name = "Month" + i;
                fac.FacConfirm = false;
                fac.LblMonth = GetMonth(i);
                fac.Click += new EventHandler(Fact_click);
                pnlContainer.Controls.Add(fac);
            }

        }

        private void Fact_click(object sender, EventArgs e)
        {
            var s = (FactureBoxV2)sender;
            //var d = int.Parse(GetMonth(s.LblMonth));
            
            var fm = int.Parse(s.LblID);
           
            if (int.Parse(s.LblID) > 0)
            {
                GlobVars.frmindex.ShowControl(new FactureDetail(idClient,fm));
            }
            else
            {
                GlobVars.frmindex.ShowControl(new FactureDetail(idClient,s.LblMonth,s));

            }

        }



        public string GetMonth(int? n)
        {
            return n <= 9 ? $"0{n}" : $"{n}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var allbtnsvisible = pnlContainer.Controls.OfType<FactureBoxV2>().Where(x => x.Visible);
            //foreach (var item in allbtnsvisible)
            //{
            //    MessageBox.Show(item.Name);
            //}

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                int dx = (int)cli.Interventions
                .Where(d => d.DateIntervention.Value.Year == DateTime.Now.Year && d.DateIntervention.Value.Month == 4)
                .Where(d => d.Statut == "terminer")

                .Sum(d => d.Duree);
                int dxx = cli.ProduitClients
                  .Where(d => d.Dateaffectation.Value.Year == DateTime.Now.Year && d.Dateaffectation.Value.Month == DateTime.Now.Month)
                  .Where(d => d.IsDeleted == 0 && d.ParIntervention != null)
                  .ToList().Count();
                MessageBox.Show(dxx.ToString());
            }
        }

        private void factureBoxV21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Name);
        }
    }
}
