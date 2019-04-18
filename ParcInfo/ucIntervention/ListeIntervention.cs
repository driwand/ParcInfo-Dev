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
                             select new {
                                 ir.IdIntrv,
                                 ir.Id,
                                 ir.Debut,
                                 ir.Fin,
                                 ir.Idclient,
                                 ir.IdDemande,
                                 ir.Getstatut
                             }).ToList();

                    dgIntervention.DataSource = Methods.ToDataTable(ls);

                    
                }
                else
                {
                    var ls = ( from ir in context.GetInterventionBystatut(lblTotalIntervention, statutInterv)
                               select new {
                                   ir.IdIntrv,
                                   ir.Id,
                                   ir.Debut,
                                   ir.Fin,
                                   ir.Idclient,
                                   ir.IdDemande,
                                   ir.Getstatut
                               }).ToList();
                    dgIntervention.DataSource = Methods.ToDataTable(ls);
                }
                dgIntervention.Columns["id"].Visible = false;
                Methods.Nice_grid(
                    new string[] { "IdIntrv", "Debut", "Fin", "Idclient", "IdDemande","Getstatut"},
                    new string[] { "ID Intervention", "Debut Intervention", "Fin Intervention", "Client", "Demande", "Statut" },
                    dgIntervention);

                Methods.FilterDataGridViewIni(dgIntervention, txtFind, btnFind);
            }
        }


        private void dgIntervention_DoubleClick(object sender, EventArgs e)
        {
            if (dgIntervention.SelectedRows.Count > -1)
            {
                int index = dgIntervention.CurrentRow.Index;
                
                int selectedInt = int.Parse(dgIntervention.Rows[index].Cells["id"].Value.ToString());
                
                if (dgIntervention.Rows[index].Cells["IdDemande"].Value.ToString() != "")
                {
                    GlobVars.frmindex.ShowControl(
                        new NewIntervention(
                            0,
                            0, 
                            selectedInt, 
                            int.Parse(dgIntervention.Rows[index].Cells["IdDemande"].Value.ToString()))
                            );
                }
                GlobVars.frmindex.ShowControl(
                    new NewIntervention(
                        0,
                        0, 
                        selectedInt, 
                        int.Parse(dgIntervention.Rows[index].Cells["IdClient"].Value.ToString()))
                        );
            }
        }

    }
}
