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

        #region All Interventions

        public IQueryable<Intervention> GetInterventions
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            select i);
                return Interventions.Where(x => x.IsDeleted == 0);
            }
        }
        public IQueryable<Intervention> GetInterventionsDeleted
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            select i);
                return inte.Where(x => x.IsDeleted == 1);
            }
        }
        public IQueryable<Intervention> GetIntervenretard
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            select i);
                var retarddate = DateTime.Now;
                return inte.Where(x => x.Statut == "en cours" && x.IsDeleted == 0 && DbFunctions.AddDays(x.DateIntervention, 2) < retarddate);
            }
        }
        public IQueryable<Intervention> GetIntervEncours
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            select i);
                var retarddate = DateTime.Now;
                return inte.Where(x => x.Statut == "en cours" && x.IsDeleted == 0 && DbFunctions.AddDays(x.DateIntervention, 2) > retarddate);
            }
        }
        public IQueryable<Intervention> GetIntervtermine
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            select i);
                return inte.Where(x => x.Statut == "terminer" && x.IsDeleted == 0);
            }
        }

        public ICollection<Intervention> GetInterventionBystatut(Label[] lbl = null, string statut = "", bool isdeleted = false)
        {
            IQueryable<Intervention> list = GetInterventions;

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
        #endregion

        #region Assigned Interevetions
        public IQueryable<Intervention> GetAssignedInterventions
        {
            get
            {
                var inte = (from i in Interventions
                          join c in Clients on i.Idclient equals c.id
                          where c.IsDeleted == 0
                          select i);
                return inte.Where(x => x.Idutilisateur == GlobVars.cuUser.Id && x.IsDeleted == 0);
            }
        }
        public IQueryable<Intervention> GetAssignedInterventionsDeleted
        {
            get
            {
                var inte = (from i in Interventions
                          join c in Clients on i.Idclient equals c.id
                          where c.IsDeleted == 0
                          select i);
                return inte.Where(x => x.Idutilisateur == GlobVars.cuUser.Id && x.IsDeleted == 1);
            }
        }
        public IQueryable<Intervention> GetAssignedIntervenretard
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            where c.IsDeleted == 0
                            select i);
                var retarddate = DateTime.Now;
                return inte.Where(x => x.Idutilisateur == GlobVars.cuUser.Id && x.IsDeleted == 0 && x.Statut == "en cours" && DbFunctions.AddDays(x.DateIntervention, 2) < retarddate);
            }
        }
        public IQueryable<Intervention> GeAssignedtIntervEncours
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            where c.IsDeleted == 0
                            select i);
                var retarddate = DateTime.Now;
                return inte.Where(x => x.Idutilisateur == GlobVars.cuUser.Id && x.IsDeleted == 0 && x.Statut == "en cours" && DbFunctions.AddDays(x.DateIntervention, 2) > retarddate);
            }
        }
        public IQueryable<Intervention> GetAssignedIntervtermine
        {
            get
            {
                var inte = (from i in Interventions
                            join c in Clients on i.Idclient equals c.id
                            where c.IsDeleted == 0
                            select i);
                return inte.Where(x => x.Idutilisateur == GlobVars.cuUser.Id && x.Statut == "terminer" && x.IsDeleted == 0);
            }
        }

        public ICollection<Intervention> GetAssignedInterventionBystatut(Label[] lbl = null, string statut = "", bool isdeleted = false)
        {
            IQueryable<Intervention> list = GetAssignedInterventions;

            if (isdeleted == true)
                list = GetAssignedInterventionsDeleted;

            switch (statut)
            {
                case "en cours":
                    list = GeAssignedtIntervEncours;
                    lbl[0].BackColor = Color.FromArgb(241, 196, 15);
                    lbl[1].ForeColor = Color.FromArgb(241, 196, 15);
                    break;
                case "en retard":
                    list = GetAssignedIntervenretard;
                    lbl[0].BackColor = Color.FromArgb(252, 92, 101);
                    lbl[1].ForeColor = Color.FromArgb(252, 92, 101);
                    break;
                case "terminer":
                    list = GetAssignedIntervtermine;
                    lbl[0].BackColor = Color.FromArgb(32, 191, 107);
                    lbl[1].ForeColor = Color.FromArgb(32, 191, 107);
                    break;
                case "":
                    list = GetAssignedInterventions;
                    break;

            }
            if (lbl != null)
                lbl[0].Text = list.Count().ToString();

            return list.ToList();
        }

        #endregion

        #region All Request
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
                int delay = (int)ParametreParcinfoes.FirstOrDefault().Reatrddemande;
                return GetRequests.Where(x => x.Statut != "terminer" && x.Statut != "en attente" && DbFunctions.AddDays(x.Datedemande, delay) < retarddate);
            }
        }
        public IQueryable<Demande> GetRequestCours
        {
            get
            {
                var retarddate = DateTime.Now;
                int delay = (int)ParametreParcinfoes.FirstOrDefault().Reatrddemande;
                return GetRequests.Where(x => x.Statut != "terminer" && x.Statut != "en attente" && DbFunctions.AddDays(x.Datedemande, delay) > retarddate);
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
        public ICollection<Demande> GetRequestbyStatut(Label[] lbl = null, string statut = "", int idEmp = 0, bool isdeleted = false)
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

        #endregion

        #region Assigned Request

        public IQueryable<Demande> GetAssignedRequests
        {
            get
            {
                var v = (from d in Demandes
                         join em in Employees on d.IdEmployee equals em.Id
                         join c in Clients on em.Idclient equals c.id
                         join af in AffectationClients on c.id equals af.Idclient
                         where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 0
                         select d);

                return v.Where(x => x.IsDeleted == 0);
            }
        }

        public IQueryable<Demande> GetAssignedRequestsDeleted
        {
            get
            {
                var v = (from d in Demandes
                         join em in Employees on d.IdEmployee equals em.Id
                         join c in Clients on em.Idclient equals c.id
                         join af in AffectationClients on c.id equals af.Idclient
                         where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 0
                         select d);
                return v.Where(x => x.IsDeleted == 1);
            }
        }

        public IQueryable<Demande> GetAssignedRequestRetard
        {
            get
            {
                var v = (from d in Demandes
                         join em in Employees on d.IdEmployee equals em.Id
                         join c in Clients on em.Idclient equals c.id
                         join af in AffectationClients on c.id equals af.Idclient
                         where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 0
                         select d);

                var retarddate = DateTime.Now;
                int delay = (int)ParametreParcinfoes.FirstOrDefault().Reatrddemande;
                return GetAssignedRequests.Where(x => x.Statut != "terminer" && x.Statut != "en attente" && DbFunctions.AddDays(x.Datedemande, delay) < retarddate);
            }
        }
        public IQueryable<Demande> GetAssignedRequestCours
        {
            get
            {
                var v = (from d in Demandes
                         join em in Employees on d.IdEmployee equals em.Id
                         join c in Clients on em.Idclient equals c.id
                         join af in AffectationClients on c.id equals af.Idclient
                         where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 0
                         select d);

                var retarddate = DateTime.Now;
                int delay = (int)ParametreParcinfoes.FirstOrDefault().Reatrddemande;
                return GetAssignedRequests.Where(x => x.Statut != "terminer" && x.Statut != "en attente" && DbFunctions.AddDays(x.Datedemande, delay) > retarddate);
            }
        }

        public IQueryable<Demande> GetAssignedRequestAttent
        {
            get
            {
                var v = (from d in Demandes
                         join em in Employees on d.IdEmployee equals em.Id
                         join c in Clients on em.Idclient equals c.id
                         join af in AffectationClients on c.id equals af.Idclient
                         where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 0
                         select d);

                return GetAssignedRequests.Where(x => x.Statut == "en attente");
            }
        }

        public IQueryable<Demande> GetAssignedRequestTerminer
        {
            get
            {
                var v = (from d in Demandes
                         join em in Employees on d.IdEmployee equals em.Id
                         join c in Clients on em.Idclient equals c.id
                         join af in AffectationClients on c.id equals af.Idclient
                         where af.Idutilisateur == GlobVars.cuUser.Id && c.IsDeleted == 0
                         select d);

                return GetAssignedRequests.Where(x => x.Statut == "terminer");
            }
        }
        public ICollection<Demande> GetAssignedRequestbyStatut(Label[] lbl = null, string statut = "", int idEmp = 0, bool isdeleted = false)
        {
            IQueryable<Demande> list = GetAssignedRequests;

            if (isdeleted == true)
                list = GetAssignedRequestsDeleted;

            switch (statut)
            {
                case "en attente":
                    list = GetAssignedRequestAttent;
                    lbl[0].BackColor = Color.FromArgb(250, 130, 49);
                    lbl[1].ForeColor = Color.FromArgb(250, 130, 49);
                    break;
                case "en cours":
                    list = GetAssignedRequestCours;
                    lbl[0].BackColor = Color.FromArgb(241, 196, 15);
                    lbl[1].ForeColor = Color.FromArgb(241, 196, 15);
                    break;
                case "en retard":
                    list = GetAssignedRequestRetard;
                    lbl[0].BackColor = Color.FromArgb(252, 92, 101);
                    lbl[1].ForeColor = Color.FromArgb(252, 92, 101);
                    break;
                case "terminer":
                    list = GetAssignedRequestTerminer;
                    lbl[0].BackColor = Color.FromArgb(32, 191, 107);
                    lbl[1].ForeColor = Color.FromArgb(32, 191, 107);
                    break;
                case "":
                    list = GetAssignedRequests;
                    break;

            }
            if (idEmp > 0)
                list = list.Where(c => c.IdEmployee == idEmp);

            if (lbl != null)
                lbl[0].Text = list.Count().ToString();

            return list.ToList();
        }

        #endregion

        #region Roles

        public ICollection<RoleUtilisateur> GetListRoles(int idUser)
        {
            IQueryable<RoleUtilisateur> listR = RoleUtilisateurs.Where(d => d.IsDeleted == 0);

            return listR.Where(id => id.IdUtilisateur == idUser).ToList();
        }

        #endregion
    }
}
