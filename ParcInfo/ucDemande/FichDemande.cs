using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucControls;

namespace ParcInfo.ucDemande
{
    public partial class FichDemande : UserControl
    {
        int interventionName = 1;
        public FichDemande()
        {
            InitializeComponent();
        }

        private void FichDemande_Load(object sender, EventArgs e)
        {
            infoIntervention infointerv = new infoIntervention();
            infointerv.Name = "Intervention" + interventionName;
            interventionName++;

            flowLayoutPanel1.Controls.Add(infointerv);
        }
    }
}
