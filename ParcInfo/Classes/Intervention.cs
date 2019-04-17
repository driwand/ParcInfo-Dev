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
    }
}
