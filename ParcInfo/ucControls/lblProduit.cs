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
    public partial class lblProduit : UserControl
    {
        public lblProduit()
        {
            InitializeComponent();
        }

        public string TxtValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }
         public string lblName
        {
            get { return lblname.Text; }
            set { lblname.Text = value; }
        }
        public string LblID
        {
            get { return lblid.Text; }
            set { lblid.Text = value; }
        }
    }
}
