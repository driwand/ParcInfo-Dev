using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.frmList
{
    public partial class frmAffectLogMater : Form
    {
        public frmAffectLogMater(frmListProducts frm)
        {
            InitializeComponent();

            using (var db = new ParcInformatiqueEntities())
            {
                var prdClient = (from p in db.ProduitClients
                                where p.IsDeleted == 0
                                select new { p.CodeProduit, p.Dateaffectation, p.Produit.TypeProduit }).ToList();
                Methods.ToDataTable(prdClient);
                Methods.FilterDataGridViewIni(dgProdcuts, txtFind, btnFind);
            }
        }

        private void frmAffectLogMater_Load(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {

        }
    }
}
