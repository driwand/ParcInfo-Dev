using ParcInfo.Classes;
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
                if (Datedemande.Value.AddDays(2) < DateTime.Now && Statut != "terminer") return "en retard";
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
}
