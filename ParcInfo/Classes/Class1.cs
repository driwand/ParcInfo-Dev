using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ParcInfo.Classes
{
    class ControlEventWrapper : Control
    {
        private Control control;

        public ControlEventWrapper(Control ctl)
        {
            this.control = ctl;
            this.control.Click += new EventHandler(ControlEventWrapper_Click);
        }
        void ControlEventWrapper_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
