using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.ucParametre
{
    public partial class ListUtilisateur : UserControl
    {
        public ListUtilisateur()
        {
            InitializeComponent();
        }
        //get id of selected 'utilisateur'
    

        private void ListUtilisateur_Load(object sender, EventArgs e)
        {
           // ControlsClass.CreateRadiusBorder(this);
            DataTable mydt = new DataTable();
            mydt.Columns.Add("nom");
            mydt.Columns.Add("ville");
            mydt.Rows.Add(new object[] { "dps", "mohammedia" });
            mydt.Rows.Add(new object[] { "dps", "Bernoussi" });
            mydt.Rows.Add(new object[] { "It events", "Kech" });
            mydt.Rows.Add(new object[] { "tececo", "casa" });

            dgUtilisateur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUtilisateur.DataSource = mydt;
            GlobVars.FilterDataGridViewIni(dgUtilisateur, txtFind, btnFind);
        }

        private void dgUtilisateur_DoubleClick(object sender, EventArgs e)
        {
           
        }
    }
}
