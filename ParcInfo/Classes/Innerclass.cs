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
    public partial class Client
    {
        public string IdCLient
        {
            get
            {
                return "CLI-" + Methods.Splitdate(Datecreation.ToString()) + id;
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
    }
}
