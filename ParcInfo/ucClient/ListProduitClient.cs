using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucClient
{
    public partial class ListProduitClient : UserControl
    {
      
        public ListProduitClient( int idEmploye)
        {
            InitializeComponent();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                if (idEmploye > 0)
                {
                    var listProd = (from c in context.ProduitUtilisers
                                    where c.IdEmployee == idEmploye
                                    join p in context.ProduitClients on c.IdProduitClient equals p.Id
                                    join pr in context.Produits on p.Idproduit equals pr.id
                                    select new { pr.id, pr.CodeProduit, p.Prixvente, c.Login_u, c.Password_u, c.Dateaffectation }).ToList();
                }
              
            }
        }
        public ListProduitClient(int idClient,bool isClient)
        {
            InitializeComponent();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                if (idClient > 0)
                {
                    MessageBox.Show("client");
                }

            }
        }
        private void ListProduitClient_Load(object sender, EventArgs e)
        {
            //ControlsClass.CreateRadiusBorder(this);
            //DataTable mydt = new DataTable();
            //mydt.Columns.Add("nom");
            //mydt.Columns.Add("ville");
            //mydt.Rows.Add(new object[] { "dps", "mohammedia" });
            //mydt.Rows.Add(new object[] { "dps", "Bernoussi" });
            //mydt.Rows.Add(new object[] { "It events", "Kech" });
            //mydt.Rows.Add(new object[] { "tececo", "casa" });

            //dgProduit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgProduit.DataSource = mydt;
            GlobVars.FilterDataGridViewIni(dgProduit, txtFind, btnFind);
            //if (!string.IsNullOrEmpty(GlobVars.NomClient))
            //{
            //    txtFind.Location = new Point(140, 19);
            //    txtFind.Size = new Size(525, 20);
            //    btnFind.Location = new Point(671, 14);
            //    btnStartInterv.Visible = true;
            //    GlobVars.NomClient = "";
            //}
            //else
            //{
            //    txtFind.Location = new Point(140, 19);
            //    txtFind.Size = new Size(683, 20);
            //    btnFind.Location = new Point(829, 14);
            //    btnStartInterv.Visible = false;
            //}
        }

        private void dgProduit_DoubleClick(object sender, EventArgs e)
        {
        
        }
    }
}
