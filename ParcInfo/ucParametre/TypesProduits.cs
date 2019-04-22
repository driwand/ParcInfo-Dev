using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucControls;
using ParcInfo.ucClient;
using ParcInfo.Classes;

namespace ParcInfo.settings
{
    public partial class TypesProduits : UserControl
    {
        int typeName = 1;

        public TypesProduits()
        {
            InitializeComponent();
        }
        void DelDep_clicked(object sender, EventArgs e)
        {
           
        }
        private void TypesProduits_Load(object sender, EventArgs e)
        {
            // txtlblDepartement depr = new txtlblDepartement();
            txtlblType type = new txtlblType();
            type.Name = "type" + typeName;
            type.Margin = new Padding(0, 0, 0, 12);
            typeName++;
            pnlProp.Controls.Add(type);

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var list = (from c in context.TypeProduits
                            where c.IsDeleted == 0
                            select new {c.id, c.Nom, supportUser = c.SupportingUser == 1 ? "Oui" : "Non", supportLog = c.SupportingSoftware == 1 ? "Oui" : "Non" }).ToList();
                dgType.DataSource = list;
            }
            
            Methods.Nice_grid(
                             new string[] { "id", "Nom", "supportLog", "supportUser",   },
                             new string[] { "id", "Type", "Supporte le logiciel", "Supporte utilisateur" },
                             dgType
                             );
            dgType.Columns["id"].Visible = true;
        }

        private void btnAddProp_Click(object sender, EventArgs e)
        {
            // txtlblDepartement depr = new txtlblDepartement();
            txtlblType type = new txtlblType();
            type.Name = "type" + typeName;
            type.Margin = new Padding(0, 0, 0, 12);
            typeName++;
            pnlProp.Controls.Add(type);
            pnlProp.Height += 23;

            if (pnlProp.Size == pnlProp.MaximumSize)
            {
                pnlProp.AutoScroll = true;

            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                int idType = int.Parse(lblID.Text);
                if (idType == 0)
                {
                    // get Type Nom
                    var TypeP = txtType.Text;
                    int supportLog = 0;
                    int supportUser = 0;
                    if (cbUser.Checked)
                    {
                        supportUser = 1;
                    }
                    if (cbLog.Checked)
                    {
                        supportLog = 1;
                    }
                    TypeProduit tp = new TypeProduit
                    {
                        Nom = TypeP,
                        SupportingSoftware = supportLog,
                        SupportingUser = supportUser,
                        IsDeleted = 0
                    };
                    context.TypeProduits.Add(tp);
                    var lblType = (from x in pnlProp.Controls.OfType<txtlblType>()
                                   select x
                              ).ToList();
                    foreach (var item in lblType)
                    {
                        context.ProprietesProduits.Add(new ProprietesProduit { Nom = item.TxtValue, idType = tp.id, IsDeleted = 0 });
                    }
                    context.SaveChanges();
                    MessageBox.Show("Insertion effectuée");
                    Methods.Clear(this);
                }
                
            }

        }

        private void dgType_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgType.SelectedRows.Count > 0)
            {
                var myrow = dgType.Rows[dgType.CurrentRow.Index];

                int id = int.Parse(myrow.Cells["id"].Value.ToString());

                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var t = context.TypeProduits.Find(id);
                    if (t != null)
                    {
                        txtType.Text = t.Nom;
                        if (t.SupportingSoftware == 1)
                        {
                            cbLog.Checked = true;
                        }
                        if (t.SupportingUser == 1)
                        {
                            cbUser.Checked = true;
                        }
                        lblID.Text = t.id.ToString();
                        txtlblType tbx = this.Controls.Find("type1", true).FirstOrDefault() as txtlblType;

                        tbx.TxtValue = t.ProprietesProduits.FirstOrDefault().Nom;
                        tbx.LblID = t.ProprietesProduits.FirstOrDefault().Id.ToString();
                        foreach (var item in t.ProprietesProduits.Skip(1))
                        {
                            txtlblType type = new txtlblType();
                            type.Name = "type" + typeName;
                            type.TxtValue = item.Nom;
                            type.LblID = item.Id.ToString();
                            type.Margin = new Padding(0, 0, 0, 12);
                            typeName++;
                            pnlProp.Controls.Add(type);
                            pnlProp.Height += 23;
                            if (pnlProp.Size == pnlProp.MaximumSize)
                            {
                                pnlProp.AutoScroll = true;
                            }
                        }
                      

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lblDep = (from x in pnlProp.Controls.OfType<txtlblType>()
                          select x
                        ).ToList();

            foreach (var item in lblDep)
            {
                pnlProp.Controls.Remove(item);
            }
            txtType.Text = "";
            cbLog.Checked = false;
            cbUser.Checked = false;
            lblID.Text = "0";
            txtlblType type = new txtlblType();
            type.Name = "type" + typeName;
            type.Margin = new Padding(0, 0, 0, 12);
            pnlProp.Controls.Add(type);
        }
    }
}
