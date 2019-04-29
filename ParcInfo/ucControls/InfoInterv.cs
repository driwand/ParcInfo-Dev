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
    public partial class InfoInterv : UserControl
    {
        public InfoInterv()
        {
            InitializeComponent();
        }


        public string LblID
        {
            get { return lblid.Text; }
            set { lblid.Text = value; }
        }
        public string TxtUser
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }
        public string TxtDateInterv
        {
            get { return txtDateInterv.Text; }
            set { txtDateInterv.Text = value; }
        }
        public string TxtDebut
        {
            get { return txtDebut.Text; }
            set { txtDebut.Text = value; }
        }
        public string TxtFin
        {
            get { return txtDateDeFin.Text; }
            set { txtDateDeFin.Text = value; }
        }
        public string TxtStatut
        {
            get { return txtStatut.Text; }
            set { txtStatut.Text = value; }
        }
        public string TxtType
        {
            get { return txtType.Text; }
            set { txtType.Text = value; }
        }
     
    }
}
