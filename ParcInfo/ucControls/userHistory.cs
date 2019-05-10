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
    public partial class userHistory : UserControl
    {
        public userHistory()
        {
            InitializeComponent();
        }
        public string LblActiv
        {
            get { return lblVarchar.Text; }
            set { lblVarchar.Text = value; }
        }
        public Color LeftColor
        {
            get { return leftLine.BackColor; }
            set { leftLine.BackColor = value; }
        }
        private void userHistory_Load(object sender, EventArgs e)
        {
       

        }
    }
}
