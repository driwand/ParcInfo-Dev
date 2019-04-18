using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcInfo
{
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
}
