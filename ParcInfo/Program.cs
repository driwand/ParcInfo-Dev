using ParcInfo.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcInfo
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


          // frmDefault.FrmDefault deffrm = new frmDefault.FrmDefault();
            Login deffrm = new Login();
            //using (var db = new ParcInformatiqueEntities())
            //{
            //    var par = db.ParametreParcinfoes.FirstOrDefault();
            //    if (par != null)
            //    {
            //        deffrm.pnlLogo.BringToFront();
            //        deffrm.pnlLogo.BackgroundImage = Methods.ByteArrayToImage(par.Logoapp);
            //        if (par.Iconapp != null)
            //        {
            //            System.Drawing.Bitmap bitmap = Methods.ByteArrayToImage(par.Iconapp) as System.Drawing.Bitmap;
            //            IntPtr ico = bitmap.GetHicon();
            //            Icon icon = Icon.FromHandle(ico);

            //            deffrm.Icon = icon;
            //        }
            //    }
            //}
            Application.Run(deffrm);
        }
    }
}
