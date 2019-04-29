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
                        GetDashAdmin();
                    }
                    else
                    {
                        GetDashUser();
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
        public void GetDashAdmin()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                lblDemEncours.Text = context.GetRequestCours.Count().ToString();
                lblDemEnRetard.Text = context.GetRequestRetard.Count().ToString();
                lblIntEnCours.Text = context.GetIntervEncours.Count().ToString();
                lblIntEnCours.Text = context.GetIntervenretard.Count().ToString();
                lblTotalDem.Text = context.GetRequestbyStatut().Count.ToString();
                lblTotalInterv.Text = context.GetInterventionBystatut().Count.ToString();
                var listOrder = new List<string> { "en retard", "en attente", "en cours", "terminer" };
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
        public void GetDashUser()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                lblDemEncours.Text = context.GetAssignedRequestCours.Count().ToString();
                lblDemEnRetard.Text = context.GetAssignedRequestRetard.Count().ToString();
                lblIntEnCours.Text = context.GeAssignedtIntervEncours.Count().ToString();
                lblIntEnCours.Text = context.GetAssignedIntervenretard.Count().ToString();
                lblTotalDem.Text = context.GetAssignedRequestbyStatut().Count.ToString();
                lblTotalInterv.Text = context.GetAssignedInterventionBystatut().Count.ToString();
                var listOrder = new List<string> { "en retard", "en attente", "en cours", "terminer" };

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                var dc = (from c in context.Demandes
                          join i in context.Interventions on c.Id equals i.IdDemande
                          select new {ad =  DbFunctions.DiffMinutes(c.Datedemande, i.DateIntervention) }).ToList();
                var d = dc.Sum(dx => dx.ad) / dc.Count;
                string varx = string.Format("{0}:{1}", (d / 60), (d % 60));
                MessageBox.Show(varx);
            }
          
        }
    }
}
