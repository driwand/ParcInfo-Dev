﻿using ParcInfo.Classes;
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
}
