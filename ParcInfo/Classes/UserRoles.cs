using ParcInfo.frmDefault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo.Classes
{
    public static class UserRoles
    {
        public static FrmDefault frm = new FrmDefault();
        //public static FrmDefault mt()
        //{
        //    using (var db = new ParcInformatiqueEntities())
        //    {
        //        var lsroles = db.GetListRoles(GlobVars.currentUser);
        //        var t = db.Utilisateurs.Find(GlobVars.currentUser).isAdmin;

        //        if (t == 0)
        //        {

        //            foreach (var v in lsroles)
        //            {
        //                foreach (var r in GetAllRoles())
        //                {
        //                    if (v.Nom == r.Key)
        //                    {
        //                        r.Value.Visible = true;
        //                    }
        //                    else
        //                        r.Value.Visible = false;
        //                }
        //            }
        //        }
        //    }
        //    return frm;
        //}
        

        
    }
}
