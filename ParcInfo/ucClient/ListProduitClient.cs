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
        public static event EventHandler ProductSelected;
        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler eh = ProductSelected;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public ListProduitClient()
        {
            InitializeComponent();
        }

        private void ListProduitClient_Load(object sender, EventArgs e)
        {
            //ControlsClass.CreateRadiusBorder(this);
            DataTable mydt = new DataTable();
            mydt.Columns.Add("nom");
            mydt.Columns.Add("ville");
            mydt.Rows.Add(new object[] { "dps", "mohammedia" });
            mydt.Rows.Add(new object[] { "dps", "Bernoussi" });
            mydt.Rows.Add(new object[] { "It events", "Kech" });
            mydt.Rows.Add(new object[] { "tececo", "casa" });

            dgProduit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProduit.DataSource = mydt;
            GlobVars.FilterDataGridViewIni(dgProduit, txtFind, btnFind);
            if (!string.IsNullOrEmpty(GlobVars.NomClient))
            {
                txtFind.Location = new Point(140, 19);
                txtFind.Size = new Size(525, 20);
                btnFind.Location = new Point(671, 14);
                btnStartInterv.Visible = true;
                GlobVars.NomClient = "";
            }
            else
            {
                txtFind.Location = new Point(140, 19);
                txtFind.Size = new Size(683, 20);
                btnFind.Location = new Point(829, 14);
                btnStartInterv.Visible = false;
            }
        }

        private void dgProduit_DoubleClick(object sender, EventArgs e)
        {
            OnClicked(e);
        }
    }
}
