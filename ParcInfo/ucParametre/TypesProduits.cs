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
                    if (txtType.Text == "")
                    {
                        txtType.Focus();
                    }
                    else
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
                            if (item.TxtValue != "")
                            {
                                context.ProprietesProduits.Add(new ProprietesProduit { Nom = item.TxtValue, idType = tp.id, IsDeleted = 0 });

                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show("Insertion effectuée");
                        Clear();
                        Methods.Clear(this);
                    }
                }
                else
                {
                    var id = int.Parse(lblID.Text);
                    var t = context.TypeProduits.Find(id);
                    var lblDep = (from x in pnlProp.Controls.OfType<txtlblType>()
                                  select x
                   ).ToList();
                    foreach (var item in lblDep)
                    {
                        if (!item.Visible && int.Parse(item.LblID) > 0)
                        {
                            var tprop = t.ProprietesProduits.Where(d => d.Id == int.Parse(item.LblID)).FirstOrDefault();
                            if (tprop != null)
                            {
                                tprop.IsDeleted = 1;
                                txtlblType tbx = this.Controls.Find(item.Name, true).FirstOrDefault() as txtlblType;
                                pnlProp.Controls.Remove(tbx);
                            }
                        }
                        else if (item.Visible && int.Parse(item.LblID) == 0 && item.TxtValue != "" )
                        {
                            context.ProprietesProduits.Add(new ProprietesProduit { Nom = item.TxtValue, idType = t.id, IsDeleted = 0 });
                        }
                        else if(item.Visible && int.Parse(item.LblID) > 0)
                        {
                            var tprop = t.ProprietesProduits.Where(d => d.Id == int.Parse(item.LblID)).FirstOrDefault();
                            tprop.Nom = item.TxtValue;
                        }
                    }
        
                    context.SaveChanges();
                }
                
            }
        }
        public void Clear()
        {
            typeName = 1;
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

        private void btnNewType_Click(object sender, EventArgs e)
        {
            Clear();
            btnNewType.Visible = false;
            btnDelType.Visible = false;
        }

        private void dgType_DoubleClick(object sender, EventArgs e)
        {
            if (dgType.SelectedRows.Count > 0)
            {
                Clear();
                var myrow = dgType.Rows[dgType.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var t = context.TypeProduits.Find(id);
                    if (t != null)
                    {
                        btnNewType.Visible = true;
                        btnDelType.Visible = true;
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
                        if (tbx != null)
                        {
                            var frs = t.ProprietesProduits.Where(d=> d.IsDeleted == 0).FirstOrDefault();
                            if (frs != null)
                            {
                                tbx.TxtValue = frs.Nom;
                                tbx.LblID = frs.Id.ToString();
                            }
                           
                        }

                        foreach (var item in t.ProprietesProduits.Where(d=> d.IsDeleted == 0).Skip(1))
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

        private void btnDelType_Click(object sender, EventArgs e)
        {

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var myrow = dgType.Rows[dgType.CurrentRow.Index];
                int id = int.Parse(myrow.Cells["id"].Value.ToString());
                TypeProduit c = context.TypeProduits.Find(id);

                DialogResult result = MessageBox.Show("Voulez-vous supprimer le type suivant ?", "confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    c.IsDeleted = 1;
                   
                    context.SaveChanges();
                    MessageBox.Show("type supprimé");
                    Clear();
                }
                else if (result == DialogResult.No)
                {

                }
            }
        }
    }
}
