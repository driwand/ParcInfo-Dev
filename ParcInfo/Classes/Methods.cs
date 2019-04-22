using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public static string Splitdate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            return dt.ToString("dMMy");
        }
        public static string GetDesc(string des, int len)
        {
            var f = des.Split(' ').Take(len);
            string res = "";
            foreach (string s in f)
            {
                res += s + " ";
            }
            return res + "...";
        }

        public static int Focus(Control control)
        {
            int count = 0;
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                {
                    var em = (from x in c.Controls.OfType<TextBox>()
                              where x.Text == "" && x.Tag != null
                              select x
                                ).LastOrDefault();
                    if (em != null)
                    {

                        em.Focus();
                        count++;
                    }

                }

            }
            return count;
        }

        //public static int Focus2( Control control)
        //{
        //    int count = 0;
        //    foreach (Control c in control.Controls)
        //    {
        //        if (c is FlowLayoutPanel)
        //        {
        //            var lblDep = (from x in c.Controls.OfType<txtlblDepartement>()
        //                          where x.TxtValue == ""
        //                          select x
        //                   ).LastOrDefault();

        //            if (lblDep != null)
        //            {
        //                lblDep.Focus();
        //                count++;
        //            }
        //            var lblUser = (from x in c.Controls.OfType<lblTextbox>()
        //                           where x.TxtValue == ""
        //                           select x
        //                  ).LastOrDefault();

        //            if (lblUser != null)
        //            {
        //                lblUser.Focus();
        //                count++;
        //            }
        //        }
        //    }
        //    return count;

        //}
        public static List<LabelControl> GetidList(Control control)
        {
            List<LabelControl> list = new List<LabelControl>();
            foreach (Control c in control.Controls)
            {
                if (c is lblTextbox lbl)
                {
                    list.Add(new LabelControl() { Id = int.Parse(lbl.Lblid), Value = lbl.TxtValue, IsDeleted = !lbl.Visible, Controlname = lbl.Name, Idaffectation = int.Parse(lbl.LblAff) });
                }
                else if (c is txtlblDepartement lbl2)
                {
                    list.Add(new LabelControl() { Id = int.Parse(lbl2.Lblid), Value = lbl2.TxtValue, IsDeleted = !lbl2.Visible, Controlname = lbl2.Name });
                }
                else if (c is prixVente lbl3)
                {
                    list.Add(new LabelControl() { Id = int.Parse(lbl3.Lblid), Value = lbl3.TxtValue, Controlname = lbl3.Name });
                }
            }
            return list;
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

        public static void Nice_grid(string[] columns, string[] columnstext, DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = true;
            grid.AllowUserToResizeRows = false;
            grid.Columns["id"].Visible = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewCellStyle DataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25f);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("fr-FR");
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid.BackgroundColor = Color.WhiteSmoke;
            grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            grid.ReadOnly = true;
            grid.ColumnHeadersHeight = 40;
            grid.RowHeadersVisible = false;
            grid.ScrollBars = ScrollBars.Both;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;

            int x = 0;
            foreach (DataGridViewColumn column in grid.Columns)
                x += column.Width;
            if (x < grid.Width)
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int index = 0;
            foreach (DataGridViewColumn r in grid.Columns)
            {
                if (!(Array.IndexOf(columns, r.Name) > -1))
                {
                    r.Visible = false;
                }
                else
                {
                    index = index + 1;
                    r.Width = grid.Width / columns.Length;
                    r.HeaderText = columnstext[index - 1];
                }
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