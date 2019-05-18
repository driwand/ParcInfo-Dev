using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInfo
{
    public partial class Intervention
    {
        public string Getstatut
        {
            get
            {
                if (DateIntervention.Value.AddDays(2) < DateTime.Now && Statut != "terminer") return "en retard";
                else return Statut;
            }
        }
        public string IdIntrv
        {
            get
            {
                return "INV-" + Methods.Splitdate(DateIntervention.ToString()) + Id;
            }
        }
        public string IdIntervINT
        {
            get
            {
                return  Methods.Splitdate(DateIntervention.ToString()) + Id;
            }
        }
        public int? IdSource
        {
            get
            {
                if (IdDemande != 0)
                    return IdDemande;
                else
                    return Idclient;
            }
        }
    }

    public partial class Demande
    {
        public string Getstatut
        {
            get
            {
                int delay = 0;
                using (var db = new ParcInformatiqueEntities())
                {
                    delay = (int)db.ParametreParcinfoes.FirstOrDefault().Reatrddemande;
                }
                if (Datedemande.Value.AddDays(delay) < DateTime.Now && Statut != "terminer" && Statut != "en attente") return "en retard";
                else return Statut;
            }
        }
        public string IdReq
        {
            get
            {
                return "DEM-" + Methods.Splitdate(Datedemande.ToString()) + Id;
            }
        }
    }

    public partial class Client
    {
        public string IdCLient
        {
            get
            {
                return "CLI-" + Methods.Splitdate(Datecreation.ToString()) + id;
            }
        }

        public int? GetTotalHours
        {
            get
            {
                return Interventions
                    .Where(d => d.DateIntervention.Value.Year == DateTime.Now.Year)
                    .Where(d => d.Statut == "terminer")
                    .GroupBy(o => o.DateIntervention.Value.Month)
                    .Select(s => s.Sum(o => o.Duree)).FirstOrDefault();


            }
        }
    }
    public partial class Employee
    {
        public string IdEmploye
        {
            get
            {
                return "EMP-" + Methods.Splitdate(Datecreation.ToString()) + Id;
            }
        }
    }
    public partial class Produit
    {
        public string CodeP
        {
            get
            {
                return $"PRT{Methods.Splitdate(Datefabrication.ToString()) + id}";
            }
        }
    }
    public partial class Utilisateur
    {
        public string IdUser
        {
            get
            {
                return "UTI-" + Methods.Splitdate(Datecreation.ToString()) + Id;
            }
        }
    }

    public partial class ProduitClient
    {
        public string CodeProduit
        {
            get
            {
                return $"PRT{Methods.Splitdate(Produit.Datecreation.ToString()) + Produit.id}";
            }
        }
        public string LastEdit
        {
            get
            {
                return Produit.ProduitClients.Last().Creepar.ToString();
            }
        }
    }
    public partial class Facture
    {
        public string IdFacture
        {
            get
            {
                return "Fact-" + Anne + Mois +Id;
            }
        }
    }

}
