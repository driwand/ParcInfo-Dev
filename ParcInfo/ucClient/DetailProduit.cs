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
                    lblClient.Text = $"[{c.IdCLient}]";
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
                var pu = (from c in d.ProduitClients
                          from x in c.ProduitUtilisers
                          where x.IsDeleted == 0
                          select x).ToList();
          
                lblTextbox tbx = this.Controls.Find("userC1", true).FirstOrDefault() as lblTextbox ;

                if (pu != null && pu.Count > 0)
                {
                    var user = pu.FirstOrDefault();
                    tbx.TxtValue = user.Employee.Nom + " " + user.Employee.Prenom;
                    tbx.Lblid = user.IdEmployee.ToString();
                    tbx.LblAff = user.Id.ToString();
                    foreach (var item in pu.Skip(1))
                    {
                        //first lblTexbox to fill user
                        lblTextbox user2 = new lblTextbox(idC,"emp");
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<LabelControl> listEmploye = new List<LabelControl>();
            //frmLoginPass frm = new frmLoginPass();
            //frm.ShowDialog();
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
                            context.ProduitUtilisers.Add(new ProduitUtiliser { IdProduitClient = idprodClient.Id, IdEmployee = item.Id, IsDeleted = 0 });
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
                            context.ProduitUtilisers.Add(new ProduitUtiliser { IdProduitClient = idprodClient.Id, IdEmployee = item.Id, IsDeleted = 0 });
                        }

                    }
                    else if (item.Idaffectation > 0 && item.IsDeleted)
                    {
                        // Find  ProduitUtiliser and delete
                        var d = idprodClient.ProduitUtilisers.Where(pu => item.Idaffectation == pu.Id).FirstOrDefault();
                        if (d != null)
                        {
                            d.IsDeleted = 1;
                            d.Dateaffectation = DateTime.Now;
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
