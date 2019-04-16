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
    public partial class AffectEmloyee : UserControl
    {
        public static event EventHandler Close;
        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler eh = Close;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public AffectEmloyee()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnClicked(e);
        }
    }
}
