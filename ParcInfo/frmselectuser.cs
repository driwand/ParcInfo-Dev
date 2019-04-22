﻿using ParcInfo.Classes;
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
        public int idClient;
        public List<int> listProdid = new List<int>();
        public frmselectuser(lblTextbox txtbx)
        {
            InitializeComponent();
            tbx = txtbx;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var userList = context.Utilisateurs.ToList();
                dgUsers.DataSource = Methods.ToDataTable(userList.Select(c => new { c.IdUser,c.Id,c.Nom,c.Prenom,c.Adresse,c.Tel}).ToList());
                Methods.Nice_grid(
                       new string[] { "IdUser", "id", "Nom", "Prenom", "Adresse", "Adresse", "Tel" },
                       new string[] { "ID Utilisateur", "id", "Nom", "Prenom", "Adresse", "Tel" },
                       dgUsers
                       );
                
            }
        }
        public frmselectuser(lblTextbox txtbx, string cod, int id)
        {
            InitializeComponent();
            tbx = txtbx;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (cod == "emp" && id > 0)
                {
                    var empLIST = context.Employees.Where(c=> c.Idclient == id).ToList();
                        
                    dgUsers.DataSource = Methods.ToDataTable(empLIST.Select(c => new { c.IdEmploye,c.Id, c.Nom, c.Prenom, c.Email, c.Tel }).ToList());
                    Methods.Nice_grid(
                          new string[] { "IdEmploye", "id", "Nom", "Prenom", "Email", "Tel"},
                          new string[] { "ID Employee", "id", "Nom", "Prenom", "Email", "Tel" },
                          dgUsers
                  );
                }
                else if (cod == "log")
                {
                    var userList = (from p in context.Produits
                                    select new { p.id, p.TypeProduit.Nom, p.Marque, p.Model, p.Prix, p.Datefabrication }).ToList();
                    dgUsers.DataSource = userList;
                }
            }
        }
        public frmselectuser(List<int> listAf)
        {
            InitializeComponent();
            
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (listAf != null && listAf.Count > 0)
                {
                    listProdid = listAf;
                    var cList = context.Clients.Where(c => c.IsDeleted == 0).ToList();
                    
                    var clientList = (from c in cList
                                      select new { c.IdCLient, c.id, c.Nom, c.Adresse, c.Tel, c.Siteweb }).ToList();
                    dgUsers.DataSource = Methods.ToDataTable(clientList);
                    Methods.Nice_grid(
                           new string[] { "IdCLient", "id", "Nom", "Adresse", "Tel",  "Siteweb" },
                           new string[] { "ID Client", "id", "Nom", "Adresse", "Tel","Site web " },
                           dgUsers
                           );
                   // Methods.FilterDataGridViewIni(dgUsers, txtFind, btnFind);
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
                if (listProdid.Count > 0)
                {
                    using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                    {
                        var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                        int id = int.Parse(myrow.Cells["id"].Value.ToString());
                        frmAffecter frm = new frmAffecter(id, listProdid);
                        frm.ShowDialog();
                      
                        //foreach (var item in listAfc)
                        //{
                        //    context.ProduitClients.Add(new ProduitClient { Idproduit = item.IdProduit, Idclient = id, Prixvente = item.Prix });
                        //}
                        //context.SaveChanges();
                    }
                }
                else
                {
                    var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                    string id = myrow.Cells["id"].Value.ToString();
                    string Nom = myrow.Cells["Nom"].Value.ToString();
                    string Prenom = myrow.Cells["Prenom"].Value.ToString();
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

        private void frmselectuser_Load(object sender, EventArgs e)
        {
            Methods.FilterDataGridViewIni(dgUsers, txtFind, btnFind);
        }
    }
}
