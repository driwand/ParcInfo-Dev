using ParcInfo.Classes;
using ParcInfo.frmDefault;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    public static class GlobVars
    {
        public static FrmDefault frmindex;
        public static Utilisateur cuUser;
        public static frmLogin cuLogin;

        public static List<Control> lsback = new List<Control>();
    }
}
