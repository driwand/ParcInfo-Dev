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
    public partial class txtlblType : UserControl
    {
      
        public string TxtValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }
        public string LblID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        public txtlblType()
        {
            InitializeComponent();
        }
   



        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtValue_Enter(object sender, EventArgs e)
        {

        }

        private void txtValue_Leave(object sender, EventArgs e)
        {
         
           
        }
    }
}
