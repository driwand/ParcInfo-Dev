using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.Properties;

namespace ParcInfo.ucControls
{
    public partial class TxtDescription : UserControl
    {
        public TxtDescription()
        {
            InitializeComponent();
        }

        private void TxtDescription_Load(object sender, EventArgs e)
        {
            btnDelProd.FlatAppearance.BorderSize = 0;
            btnDelProd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelProd.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btnDelProd_MouseEnter(object sender, EventArgs e)
        {
            btnDelProd.Image = Resources.redclose;
        }

        private void btnDelProd_MouseLeave(object sender, EventArgs e)
        {
            btnDelProd.Image = Resources.wtclose;
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblIdAffecta.Text.ToString()+ "a "+ lblidobs.Text);
            using (var db = new ParcInformatiqueEntities())
            {
                var affect = db.ProduitClients.Find(Convert.ToInt32(lblIdAffecta.Text)).IsDeleted = 1;
                var obs = db.observations.Find(Convert.ToInt32(lblidobs.Text)).IsDeleted = 1;
                this.Parent.Controls.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
