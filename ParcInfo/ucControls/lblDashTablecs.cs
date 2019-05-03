using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucDemande;
using ParcInfo.ucInterevntion;

namespace ParcInfo.ucControls
{
    public partial class lblDashTablecs : UserControl
    {
        public lblDashTablecs()
        {
            InitializeComponent();
        }
        public string LblDate
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }
        public string LblID
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }
        public string LblClient
        {
            get { return lblClient.Text; }
            set { lblClient.Text = value; }
        }
        public string LblStatut
        {
            get { return lblStatut.Text; }
            set { lblStatut.Text = value; }
        }
        public string ID
        {
            get { return id.Text; }
            set { id.Text = value; }
        }

        public Color lblStatutColor
        {
            get { return lblStatut.ForeColor; }
            set { lblStatut.ForeColor = value; }
        }

        private void lblID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (this.Name == "dem")
                {
                    GlobVars.frmindex.ShowControl(new FicheDemande1(int.Parse(ID)));
                }
                else
                {
                    GlobVars.frmindex.ShowControl(new NewIntervention(0,0, int.Parse(ID), 0));
                }
            }
        }
    }
}
