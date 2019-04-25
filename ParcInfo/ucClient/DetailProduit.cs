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
                    {
                        int loc = 87;
                        lblUser.Text = p.Utilisateur.Nom;
                        loc += lblUser.Width;
                        lblDateAffectation.Location = new Point(loc, 20);
                        lblDateAff.Text = p.Dateaffectation.Value.ToShortDateString();
                        lblDateAff.Location = new Point(lblDateAffectation.Location.X + lblDateAffectation.Width, 20);
                        lblPrixVente.Location = new Point(lblDateAff.Location.X + lblDateAff.Width, 20);
                        lblPrix.Text = p.Prixvente.ToString();
                        lblPrix.Location = new Point(lblPrixVente.Location.X + lblPrixVente.Width, 20);
                    }
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
                    var e = context.Employees.Where(d=> d.IsDeleted == 0 && d.Id == idEmploye).FirstOrDefault();
                    var p = (from c in e.ProduitUtilisers
                             join pr in context.ProduitClients on c.IdProduitClient equals pr.Id
                             where idP == pr.Idproduit && c.IsDeleted == 0
                             select new { c, pr.Prixvente}).FirstOrDefault();
                    lblClient.Text = $"[{e.IdEmploye}]";
                    if (p.c.Utilisateur != null)
                    {
                        int loc = 87;
                        lblUser.Text = p.c.Utilisateur.Nom;
                        loc += lblUser.Width;
                        lblDateAffectation.Location = new Point(loc, 20);
                        lblDateAff.Text = p.c.Dateaffectation.Value.ToShortDateString();
                        lblDateAff.Location = new Point(lblDateAffectation.Location.X + lblDateAffectation.Width, 20);
                        lblPrixVente.Location = new Point(lblDateAff.Location.X + lblDateAff.Width, 20);
                        lblPrix.Text = p.Prixvente.ToString();
                        lblPrix.Location = new Point(lblPrixVente.Location.X + lblPrixVente.Width, 20);
                    }
                }
            }
        }

      
        private void ListProduitClient_Load(object sender, EventArgs e)
        {
            CreateControl("userC", userName, FpEmployee, 0, 0, 0);
            userName++;
            CreateControl("log", logName, FpProduit, 0, 0, idProd);
            logName++;

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
                    var ins = (from c in d.ProduitClients
                               from x in c.Installers1
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
                            lblTextbox user2 = new lblTextbox(idC,0, "emp");
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
                     tbx = this.Controls.Find("log1", true).FirstOrDefault() as lblTextbox;
                    if (ins != null && ins.Count > 0)
                    {
                        var logM = ins.FirstOrDefault();
                        tbx.TxtValue = logM.ProduitClient.Produit.CodeP;
                        tbx.Lblid = logM.Idhardsoft.ToString();
                        tbx.LblAff = logM.id.ToString();
                        foreach (var item in ins.Skip(1))
                        {
                            lblTextbox logx = new lblTextbox(idC,0, "log");
                            logx.Name = "log" + logName;
                            logx.LblText = "Nom :";
                            logx.TxtValue = item.ProduitClient.Produit.CodeP;
                            logx.Margin = new Padding(0, 0, 0, 12);
                            logx.LblAff = item.Idhardsoft.ToString();
                            logx.Lblid = item.id.ToString() ;
                            logName++;
                            FpProduit.Controls.Add(logx);
                        }
                    }

                }
                else
                {
                    // remove LBLTEXTBOX
                    lblTextbox tbx = this.Controls.Find("userC1", true).FirstOrDefault() as lblTextbox;
                    FpEmployee.Controls.Remove(tbx);
                    btnAddEmployee.Visible = false;
                    var em = context.Employees.Where(dx => dx.IsDeleted == 0 && dx.Id == idEmploye).FirstOrDefault();
                    var p = (from c in em.ProduitUtilisers
                             join pr in context.ProduitClients on c.IdProduitClient equals pr.Id
                             where idProd == pr.Idproduit && c.IdEmployee == idEmploye && c.IsDeleted == 0
                             select new { c, pr.Prixvente, c.Utilisateur }).FirstOrDefault();
                    loginPass lg = new loginPass();
                    //lg.LblEmp = em.Nom + " " + em.Prenom;
                    lg.TxtLogin = p.c.Login_u;
                    lg.TxtPass = p.c.Password_u;
                    FpEmployee.Controls.Add(lg);
                    lg.Name = "loginPass";
                    // Size
                    gpEmploye.Size = new Size(467, 127);
                    gpEmploye.Location = new Point(405, 112);
                    FpEmployee.Size = new Size(427, 96);
                    gpMaterielLogiciel.Size = new Size(467, 182);
                    gpMaterielLogiciel.Location = new Point(405, 245);

                   // FpEmployee.Size = new Size(473, 126);
                    btnAddProduit.Location = new Point(410, 144);
                }
              

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<LabelControl> listEmploye;
            List<LabelControl> listProduit;
            listEmploye = Methods.GetidList(FpEmployee);
            listProduit = Methods.GetidList(FpProduit);
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var idprodClient = context.ProduitClients.Where(d => d.Idproduit == idProd).FirstOrDefault();
                // Fiche ProduitClient
                if (listEmploye.Count > 0)
                {
                    //ADD EMPLOYEE
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
                                d.Modifierpar = GlobVars.currentUser;
                                context.ProduitUtilisers.Add(new ProduitUtiliser { IdProduitClient = idprodClient.Id, IdEmployee = item.Id, Login_u = item.Login, Password_u = item.Pass, IsDeleted = 0 });
                            }
                        }
                        else if (item.Idaffectation == 0 && !item.IsDeleted && item.Id > 0)
                        {
                            // add Employe if not exists
                            var d = idprodClient.ProduitUtilisers.Where(pu => item.Id == pu.IdEmployee && idprodClient.Id == pu.IdProduitClient && pu.IsDeleted == 0).FirstOrDefault();
                            if (d == null)
                            {
                                context.ProduitUtilisers.Add(new ProduitUtiliser
                                {
                                    IdProduitClient = idprodClient.Id,
                                    IdEmployee = item.Id,
                                    Login_u = item.Login,
                                    Password_u = item.Pass,
                                    IsDeleted = 0,
                                    Creepar = GlobVars.currentUser
                                });
                            }
                        }
                        else if (item.Idaffectation >= 0 && item.IsDeleted)
                        {
                            // Find  ProduitUtiliser and delete
                            var d = idprodClient.ProduitUtilisers.Where(pu => item.Idaffectation == pu.Id).FirstOrDefault();
                            if (d != null)
                            {
                                d.IsDeleted = 1;
                                d.Datemodification = DateTime.Now;
                                d.Modifierpar = GlobVars.currentUser;
                                lblTextbox lbltxt = this.Controls.Find(item.Controlname, true).FirstOrDefault() as lblTextbox;
                                FpEmployee.Controls.Remove(lbltxt);
                            }
                        }
                    }
                    // Logicial et Materiel
                    foreach (var item in listProduit)
                    {
                        if (item.Idaffectation > 0 && !item.IsDeleted)
                        {
                            var d = idprodClient.Installers1.Where(pu => item.Id == pu.Idhardsoft && pu.Idproduitclient == idprodClient.Id).FirstOrDefault();
                            if (d == null)
                            {
                                d = idprodClient.Installers1.Where(pu => pu.id == item.Idaffectation).FirstOrDefault();
                                d.IsDeleted = 1;
                                d.Datemodification = DateTime.Now;
                                d.Modifierpar = GlobVars.currentUser;
                                context.Installers.Add(new Installer { Idhardsoft = item.Id, Idproduitclient = idprodClient.Id, IsDeleted = 0, Creepar = GlobVars.currentUser });
                            }
                        }
                        else if (item.Idaffectation == 0 && !item.IsDeleted && item.Id > 0)
                        {
                            // add log if not exists
                            var dx = idprodClient.Installers1.Where(d => d.Idhardsoft == item.Id && d.Idproduitclient == idprodClient.Id && d.IsDeleted ==0).FirstOrDefault() ;
                            if (dx == null)
                            {
                                context.Installers.Add(new Installer { Idhardsoft = item.Id, Idproduitclient = idprodClient.Id,IsDeleted = 0,Creepar = GlobVars.currentUser });
                            }
                        }else if(item.Idaffectation >= 0 && item.IsDeleted)
                        {
                            // Delete
                            var d = idprodClient.Installers1.Where(pu => item.Idaffectation == pu.id).FirstOrDefault();
                            if (d != null)
                            {
                                d.IsDeleted = 1;
                                d.Datemodification = DateTime.Now;
                                d.Modifierpar = GlobVars.currentUser;
                                lblTextbox lbltxt = this.Controls.Find(item.Controlname, true).FirstOrDefault() as lblTextbox;
                                FpProduit.Controls.Remove(lbltxt);
                            }
                        }
                    }
                }
                // Fiche ProduitUtiliser
                else
                {
                    loginPass loginx = this.Controls.Find("loginPass", true).FirstOrDefault() as loginPass;
                    var emp = context.ProduitUtilisers.Where(d => d.IdEmployee == idEmploye && d.IsDeleted == 0).FirstOrDefault();
                    if (emp != null)
                    {
                        emp.Login_u = loginx.TxtLogin;
                        emp.Password_u = loginx.TxtPass;
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
            lblTextbox user1 = new lblTextbox(idC,0, "emp");
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
            lblTextbox log = new lblTextbox(idC,0, "log");
            log.Name = "log" + userName;
            log.LblText = "Nom :";
            log.Lblid = "0";
            log.LblAff = "0";
            log.Margin = new Padding(0, 0, 0, 12);
            logName++;
            FpProduit.Controls.Add(log);
            FpProduit.Height += 23;
            if (FpProduit.Size == FpProduit.MaximumSize)
            {
                FpProduit.AutoScroll = true;

            }
        }


        public void CreateControl(string name, int count, FlowLayoutPanel pnl, int idAff = 0, int lblId = 0, int idPr = 0, string txtvalue = "")
        {
            string nameParms;
            if (name == "userC")
            {
                nameParms = "emp";
            }
            else
            {
                nameParms = "log";
            }
            lblTextbox user1 = new lblTextbox(idC, idPr, nameParms);
            user1.Name = name + count;
            user1.LblText = "Nom :";
            user1.TxtValue = txtvalue;
            user1.LblAff = idAff.ToString();
            user1.Lblid = lblId.ToString();
            user1.Margin = new Padding(0, 0, 0, 12);
            pnl.Controls.Add(user1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var listEmploye = Methods.GetidList(FpEmployee);

            foreach (var item in listEmploye)
            {
                MessageBox.Show(item.Id.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<LabelControl> listProduit = new List<LabelControl>();
            listProduit = Methods.GetidList(FpEmployee);

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                foreach (var item in listProduit)
                {
                    MessageBox.Show(item.Controlname);
                }
            }
        }
    }
}
