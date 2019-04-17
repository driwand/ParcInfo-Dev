using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.Classes;
using ParcInfo.ucControls;

namespace ParcInfo.ucInterevntion
{
    public partial class ListeIntervention : UserControl
    {
        public ListeIntervention()
        {
            InitializeComponent();
        }

        public string statutInterv;
        public int countInterv;
        private void ListeIntervention_Load(object sender, EventArgs e)
        {            
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (countInterv == 0 && statutInterv == "")
                {
                    dgIntervention.DataSource = context.GetInterventionBystatut(lblTotalIntervention); ;
                }
                else
                {
                    dgIntervention.DataSource = context.GetInterventionBystatut(lblTotalIntervention,statutInterv );
                }
            }

        }
       
        private void dgIntervention_DoubleClick(object sender, EventArgs e)
        {
            if (dgIntervention.SelectedRows.Count > -1)
            {
                int index = dgIntervention.CurrentRow.Index;
                
                int sl = int.Parse(dgIntervention.Rows[index].Cells["id"].Value.ToString());
                GlobVars.frmindex.ShowControl(new NewIntervention() { currentInterv = sl});
            }
        }


    }
}
