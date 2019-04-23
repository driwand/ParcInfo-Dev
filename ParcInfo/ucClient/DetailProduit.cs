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
using ParcInfo.Classes;

namespace ParcInfo.ucClient
{
    public partial class DetailProduit : UserControl
    {
        int userName = 1;
        int logName = 1;
        int idProd;
        int idC;
        int idEmploye;
        public DetailProduit(int idClient,int idP)
        {
            InitializeComponent();
            if (idClient > 0 && idP > 0)
            {
                idC = idClient;
                idProd = idP;
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    var c = context.Clients.Find(idClient);
                    var p = c.ProduitClients.Where(d => d.Idproduit == idP).Select(s => s).FirstOrDefault();
                    lblClient.Text = $"[{c.IdCLient}]";
                    if (p.Utilisateur != null)
                    {  lblUser.Text = p.Utilisateur.Nom;
                    }
                  
                    lblDateAff.Text = p.Dateaffectation.Value.ToShortDateString();
                    lblPrix.Text = p.Prixvente.ToString();
                }            
            }
        }
        public DetailProduit(int idP,string idEmp)
        {
            InitializeComponent();
            if (idP > 0)
            {
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    int idemp = int.Parse(idEmp);
                    idProd = idP;
                    idEmploye = idemp;
                    var e = context.Employees.Find(idemp);
                    var p = (from c in e.ProduitUtilisers
                             join pr in context.ProduitClients on c.IdProduitClient equals pr.Id
                             where idP == pr.Idproduit
                             select new { c, pr.Prixvente,c.Utilisateur}).FirstOrDefault();
                    lblClient.Text = $"[{e.IdEmploye}]";
                    if (p.Utilisateur != null)
                    {
                        lblUser.Text = p.Utilisateur.Nom;
                    }

                    lblDateAff.Text = p.c.Dateaffectation.Value.ToShortDateString();
                    lblPrix.Text = p.Prixvente.ToString();
                }
            }
        }
        private void ListProduitClient_Load(object sender, EventArgs e)
        {
            lblTextbox user1 = new lblTextbox(idC,"emp");
            user1.Name = "userC" + userName;
            user1.LblText = "Nom :";
            user1.LblAff = "0";
            user1.Lblid = "0";
            user1.Margin = new Padding(0, 0, 0, 12);
            userName++;
            FpEmployee.Controls.Add(user1);
            lblTextbox log = new lblTextbox(idC,"log");
            log.Name = "log" + logName;
            log.LblText = "Nom :";
            log.Margin = new Padding(0, 0, 0, 12);
            logName++;

            FpProduit.Controls.Add(log);

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var d = context.Produits.Find(idProd);
                var pc = d.ProduitClients.FirstOrDefault();
                if (d != null)
                {
                    List<TypeProduit> listT = new List<TypeProduit>();
                    listT.Add(d.TypeProduit);
                    ProduitInfo pd = new ProduitInfo(d,listT);
                    pd.Name = "pd";
                    pd.Location = new Point(18, 50);
                    this.Controls.Add(pd);
                }
                // Check IF 
                if (idC > 0 && idProd > 0)
                {
                    var pu = (from c in d.ProduitClients
                              from x in c.ProduitUtilisers
                              where x.IsDeleted == 0
                              select x).ToList();

                    lblTextbox tbx = this.Controls.Find("userC1", true).FirstOrDefault() as lblTextbox;

                    if (pu != null && pu.Count > 0)
                    {
                        var user = pu.FirstOrDefault();
                        tbx.TxtValue = user.Employee.Nom + " " + user.Employee.Prenom;
                        tbx.Lblid = user.IdEmployee.ToString();
                        tbx.LblAff = user.Id.ToString();
                        foreach (var item in pu.Skip(1))
                        {
                            //first lblTexbox to fill user
                            lblTextbox user2 = new lblTextbox(idC, "emp");
                            user2.TxtValue = item.Employee.Nom + " " + item.Employee.Prenom;
                            user2.Name = "userC" + userName;
                            user2.Lblid = item.IdEmployee.ToString();
                            user2.LblAff = item.Id.ToString();
                            user2.LblText = "Nom :";
                            user2.Margin = new Padding(0, 0, 0, 12);
                            userName++;
                            FpEmployee.Controls.Add(user2);
                        }
                    }
                }
                else
                {
                    // remove LBLTEXTBOX
                    lblTextbox tbx = this.Controls.Find("userC1", true).FirstOrDefault() as lblTextbox;
                    FpEmployee.Controls.Remove(tbx);
                    btnAddEmployee.Visible = false;
                    var em = context.Employees.Find(idEmploye);
                    var p = (from c in em.ProduitUtilisers
                             join pr in context.ProduitClients on c.IdProduitClient equals pr.Id
                             where idProd == pr.Idproduit && c.IdEmployee == idEmploye
                             select new { c, pr.Prixvente, c.Utilisateur }).FirstOrDefault();
                    loginPass lg = new loginPass();
                    //lg.LblEmp = em.Nom + " " + em.Prenom;
                    lg.TxtLogin = p.c.Login_u;
                    lg.TxtPass = p.c.Password_u;
                    FpEmployee.Controls.Add(lg);
                    // Size
                    groupBox2.Size = new Size(520, 132);
                    groupBox2.Location = new Point(352, 112);
                    FpEmployee.Size = new Size(473, 101);
                    gpMaterielLogiciel.Size = new Size(520, 177);
                    gpMaterielLogiciel.Location = new Point(352, 250);

                    FpEmployee.Size = new Size(473, 126);
                    btnAddProduit.Location = new Point(478, 132);
                }
              

            }
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<LabelControl> listEmploye = new List<LabelControl>();
            listEmploye = Methods.GetidList(FpEmployee);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var idprodClient = context.ProduitClients.Where(d => d.Idproduit == idProd).FirstOrDefault();
                foreach (var item in listEmploye)
                {
                    if (item.Idaffectation > 0 && !item.IsDeleted)
                    {
                        var d = idprodClient.ProduitUtilisers.Where(pu => item.Id == pu.IdEmployee && idprodClient.Id == pu.IdProduitClient).FirstOrDefault();
                        if (d == null)
                        {
                            d = idprodClient.ProduitUtilisers.Where(pu => pu.Id == item.Idaffectation).FirstOrDefault();
                            d.IsDeleted = 1;
                            d.Datemodification = DateTime.Now;
                            context.ProduitUtilisers.Add(new ProduitUtiliser { IdProduitClient = idprodClient.Id, IdEmployee = item.Id,Login_u = item.Login,Password_u = item.Pass, IsDeleted = 0 });
                        }
                    }
                    else if (item.Idaffectation == 0 && !item.IsDeleted)
                    {
                        // add Employe if not exists
                        var d = idprodClient.ProduitUtilisers.Where(pu => item.Id == pu.IdEmployee && idprodClient.Id == pu.IdProduitClient && pu.IsDeleted == 0).FirstOrDefault();
                        if (d != null)
                        {

                        }
                        else
                        {
                            context.ProduitUtilisers.Add(new ProduitUtiliser { IdProduitClient = idprodClient.Id, IdEmployee = item.Id, Login_u = item.Login, Password_u = item.Pass, IsDeleted = 0 });
                        }

                    }
                    else if (item.Idaffectation > 0 && item.IsDeleted)
                    {
                        // Find  ProduitUtiliser and delete
                        var d = idprodClient.ProduitUtilisers.Where(pu => item.Idaffectation == pu.Id).FirstOrDefault();
                        if (d != null)
                        {
                            d.IsDeleted = 1;
                            d.Datemodification = DateTime.Now;

                            lblTextbox lbltxt = this.Controls.Find(item.Controlname, true).FirstOrDefault() as lblTextbox;
                            FpEmployee.Controls.Remove(lbltxt);
                        }

                    }
                }
                ProduitInfo tbx = this.Controls.Find("pd", true).FirstOrDefault() as ProduitInfo;
                var lblDep = (from x in tbx.pnlProp.Controls.OfType<lblProduit>()
                              select x
                         ).ToList();

                var prod = context.Produits.Find(idProd);
                foreach (var item in prod.ValeurProps)
                {
                    foreach (var lbl in lblDep)
                    {
                        if (int.Parse(lbl.LblID) == item.IdPropriete)
                        {
                            item.Valeur = lbl.TxtValue;
                        }
                    }
                }
                
                context.SaveChanges();
            }

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            lblTextbox user1 = new lblTextbox(idC, "emp");
            user1.Name = "userC" + userName;
            user1.LblText = "Nom :";
            user1.Lblid = "0";
            user1.LblAff = "0";
            user1.Margin = new Padding(0, 0, 0, 12);
            userName++;
            FpEmployee.Controls.Add(user1);
            FpEmployee.Height += 23;
            if (FpEmployee.Size == FpEmployee.MaximumSize)
            {
                FpEmployee.AutoScroll = true;

            }
        }

        private void btnAddProduit_Click(object sender, EventArgs e)
        {
            lblTextbox log = new lblTextbox(idC, "log");
            log.Name = "log" + userName;
            log.LblText = "Nom :";
            log.Lblid = "0";
            log.Margin = new Padding(0, 0, 0, 12);
            logName++;
            FpProduit.Controls.Add(log);
            FpProduit.Height += 23;
            if (FpProduit.Size == FpProduit.MaximumSize)
            {
                FpProduit.AutoScroll = true;

            }
        }

      
    }
}
