using ParcInfo.Classes;
using ParcInfo.frmDefault;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public  class AffectC
    {
        public int IdProduit { get; set; }
        public float Prix { get; set; }
    }
    public static class GlobVars
    {
        public static int selectedEmploye;
        public static int selectedClient;
        public static string BtnName;
        public static string NomUtilisateur;
        public static int idUtilisateur;

        public static UserControl frmBack;
        public static UserControl frmBack2;
        public static FrmDefault frmindex;
        public static int currentUser = 13;

   
      
    }
}
