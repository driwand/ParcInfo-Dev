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
        /// <summary>
        /// Event to indicate UserControl Button Clicked
        /// </summary>
        public static event EventHandler ClickedAdd;
        public static event EventHandler ClickedDell;
        /// <summary>
        /// Called to signal to subscribers that UserControl Button Clicked
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler eh = ClickedAdd;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        protected virtual void OnClickedDel(EventArgs e)
        {
            EventHandler eh = ClickedDell;
            if (eh != null)
            {
                eh(this, e);
            }
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
            Parent.Controls.Remove(this);
        }
    }
}
