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
using System.Data.Entity;
using System.Data.Entity.SqlServer;

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

                    var ls = (from ir in context.GetInterventionBystatut(lblTotalIntervention)
                             select new {idInter = "INV-" + splitdate(ir.DateIntervention.ToString()) + ir.Id,
                                 ir.Id,
                                 ir.Getstatut,
                                 ir.Debut,
                                 ir.Fin,
                                 ir.Idclient,
                                 ir.IdDemande }).ToList();

                    dgIntervention.DataSource = Methods.ToDataTable(ls);

                    dgIntervention.Columns["id"].Visible = false;
                }
                else
                {
                    var ls = context.GetInterventionBystatut(lblTotalIntervention, statutInterv).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                }
                Methods.Nice_grid(
                    new string[] { "Getstatut", "Debut", "Fin", "Debut", "Debut", "Debut", "Debut", "Debut", "Debut" },
                    new string[] { "Etat", "Debut Intervention", "Debut Intervention", "Debut Intervention", "Debut Intervention", "Debut Intervention", "Debut Intervention", "Debut Intervention", "Debut Intervention" },
                    dgIntervention);

                Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind);
            }
        }

        private void ListeIntervention_Load(object sender, EventArgs e)
        {            

        }
        string splitdate(string dty)
        {
            DateTime dt = DateTime.Parse(dty);
            string r = dt.ToString("dMMyy");
            return r;
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
