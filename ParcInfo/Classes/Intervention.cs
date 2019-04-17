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
                if (DateIntervention < DateTime.Now.AddDays(2) && Statut != "terminer") return "en retard";
                else return Statut;
            }
        }
    }
}
