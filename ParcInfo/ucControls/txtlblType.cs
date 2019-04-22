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


        public static event EventHandler DelType;

        protected virtual void OnClickedDel(EventArgs e)
        {
            EventHandler eh = DelType;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OnClickedDel(e);
        }
    }
}
