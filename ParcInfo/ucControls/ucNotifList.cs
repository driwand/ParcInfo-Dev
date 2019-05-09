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
    public partial class ucNotifList : UserControl
    {
        int notifName = 1;
        public ucNotifList()
        {
            InitializeComponent();
        }
        public ucNotifList(List<Demande> listD)
        {
            InitializeComponent();
            var s = listD.Count();
            var listDem4 = listD.Where(c=> c.IsDeleted == 0).Take(2).ToList();
            foreach (var item in listDem4)
            {
                ucNotifcs ucn = new ucNotifcs();
                ucn.Name = "ucNotif" + notifName;
                ucn.LblCli = $"[{item.Employee.Client.Nom}]";
                ucn.LblEmp = $"{item.Employee.Nom} {item.Employee.Prenom} -";
                ucn.LblDate = item.Datedemande.ToString();
                ucn.LblIDC = item.Employee.Idclient.ToString();
                ucn.LblidDem = item.Id.ToString();
                var loc = ucn.LblEmpLocation.X;
                loc += ucn.lblEmpWidth;
                ucn.LblCliLocation = new Point(loc, ucn.LblEmpLocation.Y);

                pnlList.Controls.Add(ucn);
                ucn.BringToFront();
            }
            var allbtnsvisible = pnlList.Controls.OfType<ucNotifcs>().Where(x => x.Visible);
            if (allbtnsvisible.Count() > 0)
            {
                var pheight = allbtnsvisible.Sum(y => y.Height);
                this.Size = new Size(this.Width, pheight + 29);
            }
        }
       
        private void btnViewMore_Click(object sender, EventArgs e)
        {
            GlobVars.frmindex.ShowControl(new ListDemande("en attente", 0, 0));
            this.Parent.Visible = false;
        }
    }
}
