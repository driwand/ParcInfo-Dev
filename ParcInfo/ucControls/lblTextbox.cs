using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucClient;

namespace ParcInfo.ucControls
{
    
    public partial class lblTextbox : UserControl
    {

        public string LblText
        {
            get { return lbl.Text; }
            set { lbl.Text = value; }
        }

        public string TxtValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        public string Lblid
        {
            get { return lblid.Text; }
            set { lblid.Text = value; }
        }
        public string LblAff
        {
            get { return lblAff.Text; }
            set { lblAff.Text = value; }
        }
        public lblTextbox()
        {
            InitializeComponent();
        }


        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            frmselectuser frm = new frmselectuser(this);
            frm.ShowDialog();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
