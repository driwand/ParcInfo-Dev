using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucControls
{
    public partial class ProduitInfo : UserControl
    {
        int nameProp = 1;
        public ProduitInfo()
        {
            InitializeComponent();
        }

        private void ProduitInfo_Load(object sender, EventArgs e)
        {
          // ControlsClass.CreateRadiusBorder(this);
            //first lblTexbox to fill user
            lblProduit prop = new lblProduit();
            prop.Name = "userC" + nameProp;

           
            prop.Margin = new Padding(0, 0, 0, 12);
            nameProp++;

            flowLayoutPanel2.Controls.Add(prop);
            flowLayoutPanel2.Height += 23;

            if (flowLayoutPanel2.Size == flowLayoutPanel2.MaximumSize)
            {
                flowLayoutPanel2.AutoScroll = true;

            }
        }
    }
}
