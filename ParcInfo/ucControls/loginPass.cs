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
    public partial class loginPass : UserControl
    {
        public string TxtLogin
        {
            get { return txtLogin.Text; }
            set { txtLogin.Text = value; }
        }
        public string TxtPass
        {
            get { return txtPass.Text; }
            set { txtPass.Text = value; }
        }
      
        public loginPass()
        {
            InitializeComponent();
        }


    }
}
