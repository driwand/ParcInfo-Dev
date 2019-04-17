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
    public partial class txtlblDepartement : UserControl
    {
        public string TxtValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        public string Lblname
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }
        public string Lblid
        {
            get { return lblid.Text; }
            set { lblid.Text = value; }
        }
        public txtlblDepartement()
        {
            InitializeComponent();
        }
    }
}
