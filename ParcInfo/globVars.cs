using ParcInfo.Classes;
using ParcInfo.frmDefault;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public  class AffectC
    {
        public int IdProduit { get; set; }
        public float Prix { get; set; }

    }
    public static class GlobVars
    {
        public static int selectedEmploye;
        public static int selectedClient;
        public static string BtnName;

  

        public static string NomUtilisateur;
        public static int idUtilisateur;

        public static UserControl frmBack;
        public static UserControl frmBack2;
        public static FrmDefault frmindex;
        public static int countInterv;
        public static int countIntervDeInt;
        public static int countIntervCours;
        public static int countIntervRetard;
        public static int countIntervTerminer;

        public static string NomClient;
        public static string SearchValue;

        
        public static int selectedIntervention;
        public static int selectedRequest;

        public static int currentUser = 1;

        public static int id;
        public static string name;
        public static void FilterDataGridViewIni(DataGridView grid, TextBox txt, Button btnclear)
        {
            FilterDataGridViewIni<int>(grid,txt, btnclear, false);
        }
        public static void FilterDataGridViewIni<T>(DataGridView grid, TextBox txt, Button btnclear,bool islist = true)
        {
            var dataTable = new DataTable();
            if (islist)
            {
                dataTable = Methods.ToDataTable<T>((List<T>)grid.DataSource);

                grid.DataSource = dataTable;
            }

            grid.DataSource = new DataView(grid.DataSource as DataTable);
            grid.Tag = grid.DataSource;
            EventHandler textchanged = new EventHandler(delegate (Object o, EventArgs a)
            {
                FilterDataGridView<T>(grid, txt.Text,islist);
            });
            EventHandler clear = new EventHandler(delegate (Object o, EventArgs a)
            {
                txt.Text = "";
            });
            btnclear.Click -= clear;
            btnclear.Click += clear;
            txt.TextChanged -= textchanged;
            txt.TextChanged += textchanged;
        }
        static void FilterDataGridView<T>(DataGridView grid, string s,bool islist)
        {
            DataView defaultdataView = grid.Tag as DataView;
            DataTable dataTable = new DataTable();

            
            var words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (!words.Any())
            {
                grid.DataSource = defaultdataView;
                return;
            }

            var dv = defaultdataView;

            foreach (var word in words)
            {
                var values = dataTable.Columns
                    .OfType<DataColumn>()
                    .Select(c => "Convert([" + c.ColumnName + "], System.String)")
                    .Select(c => c + " like '%" + word + "%'");

                var filter = string.Join(" or ", values);
                dv = new DataView(dv.ToTable());
                dv.RowFilter = filter;
                grid.DataSource = dv;
            }
        }
    }
}
