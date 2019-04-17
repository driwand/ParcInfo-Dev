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
                var retarddate = DateTime.Now.AddDays(2);
                return GetInterventions.Where(x => x.Statut == "en cours" && x.DateIntervention < retarddate);
                    }
        }
        public IQueryable<Intervention> GetIntervEncours
        {
            get
            {
                var retarddate = DateTime.Now.AddDays(2);
                return GetInterventions.Where(x => x.Statut == "en cours" && x.DateIntervention > retarddate);
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
    }
}
