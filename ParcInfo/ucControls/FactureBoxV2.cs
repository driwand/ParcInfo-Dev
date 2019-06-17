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
    public partial class FactureBoxV2 : UserControl
    {

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
        public string LblText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        public string LblMonth
        {
            get { return lblMonth.Text; }
            set { lblMonth.Text = value; }
        }
        public string LblMontant
        {
            get { return lblMontant.Text; }
            set { lblMontant.Text = value; }
        }
        public string LblTotalP
        {
            get { return lblTotalProduit.Text; }
            set { lblTotalProduit.Text = value; }
        }
        public string LblTotalI
        {
            get { return lblTotalInterv.Text; }
            set { lblTotalInterv.Text = value; }
        }
        public string LblID
        {
            get { return lblid.Text; }
            set { lblid.Text = value; }
        }
        public FactureBoxV2()
        {
            InitializeComponent();
            WireAllControls(this);
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }
    }
}
