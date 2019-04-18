using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.Classes
{
    public static class Methods
    {

        public static void Clear(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                {
                    Clear(c);
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is Panel)
                {
                    Clear(c);
                }
                else if (c is lblTextbox)
                {
                    ((lblTextbox)c).TxtValue = "";
                }
                else if (c is txtlblDepartement)
                {
                    ((txtlblDepartement)c).TxtValue = "";
                }
            }

        }
        public static int Foucs(Control control)
        {
            int count = 0;
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                {
                    Foucs(c);
                }
                else if (c is TextBox)
                {
                    if (c.Tag != null)
                    {
                        if (c.Text == "")
                        {
                            c.Focus();
                            count++;
                        }
                    }
                }
                else if (c is Panel)
                {
                    Foucs(c);
                }
                else if (c is lblTextbox)
                {
                    if (((lblTextbox)c).TxtValue == "")
                    {
                        c.Focus();
                        count++;
                    }
                }
            }
            return count;
        }

        public static List<LabelControl> GetidList(Control control)
        {
            List<LabelControl> list = new List<LabelControl>();
            foreach (Control c in control.Controls)
            {
                if (c is lblTextbox lbl)
                {
                    list.Add(new LabelControl() { Id = int.Parse(lbl.Lblid), Value = lbl.TxtValue, IsDeleted = !lbl.Visible,Controlname=lbl.Name ,Idaffectation = int.Parse(lbl.LblAff)});
                }
                else if (c is txtlblDepartement lbl2)
                {
                    list.Add(new LabelControl() { Id = int.Parse(lbl2.Lblid), Value = lbl2.TxtValue, IsDeleted = !lbl2.Visible, Controlname = lbl2.Name });
                }
            }
            return list;
        }

        public static void getDemande(DataGridView dg, int idEmploye, string statut)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                string btname = GlobVars.BtnName;
                var listDemande = (from d in context.Demandes
                                   select new { d.Id, d.Datedemande, d.Description_d, d.Statut, d.IdEmployee }).ToList();
                if (!string.IsNullOrEmpty(statut))
                {
                    var DemandesEmp = (from c in listDemande
                                       where c.IdEmployee == idEmploye && c.Statut == statut
                                       select new { c.Id, c.Datedemande, c.Description_d, c.Statut }).ToList();
                    dg.DataSource = DemandesEmp;

                }
                else
                {
                    var DemandesEmp = (from c in listDemande
                                       where c.IdEmployee == idEmploye
                                       select new { c.Id, c.Datedemande, c.Description_d, c.Statut }).ToList();
                    dg.DataSource = DemandesEmp;
                }
            }
        }


        public static int CheckDepart(Control control, List<string> list)
        {
            int count = 0;
            foreach (Control c in control.Controls)
            {
                if (c is txtlblDepartement)
                {
                    if (((txtlblDepartement)c).TxtValue == "")
                    {
                        c.Focus();
                        count++;
                    }
                    else
                    {
                        string name = ((txtlblDepartement)c).TxtValue;
                        list.Add(name);
                    }
                }
            }
            return count;
        }

        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                //if (!prop.PropertyType.IsClass)
                //{
                    var j = prop.GetType();
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                //}
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    //if (!prop.PropertyType.is)
                    //{
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    //}
                table.Rows.Add(row);
            }
            return table;
        }
        public static DataTable FilterDataGridViewIni(DataGridView grid, TextBox txt, Button btnclear)
        {

            grid.DataSource = new DataView(grid.DataSource as DataTable);
            grid.Tag = grid.DataSource;

            EventHandler textchanged = new EventHandler(delegate (Object o, EventArgs a)
            {
                FilterDataGridView(grid, txt.Text);   
            });
            EventHandler clear = new EventHandler(delegate (Object o, EventArgs a)
            {
                txt.Text = "";
            });
            btnclear.Click -= clear;
            btnclear.Click += clear;
            txt.TextChanged -= textchanged;
            txt.TextChanged += textchanged;
            return null;
        }
        static void FilterDataGridView(DataGridView grid, string s)
        {
            DataTable dataTable = new DataTable();
            DataView defaultdataView = grid.Tag as DataView;

            dataTable = (grid.DataSource as DataView).ToTable();

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
    public class LabelControl
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Value  { get; set; }
        public string Controlname { get; set; }
        public int Idaffectation { get; set; }
    }
}