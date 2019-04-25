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
    
    public partial class frmAffecter : Form
    {
        int prixName = 1;
        int idC;
        lblTextbox lblx;
        loginPass lg;
        int idprd = 0;
        
        public frmAffecter()
        {
            InitializeComponent();
        }
        public frmAffecter(lblTextbox tbx, int id)
        {
            InitializeComponent();
            lblx = tbx;
             lg = new loginPass();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
               var e= context.Employees.Find(id);
                this.Text = $"{e.Nom} {e.Prenom}";
                this.Size = new Size(385, 180);
                btnSave.Location = new Point(239, 105);
                pnlCntrl.Size = new Size(344, 81);
                //   prop.Margin = new Padding(0, 0, 0, 12);
                prixName++;
                pnlCntrl.Controls.Add(lg);
            }
         
        }
        public frmAffecter(int idClient, List<int> prod)
        {
            InitializeComponent();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                if (prod.Count > 0 && prod != null)
                {
                    idC = idClient;
                    var listprod = context.Produits.ToList();
                    foreach (var item in prod)
                    {
                        this.Text = "produit";
                        var p = listprod.Where(i => item == i.id).FirstOrDefault();
                        prixVente prop = new prixVente();
                        prop.LblCode = p.CodeP;
                        prop.Lblid = item.ToString();
                        // prop.Margin = new Padding(0, 0, 0, 12);
                        prixName++;
                        pnlCntrl.Controls.Add(prop);
                        pnlCntrl.Height += 23;

                        if (pnlCntrl.Size == pnlCntrl.MaximumSize)
                        {
                            pnlCntrl.AutoScroll = true;
                        }
                    }
                }
            }
        }
        public frmAffecter(int Idproduct)
        {
            InitializeComponent();
            using (var context = new ParcInformatiqueEntities())
            {
                var prodinfo = context.ProduitClients.Find(Idproduct);
                prixVente prop = new prixVente();
                prop.LblCode = prodinfo.CodeProduit;
                prop.Lblid = Idproduct.ToString();
                prop.Name = "txtproductid";
                pnlCntrl.Controls.Add(prop);

                prixVente tx = pnlCntrl.Controls.Find("txtproductid", true).FirstOrDefault() as prixVente;
                tx.TxtValue = prodinfo.Produit.Prix.ToString();
                idprd = Idproduct;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lg != null)
            {
                if (lg.TxtLogin != "" && lg.TxtPass != "")
                {
                    lblx.LblUser = lg.TxtLogin;
                    lblx.LblPass = lg.TxtPass;
                    this.Close();
                }
                else
                {
                    lg.Focus();
                }
            
            }else if(idprd > 0){
                using (var context = new ParcInformatiqueEntities())
                {
                    var produicli = context.ProduitClients.Find(idprd);
                    prixVente tx = pnlCntrl.Controls.Find("txtproductid", true).FirstOrDefault() as prixVente;
                    produicli.Prixvente = float.Parse(tx.TxtValue);
                    context.SaveChanges();
                }
            }
            else
            {
                List<LabelControl> list;
                list = Methods.GetidList(pnlCntrl);
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    foreach (var item in list)
                    {
                        context.ProduitClients.Add(new ProduitClient { Idproduit = item.Id,
                            Idclient = idC, Prixvente = float.Parse(item.Value),
                            Dateaffectation = DateTime.Now,
                            Creepar = GlobVars.currentUser,
                            IsDeleted = 0 });
                    }
                    context.SaveChanges();
                    this.Close();
                }
            }
         

        }
    }
}