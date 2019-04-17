using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.Classes
{
    public class Methods
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
                    list.Add(new LabelControl() { Id = int.Parse(lbl.Lblid), Value = lbl.TxtValue, IsDeleted = !lbl.Visible });
                }
                else if (c is txtlblDepartement lbl2)
                {
                    list.Add(new LabelControl() { Id = int.Parse(lbl2.Lblid), Value = lbl2.TxtValue, IsDeleted = !lbl2.Visible });
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


        //list to datatable
        public static DataTable ToDataTable<T>(List<T> items)
        {
            var firste = items[0].GetType();
            DataTable dataTable = new DataTable("jjjj");
            
            //Get all the properties
            PropertyInfo[] Props = firste.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (var item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
    public class LabelControl
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Value  { get; set; }
    }
}