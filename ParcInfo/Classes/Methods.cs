using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace ParcInfo.Classes
{
    public static class Methods
    {
        public static Color GetColor(string statut)
        {
            Color color = Color.Black;
            switch (statut)
            {
                case "en attente":
                    color = Color.FromArgb(255, 192, 0);
                    break;
                case "en retard":
                    color = Color.FromArgb(235, 59, 90);
                    break;
                case "en cours":
                    color = Color.FromArgb(241, 196, 15);
                    break;
                case "terminer":
                    color = Color.FromArgb(46, 204, 113);
                    break;
                default:
                    break;
            }

            return color;
        }
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
        public static void ClearControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                {
                    ClearControls(c);
                }
                else if (c is FlowLayoutPanel)
                {
                    var lblDep = (from x in c.Controls.OfType<txtlblDepartement>()
                                  select x
                                 ).ToList();
                    foreach (var item in lblDep.Skip(1))
                    {
                        c.Controls.Remove(item);
                    }
                    var lblDep2 = (from x in c.Controls.OfType<lblTextbox>()
                                   select x
                               ).ToList();
                    foreach (var item in lblDep2.Skip(1))
                    {
                        c.Controls.Remove(item);
                    }
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
                              where x.Text.Trim() == "" && x.Tag != null 
                              select x
                                ).LastOrDefault();

                    if (em != null)
                    {
                        em.Focus();
                        em.BackColor = Color.FromArgb(235, 77, 75);
                        em.ForeColor = Color.White;
                        count++;
                      
                    }
                 
                }

            }
            return count;
        }


        public static string RemoveSpace(string x)
        {
            return  Regex.Replace(x, @"\s+", " ");
            
        }

        public static List<LabelControl> GetidList(Control control)
        {
            List<LabelControl> list = new List<LabelControl>();
            foreach (Control c in control.Controls)
            {
                if (c is lblTextbox lbl)
                {
                    list.Add(new LabelControl()
                    {
                        Id = int.Parse(lbl.Lblid),
                        Value = lbl.TxtValue,
                        IsDeleted = !lbl.Visible,
                        Controlname = lbl.Name,
                        Idaffectation = int.Parse(lbl.LblAff),
                        Login = lbl.LblUser,
                        Pass = lbl.LblPass
                    });
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
        public static DataTable FilterDataGridViewIni(DataGridView grid, TextBox txt, Button btnclear, dynamic ls = null)
        {
            if (ls != null)
                grid.DataSource = ToDataTable(ls);
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
                var tem = word.Replace("'", "''");
                var values = dataTable.Columns
                    .OfType<DataColumn>()
                    .Select(c => "Convert([" + c.ColumnName + "], System.String)")
                    .Select(c => c + $" like '%{tem}%'");

                var filter = string.Join(" or ", values);
                dv = new DataView(dv.ToTable());

                dv.RowFilter = filter;
                grid.DataSource = dv;
            }
        }

        public static string Replace(this string s, char[] separators, string newVal)
        {
            string[] temp;

            temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return String.Join(newVal, temp);
        }

        public static void Nice_grid(string[] columns, string[] columnstext, DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = true;
            grid.AllowUserToResizeRows = false;

            foreach (var c in columns)
            {
                if (c.ToLower() == "id")
                    grid.Columns["id"].Visible = false;
                else if (c.ToLower() == "isdeleted")
                    grid.Columns["IsDeleted"].Visible = false;
            }
            
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
            grid.BackgroundColor = Color.FromArgb(222, 228, 234);
            grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            grid.ReadOnly = true;
            grid.ColumnHeadersHeight = 40;
            grid.RowHeadersVisible = false;
            grid.ScrollBars = ScrollBars.Both;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;

            // row style row 
             DataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(69, 170, 242);
            grid.RowsDefaultCellStyle = DataGridViewCellStyle1;
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
            //foreach (DataGridViewRow item in grid.Rows)
            //{
            //    var t = item.Cells["IsDeleted"].Value.ToString();
            //    if (int.Parse(t) == 1)
            //    {
            //        DataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 71, 87);
            //        grid.RowsDefaultCellStyle = DataGridViewCellStyle1;
            //    }

            //}

        }

        public static void ChangeColorCell(DataGridView grid)
        {
            foreach (DataGridViewRow item in grid.Rows)
            {

                var t = item.Cells["Getstatut"].Value.ToString();
                item.Cells["Getstatut"].Style.BackColor = Methods.GetColor(t);
                item.Cells["Getstatut"].Style.ForeColor = Color.White;
                item.Cells["Getstatut"].Style.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                item.Cells["Getstatut"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }


        //ChangeColorDeleted
        public static void ChangeDeltedRow(DataGridView grid)
        {
            foreach (DataGridViewRow item in grid.Rows)
            {

                item.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 71, 87);
                item.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        //methods for Password

        public static string stringMsg(string nom, string prenom, string email, string password)
        {
            string msg = $"<p>Hello <b>{nom} {prenom}</b></p><br>" +
                $"you have been registered successfully <br>" +
                $"Here Your Login credentials <br> " +
                $"<b>Email : {email}</b> <br>" +
                $"<b>Password : {password} </b>";
            return msg;
        }
        public static string StringForget(string nom, string prenom, string password)
        {
            string msg = $"<p>Hello <b>{nom} {prenom}</b></p><br>" +
                $" Here is Your New Password : <b> {password}</b><br>" +
                $"";
            return msg;
        }
        public static void sendEmail(string email, string msg)
        {
            MailMessage mail = new MailMessage("parcinfoit@gmail.com", email);
            mail.Subject = "subj";
            mail.Body = msg;
            mail.IsBodyHtml = true;
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("parcinfoit@gmail.com", "parc123456");
                client.Send(mail);
            }
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        public static byte[] ImageToByteArrayIcon(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Icon);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {

            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static void CheckRoles(ControlCollection controlcol)
        {
            Dictionary<string[], string[]> AllRoles = new Dictionary<string[], string[]>
            {
                //client
                { new string []{ "Consulter les client concerner","Consulter tous les client"},  new string []{ "BtnListClient" } },

                { new string []{ "Ajouter Client"}, new string []{ "BtnCreateClient", "btnNewClient" } },
                { new string []{ "Modifier Client"}, new string []{ "btnEditClient" } },
                { new string []{ "Supprimer Client"},  new string []{ "btnDelClient" } },

                { new string []{ "Consulter les produits"},  new string []{ "gpProduit" } },
                { new string []{ "Modifier produit affecter" },  new string []{ "btnEdit", "btnAddEmployee", "btnAddProduit" } },
                { new string []{ "Supprimer affectation d'un produit" },  new string []{ "BtnDelAffeProduct" } },

                { new string []{ "Consulter les employees" }, new string []{ "gpEmployee" } },
                //{ new string []{ "Ajouter un employee" }, new string []{ "btnNewEmployee", "btnAjouter" } }, //errr
                //{ new string []{ "Modifier un employee" }, new string []{ "btnEditEmployee", "btnAnnuler" } }, //errr
                { new string []{ "Supprimer un employee" }, new string []{ "btnDelEmp" } },

                //Interevntion
                { new string []{ "Consulter les intervention concerner","Consulter tous les interventions" }, new string[] { "DropIntervention" } },
                { new string []{ "Ajouter intervention" }, new string[] { "BtnstartInterventionFich", "btnTraiter", "btnStartIntervention" } },

                //demande
                { new string []{ "Consulter les demandes concerner", "Consulter tous les demandes" }, new string[] { "DropDemande" } },


                //produit
                { new string []{ "Consulter tous les produits" }, new string[] { "btnListProduct" } },
                { new string []{ "Affecter les produits" }, new string[] { "gpAffectationProduit" } },
                { new string []{ "Ajouter produit" }, new string[] { "btnAddProduct", "btnClear" } },
                { new string []{ "Modifier produit" }, new string[] { "btnAddProduct" } },
                { new string []{ "supprimer produit" }, new string[] { "btnDelP" } },
            };

            Dictionary<string, Control> cs = new Dictionary<string, Control>();
            var rolesuser = GlobVars.cuUser.GetRoles.ToList();
            if (GlobVars.cuUser.isAdmin == 0)
                foreach (var r in AllRoles)
                {
                    foreach (var b in r.Value)
                    {
                        Control c = controlcol.Find(b, true).FirstOrDefault();
                        if (c != null)
                        {
                            foreach (var k in r.Key)
                            {
                                c.Visible = rolesuser.Contains(k);
                                if (c.Visible == true)
                                    break;
                            }
                        }
                    }
                }
            var plmenu = controlcol.Find("pnlMenu", true).FirstOrDefault();
            if (plmenu != null)
                foreach (Control v in plmenu.Controls)
                {
                    var allbtnsvisible = v.Controls.OfType<Button>().Where(x => x.Visible).Count();
                    if (allbtnsvisible == 1)
                        v.Visible = false;
                }
        }
    }

    public class LabelControl
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Value { get; set; }
        public string Controlname { get; set; }
        public int Idaffectation { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
    }
}