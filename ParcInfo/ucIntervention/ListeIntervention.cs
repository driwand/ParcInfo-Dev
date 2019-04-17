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
        public ListeIntervention(string statutInterv,int countInterv)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (countInterv == 0 && statutInterv == "")
                {
                    var ls = from ir in context.GetInterventionBystatut(lblTotalIntervention).ToList()
                             select new { ir.Id, ir.DateIntervention, ir.Debut, ir.Fin, ir.Idclient, ir.IdDemande };
                    dgIntervention.DataSource = Methods.ToDataTable(ls.ToList());
                    dgIntervention.Columns["id"].Visible = false;
                }
                else
                {
                    var ls = context.GetInterventionBystatut(lblTotalIntervention, statutInterv).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                }
                ControlsClass.Nice_grid(new string[] { "DateIntervention" }, new string[] { "Date Intervention" },dgIntervention);
                Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind);
            }
        }

        private void ListeIntervention_Load(object sender, EventArgs e)
        {            

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

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
