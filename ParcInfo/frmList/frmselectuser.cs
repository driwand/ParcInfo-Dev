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
        public int idClient;
        public List<int> listProdid = new List<int>();
        public string pC;
        int idPrd;
        public frmselectuser(lblTextbox txtbx)
        {
            InitializeComponent();
            tbx = txtbx;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                this.Text = "Affectation d'un utilisateur à un client";
                lblText.Text = "Filtrer les utilisateurs :";
                var userList = context.Utilisateurs.ToList();
                dgUsers.DataSource = Methods.ToDataTable(userList.Select(c => new { c.IdUser, c.Id, c.Nom, c.Prenom, c.Adresse, c.Tel }).ToList());
                Methods.Nice_grid(
                       new string[] { "IdUser", "Id", "Nom", "Prenom", "Adresse", "Adresse", "Tel" },
                       new string[] { "ID Utilisateur", "id", "Nom", "Prenom", "Adresse", "Tel" },
                       dgUsers
                       );
            }
        }
        public frmselectuser(lblTextbox txtbx, string cod, int id, int idProd, int idProdC)
        {
            InitializeComponent();
            tbx = txtbx;
            idPrd = idProd;
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (cod == "emp" && id > 0)
                {

                    //where !(listProduitClient.Any(it => it.Idproduit == p.id && it.IsDeleted == 0))
                    var s = context.Employees.Where(d => d.Idclient == id && d.IsDeleted == 0).ToList();
                    var pu = context.ProduitUtilisers.ToList();
                    var empLIST = (from c in s
                                   where !(pu.Any(it => it.IdEmployee == c.Id && idProdC == it.IdProduitClient))
                                   select c).ToList();
                    /*context.Employees.Where(c=> c.Idclient == id).ToList();*/
                    idemp = id;
                    this.Text = "Liste des Employees";
                    lblText.Text = "Les Employees : ";
                    dgUsers.DataSource = Methods.ToDataTable(empLIST.Select(c => new { c.IdEmploye, c.Id, c.Nom, c.Prenom, c.Email, c.Tel }).ToList());
                    Methods.Nice_grid(
                          new string[] { "IdEmploye", "id", "Nom", "Prenom", "Email", "Tel" },
                          new string[] { "ID Employee", "id", "Nom", "Prenom", "Email", "Tel" },
                          dgUsers
                  );
                }
                else if (cod == "log" && idProd > 0)
                {
                    pC = "log";
                    this.Text = "Liste des produits";
                    lblText.Text = "Filtrer les produits :";
                    var listProd = (from c in context.ProduitClients
                                    join p in context.Produits on c.Idproduit equals p.id
                                   
                                    where c.Idclient == id 
                                    && idProd != c.Idproduit 
                                    && c.Produit.TypeProduit.Nom != "ordinateur"
                                    select new { c, p }).ToList();

                    dgUsers.DataSource = Methods.ToDataTable(listProd.Select(s => new
                    {
                        s.p.CodeP,
                        s.c.Id,
                        idP = s.p.id,
                        s.p.TypeProduit.Nom,
                        s.p.Marque,
                        s.p.Model,
                       
                        Datefabrication = s.p.Datefabrication.Value.ToShortDateString()
                    }).ToList());
                    Methods.Nice_grid(
                         new string[] { "CodeP", "Id", "idP", "Nom", "Marque", "Model", "Datefabrication" },
                         new string[] { "Code Produit", "id", "idP", "Type", "Marque", "Model", "Date de fabrication" },
                         dgUsers
                 );
                    dgUsers.Columns["idP"].Visible = false;
                }
            }
        }
        int idemp = 0;
        DataGridView dggrid;
        public frmselectuser(List<int> listAf,DataGridView dg)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (listAf != null && listAf.Count > 0)
                {
                    this.Text = "Affectation d'un produit à un client";
                    lblText.Text = "Filtrer les client :";
                    dggrid = dg;
                    listProdid = listAf;
                    var cList = context.Clients.Where(c => c.IsDeleted == 0).ToList();

                    var clientList = (from c in cList
                                      select new { c.IdCLient, c.id, c.Nom, c.Adresse, c.Tel, c.Siteweb }).ToList();
                    dgUsers.DataSource = Methods.ToDataTable(clientList);
                    Methods.Nice_grid(
                           new string[] { "IdCLient", "id", "Nom", "Adresse", "Tel", "Siteweb" },
                           new string[] { "ID Client", "id", "Nom", "Adresse", "Tel", "Site web " },
                           dgUsers
                           );
                    // Methods.FilterDataGridViewIni(dgUsers, txtFind, btnFind);
                    
                    

                    
                }
            }
        }

        
      
        public frmselectuser()
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

            }
        }





        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count > 0)
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    if (listProdid.Count > 0)
                    {

                        var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                        int id = int.Parse(myrow.Cells["id"].Value.ToString());
                        frmAffecter frm = new frmAffecter(id, listProdid,dggrid);
                        frm.ShowDialog();

                    }
                    else if (idemp > 0)
                    {
                        var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                        int id = int.Parse(myrow.Cells["id"].Value.ToString());
                        string Nom = myrow.Cells["Nom"].Value.ToString();
                        string Prenom = myrow.Cells["Prenom"].Value.ToString();
                        tbx.TxtValue = Nom + " " + Prenom;
                        tbx.Lblid = id.ToString();

                        var pd = context.Produits.Find(idPrd);
                        if (pd.TypeProduit.SupportingUser == 1)
                        {
                            frmAffecter frm = new frmAffecter(tbx, id);
                            frm.ShowDialog();
                        }
                       
                    }
                    else if (pC == "log")
                    {
                        var myrow = dgUsers.Rows[dgUsers.CurrentRow.Index];
                        string id = myrow.Cells["id"].Value.ToString();
                        string Marque = myrow.Cells["Marque"].Value.ToString();
                        string Model = myrow.Cells["Model"].Value.ToString();
                        string idP = myrow.Cells["idP"].Value.ToString();

                        var idProc = int.Parse(id);
                        int idProdC = int.Parse(idP);
                        var produitP = (from c in context.ValeurProps
                                       join pp in context.ProprietesProduits on c.IdPropriete equals pp.Id
                                       where c.IdProduit == idProdC && pp.Nom == "Maximum utilisateurs"
                                       select new { c, pp }).FirstOrDefault();
                        var prodIn = (from c in context.ProduitClients
                                      join ins in context.Installers on c.Id equals ins.Idproduitclient
                                      where ins.Idhardsoft == idProc
                                      select ins).ToList();
                  
                        if (prodIn.Count() < int.Parse(produitP.c.Valeur))
                        {

                            tbx.TxtValue = $"{Marque} {Model}";
                            tbx.Lblid = id;
                        }
                        else
                        {
                            MessageBox.Show("Nombre de poste maximum pour un logiciel atteint");
                        }
                        //tbx.TxtValue = $"{Marque} {Model}";
                        //tbx.Lblid = id;
                        
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
            }
            else
            {
                MessageBox.Show("aucune");
            }



        }

        private void frmselectuser_Load(object sender, EventArgs e)
        {
            using (var db = new ParcInformatiqueEntities())
            {
                var par = db.ParametreParcinfoes.FirstOrDefault();
                if (par != null)
                {
                    if (par.Iconapp != null)
                    {
                        System.Drawing.Bitmap bitmap = Methods.ByteArrayToImage(par.Iconapp) as System.Drawing.Bitmap;
                        IntPtr ico = bitmap.GetHicon();
                        Icon icon = Icon.FromHandle(ico);

                        this.Icon = icon;
                    }
                }
            }
            Methods.FilterDataGridViewIni(dgUsers, txtFind, btnFind);
        }
    }
}
