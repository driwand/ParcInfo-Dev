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
    public partial class FactureBox : UserControl
    {
        public FactureBox()
        {
            InitializeComponent();
        }
        public Color PnlContainerColor
        {
            get { return pnlContainer.BackColor; }
            set { pnlContainer.BackColor = value; }
        }
        public bool FacConfirm
        {
            get { return pickChecked.Visible; }
            set { pickChecked.Visible = value; }
        }
        public Image PickMonth
        {
            get { return pickMonth.Image; }
            set { pickMonth.Image = value; }
        }
        public Image PickProduit
        {
            get { return picProduit.Image; }
            set { picProduit.Image = value; }
        }
        public Image PickInt
        {
            get { return pickInt.Image; }
            set { pickInt.Image = value; }
        }
        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
