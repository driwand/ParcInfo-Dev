using ParcInfo.Classes;
using ParcInfo.ucControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public partial class frmselectuser : Form
    {
        public lblTextbox tbx = null;
        public bool isClient = false;
        public List<AffectC> listAfc= new List<AffectC>();
        public frmselectuser(lblTextbox txtbx)
        {
            InitializeComponent();
            tbx = txtbx;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var userList = (from c in context.Utilisateurs
                                select new { c.Id, c.Nom, c.Prenom, c.Email, c.Tel }).ToList();
                dgUsers.DataSource = userList;
            }
        }
        public frmselectuser(bool affecterClient,List<AffectC> listAf)
        {
            InitializeComponent();
            
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (affecterClient)
                {
                    isClient = true;
                    listAfc = listAf;
                    var cList = context.Clients.Where(c => c.IsDeleted != 1).ToList();
                    var clientList = (from c in cList
                                      select new {c.IdCLient,c.id,c.Nom,c.Adresse,c.Tel,c.Siteweb}).ToList();
                    dgUsers.DataSource = Methods.ToDataTable(clientList);
                    Methods.Nice_grid(
                           new string[] { "IdCLient", "id", "Nom", "Adresse", "Tel", "Fax", "Siteweb" },
                           new string[] { "ID Client", "id", "Nom", "Adresse", "Tel", "Fax", "Site web " },
                           dgUsers
                           );
                    Methods.FilterDataGridViewIni(dgUsers, txtFind, btnFind);
                }
            }
        }
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if(dgUsers.SelectedRows.Count > 0)
            {
                if (isClient)
                {
                    using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                    {
                        var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                        int id = int.Parse(myrow.Cells["id"].Value.ToString());

                        foreach (var item in listAfc)
                        {
                            context.ProduitClients.Add(new ProduitClient {Idproduit = item.IdProduit,Idclient = id,Prixvente  =item.Prix });
                        }
                        context.SaveChanges();
                    }
                  
                }
                else
                {
                    var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                    string id = myrow.Cells[0].Value.ToString();
                    string Nom = myrow.Cells[1].Value.ToString();
                    string Prenom = myrow.Cells[2].Value.ToString();
                    tbx.TxtValue = Nom + " " + Prenom;
                    tbx.Lblid = id;
                    
                }
                Close();
            }
            else
            {
                MessageBox.Show("aucune");
            }
            


        }
    }
}
