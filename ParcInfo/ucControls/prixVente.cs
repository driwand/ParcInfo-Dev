using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ParcInfo.ucControls
{
    public partial class prixVente : UserControl
    {


        public string TxtValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }
        public string LblCode
        {
            get { return lblCode.Text; }
            set { lblCode.Text = value; }
        }
        public string Lblid
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
        public prixVente()
        {
            InitializeComponent();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
