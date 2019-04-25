using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public partial class ParcInformatiqueEntities
    {
        public IQueryable<Intervention> GetInterventions
        {
            get
            {
                return Interventions.Where(x => x.IsDeleted == 0);
            }
        }
        public IQueryable<Intervention> GetInterventionsDeleted
        {
            get
            {
                return Interventions.Where(x => x.IsDeleted == 1);
            }
        }
        public IQueryable<Intervention> GetIntervenretard
        {
            get {
                var retarddate = DateTime.Now;
                return GetInterventions.Where(x => x.Statut == "en cours"  && DbFunctions.AddDays(x.DateIntervention,2) < retarddate);
            }
        }
        public IQueryable<Intervention> GetIntervEncours
        {
            get
            {
                var retarddate = DateTime.Now;
                return GetInterventions.Where(x => x.Statut == "en cours" && DbFunctions.AddDays(x.DateIntervention, 2) > retarddate);
            }
        }
        public IQueryable<Intervention> GetIntervtermine
        {
            get
            {
                return GetInterventions.Where(x => x.Statut == "terminer");
            }
        }

        public ICollection<Intervention> GetInterventionBystatut(Label[] lbl=null, string statut = "",bool isdeleted=false)
        {
            IQueryable<Intervention> list =  GetInterventions;

            if (isdeleted == true)
                list = GetInterventionsDeleted;

            switch (statut)
            {
                case "en cours":
                    list = GetIntervEncours;
                    lbl[0].BackColor = Color.FromArgb(241, 196, 15);
                    lbl[1].ForeColor = Color.FromArgb(241, 196, 15);
                    break;
                case "en retard":
                    list = GetIntervenretard;
                    lbl[0].BackColor = Color.FromArgb(252, 92, 101);
                    lbl[1].ForeColor = Color.FromArgb(252, 92, 101);
                    break;
                case "terminer":
                    list = GetIntervtermine;
                    lbl[0].BackColor = Color.FromArgb(32, 191, 107);
                    lbl[1].ForeColor = Color.FromArgb(32, 191, 107);
                    break;
                case "":
                    list = GetInterventions;
                    break;
                    
            }
            if (lbl != null)
                lbl[0].Text = list.Count().ToString();

            return list.ToList();
        }


        //Demandes
        public IQueryable<Demande> GetRequests
        {
            get
            {
                return Demandes.Where(x => x.IsDeleted == 0);
            }
        }

        public IQueryable<Demande> GetRequestsDeleted
        {
            get
            {
                return Demandes.Where(x => x.IsDeleted == 1);
            }
        }

        public IQueryable<Demande> GetRequestRetard
        {
            get
            {
                var retarddate = DateTime.Now;
                return GetRequests.Where(x => x.Statut != "terminer" && x.Statut != "en attente" && DbFunctions.AddDays(x.Datedemande, 2) < retarddate);
            }
        }
        public IQueryable<Demande> GetRequestCours
        {
            get
            {
                var retarddate = DateTime.Now;
                return GetRequests.Where(x => x.Statut != "terminer" && x.Statut!="en attente" && DbFunctions.AddDays(x.Datedemande, 2) > retarddate);
            }
        }

        public IQueryable<Demande> GetRequestAttent
        {
            get
            {
                return GetRequests.Where(x => x.Statut == "en attente");
            }
        }

        public IQueryable<Demande> GetRequestTerminer
        {
            get
            {
                return GetRequests.Where(x => x.Statut == "terminer");
            }
        }
        public ICollection<Demande> GetRequestbyStatut(Label[] lbl=null, string statut = "",int idEmp= 0,bool isdeleted = false)
        {
            IQueryable<Demande> list = GetRequests;

            if (isdeleted == true)
                list = GetRequestsDeleted;

            switch (statut)
            {
                case "en attente":
                    list = GetRequestAttent;
                    lbl[0].BackColor = Color.FromArgb(250, 130, 49);
                    lbl[1].ForeColor = Color.FromArgb(250, 130, 49);
                    break;
                case "en cours":
                    list = GetRequestCours;
                    lbl[0].BackColor = Color.FromArgb(241, 196, 15);
                    lbl[1].ForeColor = Color.FromArgb(241, 196, 15);
                    break;
                case "en retard":
                    list = GetRequestRetard;
                    lbl[0].BackColor = Color.FromArgb(252, 92, 101);
                    lbl[1].ForeColor = Color.FromArgb(252, 92, 101);
                    break;
                case "terminer":
                    list = GetRequestTerminer;
                    lbl[0].BackColor = Color.FromArgb(32, 191, 107);
                    lbl[1].ForeColor = Color.FromArgb(32, 191, 107);
                    break;
                case "":
                    list = GetRequests;
                    break;

            }
            if (idEmp > 0)
                list = list.Where(c => c.IdEmployee == idEmp);
            
            if (lbl != null)
                lbl[0].Text = list.Count().ToString();

            return list.ToList();
        }
    }
}
