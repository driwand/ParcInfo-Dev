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

namespace ParcInfo.ucFacture
{
    public partial class ListFacture : UserControl
    {
        public ListFacture()
        {
            InitializeComponent();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listFact = context.Factures.ToList();
                var fac = (from f in listFact
                           select new
                           {
                               f.Id,
                               idC = f.Client.id,
                               f.IdFacture,
                               f.Client.Nom,
                               f.Anne,
                               f.Mois,
                               f.Monatant
                           }).ToList();



                dgFacture.DataSource = Methods.ToDataTable(fac);

                Methods.Nice_grid(
                               new string[] { "Id", "IdFacture", "Nom", "Anne", "Mois", "Monatant" },
                               new string[] { "id", "Numero facture", "Client nom", "année", "Mois","Total"},
                               dgFacture
                               );
                //        dgProduit.Columns["idP"].Visible = false;
                Methods.FilterDataGridViewIni(dgFacture, txtFind, btnFind);
            }
        }

        private void dgFacture_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacture.Rows.Count > 0)
            {

                var myrow = dgFacture.Rows[dgFacture.CurrentRow.Index];
                int idF = int.Parse(myrow.Cells["Id"].Value.ToString());
                int idC = int.Parse(myrow.Cells["idC"].Value.ToString());

                GlobVars.frmindex.ShowControl(new FactureDetail(idC, idF));
            }
        }
    }
}
