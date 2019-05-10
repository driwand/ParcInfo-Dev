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
using System.Data.Entity;

namespace ParcInfo.frmList
{
    public partial class Dashboard : UserControl
    {
        public string RoleI;
        public string RoleR;
        public Color GetColor(string statut)
        {
            Color color = Color.Transparent;
            switch (statut)
            {
                case "en attente":
                    color = Color.FromArgb(255, 192, 0);
                    break;
                case "en retard":
                    color = Color.FromArgb(238, 82, 83);
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
        public void GetRolesName()
        {

            var t = GlobVars.cuUser.RoleUtilisateurs1.Where(x => x.IdUtilisateur == GlobVars.cuUser.Id && x.IsDeleted == 0);
            foreach (var v in t)
                if (v.Nom.ToLower().Contains("Consulter".ToLower()) && v.Nom.ToLower().Contains("demandes".ToLower()) && v.IsDeleted != 1)
                    RoleR = v.Nom.ToLower();
            foreach (var v in t)
                if (v.Nom.ToLower().Contains("Consulter".ToLower()) && v.Nom.ToLower().Contains("interventions".ToLower()) && v.IsDeleted != 1)
                    RoleI = v.Nom.ToLower();
        }

        public Dashboard()
        {
            InitializeComponent();

            if (GlobVars.cuUser != null)
            {
                var u = GlobVars.cuUser;
                using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
                {
                    if (u.isAdmin == 1)
                    {
                        GetDashAdmin(true, true);
                        Dem(context.GetRequestbyStatut(), context.GetInterventionBystatut());

                    }
                    else
                    {
                        if (RoleI == "Consulter tous les interventions".ToLower() && RoleR == "Consulter tous les demandes".ToLower())
                        {
                            GetDashAdmin(true, true);

                            Dem(context.GetRequestbyStatut(), context.GetInterventionBystatut());
                        }
                        else
                        {
                            GetDashUser();
                            Dem(context.GetAssignedRequestbyStatut(), context.GetInterventionBystatut());
                        }
                           

                    }
                }
            }
        }

        public void CreateLblDash(string t, int id, string Code, string client, string date, string statut, Color color, Control c)
        {
            lblDashTablecs lbl = new lblDashTablecs();
            lbl.Name = t;
            lbl.ID = id.ToString();
            lbl.LblID = Code;
            lbl.LblClient = client;
            lbl.LblDate = date;
            lbl.LblStatut = statut;
            lbl.lblStatutColor = color;
            c.Controls.Add(lbl);
        }

        public void GetDashAdmin(bool hasallr,bool hasalli)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listOrder = new List<string> { "en retard", "en attente", "en cours", "terminer" };

                if (hasallr == true)
                {
                    //demande
                    lblDemEncours.Text = context.GetRequestCours.Count().ToString();
                    lblDemEnRetard.Text = context.GetRequestRetard.Count().ToString();
                    lblTotalDem.Text = context.GetRequestbyStatut().Count.ToString();
                    var ls = (from c in context.GetRequestbyStatut()
                              select new
                              {
                                  c.IdReq,
                                  c.Id,
                                  c.Employee.Client.Nom,
                                  c.Datedemande,
                                  c.Getstatut,
                                  color = GetColor(c.Getstatut)
                              }).OrderBy(i => listOrder.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).Take(5).ToList();
                    foreach (var item in ls)
                    {
                        CreateLblDash("dem", item.Id, item.IdReq, item.Nom, item.Datedemande.ToString(), item.Getstatut, item.color, pnlDemande);
                    }
                }

                if (hasalli == true)
                {
                    //interevention
                    lblIntEnCours.Text = context.GetIntervEncours.Count().ToString();
                    lblIntEnCours.Text = context.GetIntervenretard.Count().ToString();
                    lblTotalInterv.Text = context.GetInterventionBystatut().Count.ToString();

                    var lsx = (from c in context.GetInterventionBystatut()
                               select new
                               {
                                   c.IdIntrv,
                                   c.Id,
                                   c.Client.Nom,
                                   c.DateIntervention,
                                   c.Getstatut,
                                   color = GetColor(c.Getstatut)
                               }).OrderBy(i => listOrder.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).Take(5).ToList();

                    foreach (var item in lsx)
                    {
                        CreateLblDash("int", item.Id, item.IdIntrv, item.Nom, item.DateIntervention.ToString(), item.Getstatut, item.color, pnlIntervention);
                    }
                }
           

            }
        }
        public void GetDashUser()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var listOrder = new List<string> { "en retard", "en attente", "en cours", "terminer" };

                bool hasallr = false;
                bool hasalli = false;

                if (RoleR == "Consulter tous les demandes".ToLower())
                    hasallr = true;
                if (RoleI == "Consulter tous les interventions".ToLower())
                    hasalli = true;

                if (hasalli == true)
                    GetDashAdmin(false, true);
                if (hasallr == true)
                    GetDashAdmin(true, false);

                if (hasallr == false)
                {
                    //demande
                    lblDemEncours.Text = context.GetAssignedRequestCours.Count().ToString();
                    lblDemEnRetard.Text = context.GetAssignedRequestRetard.Count().ToString();
                    lblTotalDem.Text = context.GetAssignedRequestbyStatut().Count.ToString();

                    var ls = (from c in context.GetAssignedRequestbyStatut()
                              select new
                              {
                                  c.IdReq,
                                  c.Id,
                                  c.Employee.Client.Nom,
                                  c.Datedemande,
                                  c.Getstatut,
                                  color = GetColor(c.Getstatut)
                              }).OrderBy(i => listOrder.IndexOf(i.Getstatut)).ThenBy(d => d.Datedemande).Take(5).ToList();
                    foreach (var item in ls)
                    {
                        CreateLblDash("dem", item.Id, item.IdReq, item.Nom, item.Datedemande.ToString(), item.Getstatut, item.color, pnlDemande);
                    }

                }
                if (hasalli == false)
                {
                    //intervention
                    lblIntEnCours.Text = context.GeAssignedtIntervEncours.Count().ToString();
                    lblIntEnCours.Text = context.GetAssignedIntervenretard.Count().ToString();
                    lblTotalInterv.Text = context.GetAssignedInterventionBystatut().Count.ToString();

                    var lsx = (from c in context.GetAssignedInterventionBystatut()
                               select new
                               {
                                   c.IdIntrv,
                                   c.Id,
                                   c.Client.Nom,
                                   c.DateIntervention,
                                   c.Getstatut,
                                   color = GetColor(c.Getstatut)
                               }).OrderBy(i => listOrder.IndexOf(i.Getstatut)).ThenBy(d => d.DateIntervention).Take(5).ToList();
                    foreach (var item in lsx)
                    {
                        CreateLblDash("int", item.Id, item.IdIntrv, item.Nom, item.DateIntervention.ToString(), item.Getstatut, item.color, pnlIntervention);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = DateTime.Now;
            var d2 = DateTime.Now.AddDays(1);

            MessageBox.Show((d2 - d).TotalMinutes.ToString());
         
        }
       
        public string GetNum(int n)
        {
            return n < 9 ? "0" : "";

        }
        public void Dem(ICollection<Demande> listD, ICollection<Intervention> listI)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var dc = (from c in context.Demandes
                          join i in context.Interventions on c.Id equals i.IdDemande
                          select new
                          { ad = DbFunctions.DiffMinutes(c.Datedemande, i.DateIntervention) }).ToList();
               // var listDx = dc.AsEnumerable().AsQueryable();
               // var ds = dc.Select(c => new {  ad = (c.DateIntervention.Value - c.Datedemande.Value).TotalMinutes }).ToList();
               
              //ad = DbFunctions.DiffMinutes(c.Datedemande, i.DateIntervention)
                if (dc.Count > 0)
                {
                    var d = dc.Sum(dx => dx.ad) / dc.Count;

                    var days = GetNum((int)(d / 1440));
                    var hours = GetNum((int)(d / 60));
                    var min = GetNum((int)(d % 60));
                    string varx = string.Format("{0}:{1}:{2}",(days + (d / 1440)), (hours + (d / 60)), (min + (d % 60)));
                    lbltest.Text = varx.ToString();
                }
                else
                {
                    lbltest.Text = "00:00:00";
                }

            }
        }
    }
}
