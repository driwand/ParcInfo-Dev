using System;
using System.Collections.Generic;
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
                return Interventions.Where(x => x.IsDeleted ==0);
            }
        }
        public IQueryable<Intervention> GetIntervenretard
        {
            get {
                var retarddate = DateTime.Now;
                return GetInterventions.Where(x => x.Statut == "en cours" && DbFunctions.AddDays(x.DateIntervention,2) < retarddate);
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
        public ICollection<Intervention> GetInterventionBystatut(Label lbl, string statut = "")
        {
            IQueryable<Intervention> list =  GetInterventions;
            switch (statut)
            {
                case "en cours":
                    list = GetIntervEncours;
                    lbl.BackColor = Color.FromArgb(250, 130, 49); 
                    break;
                case "en retard":
                    list = GetIntervenretard;
                    lbl.BackColor = Color.FromArgb(252, 92, 101);
                    break;
                case "terminer":
                    list = GetIntervtermine;
                    lbl.BackColor = Color.FromArgb(32, 191, 107);
                    break;
                    
            }
            lbl.Text = list.Count().ToString();
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

        public IQueryable<Demande> GetRequestRetard
        {
            get
            {
                var retarddate = DateTime.Now;
                return GetRequests.Where(x => x.Statut == "en cours" && DbFunctions.AddDays(x.Datedemande, 2) < retarddate);
            }
        }
        public IQueryable<Demande> GetRequestCours
        {
            get
            {
                var retarddate = DateTime.Now;
                return GetRequests.Where(x => x.Statut == "en cours" && DbFunctions.AddDays(x.Datedemande,2) > retarddate);
            }
        }

        public IQueryable<Demande> GetRequestAttent
        {
            get
            {
                return GetRequests.Where(x => x.Statut == "en attent");
            }
        }

        public IQueryable<Demande> GetRequestTerminer
        {
            get
            {
                return GetRequests.Where(x => x.Statut == "terminer");
            }
        }
        public ICollection<Demande> GetRequestbyStatut(Label lbl, string statut = "",int idEmp= 0)
        {
            IQueryable<Demande> list = GetRequests;
          
            switch (statut)
            {
                case "en cours":
                        list = GetRequestCours;
                   
                    lbl.BackColor = Color.FromArgb(250, 130, 49);
                    break;
                case "en retard":
                    list = GetRequestRetard;
                    lbl.BackColor = Color.FromArgb(252, 92, 101);
                    break;
                case "terminer":
                    list = GetRequestTerminer;
                    lbl.BackColor = Color.FromArgb(32, 191, 107);
                    break;

            }
            if (idEmp > 0)
            {
                return list.ToList().Where(c => c.IdEmployee == idEmp).ToList();
            }
            lbl.Text = list.Count().ToString();
            return list.ToList();
        }
    }
}
