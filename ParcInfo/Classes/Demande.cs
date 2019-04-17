using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInfo
{
    public partial class Demande
    {
        public string Getstatut
        {
            get
            {
                if (Datedemande < DateTime.Now.AddDays(2) && Statut != "terminer") return "en retard";
                else return Statut;
            }
        }
    }
}
