using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.frmDefault;
using ParcInfo.ucControls;

namespace ParcInfo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            GlobVars.frmLogin = this;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            ControlsClass.CreateRadiusBorder(pnlLogin,14,14);
             ShowControl(new loginCntrl());
        }

        public void ShowControl(Control mycontrol)
        {
            pnlLogin.Controls.Clear();
            pnlLogin.Controls.Add(mycontrol);
            mycontrol.BringToFront();
        
        }
    }
}
