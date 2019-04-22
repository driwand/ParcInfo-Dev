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
    }
}
