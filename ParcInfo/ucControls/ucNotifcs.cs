using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucInterevntion;

namespace ParcInfo.ucControls
{
    public partial class ucNotifcs : UserControl
    {
        public ucNotifcs()
        {
            InitializeComponent();
        }
        public string LblEmp
        {
            get { return lblEmploye.Text; }
            set { lblEmploye.Text = value; }
        }
        public Point LblEmpLocation
        {
            get { return lblEmploye.Location; }
            set { lblEmploye.Location = value; }
        }
        public int lblEmpWidth
        {
            get { return lblEmploye.Width; }
            set { lblEmploye.Width = value; }
        }
        public string LblCli
        {
            get { return lblClient.Text; }
            set { lblClient.Text = value; }
        }
        public Point LblCliLocation
        {
            get { return lblClient.Location; }
            set { lblClient.Location = value; }
        }
        public string LblDate
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }
        public string LblidDem
        {
            get { return lblidDem.Text; }
            set { lblidDem.Text = value; }
        }
        public string LblIDC
        {
            get { return lblIDC.Text; }
            set { lblIDC.Text = value; }
        }
        public string LblDem
        {
            get { return lblIDC.Text; }
            set { lblIDC.Text = value; }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            StartIntervention();
        }
        public void StartIntervention()
        {
            int idClient = int.Parse(LblIDC);
            int idDem = int.Parse(LblidDem);
            GlobVars.frmindex.ShowControl(new NewIntervention(idClient, idDem));
            this.Visible = false;
            this.Parent.Visible = false ;
        }
    }
}
