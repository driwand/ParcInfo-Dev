
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using ParcInfo.Properties;

namespace ParcInfo.Classes
{

   

    public static class ControlsClass
    {


        public static bool isCollapsed = true;
        public static bool IsOpen = false;
        public static Panel isPanel;
        public static Timer isTimer;
        public static Button isbtn;



        #region changeBorderStyle
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
       );


        public static void CreateRadiusBorder(Panel panel)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 5, 5));
        }

        public static void CreateRadiusBorder(Panel panel, int width, int height)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, width, height));
        }
        #endregion


        /// <summary>
        /// Making DropDownMenu from panel
        /// </summary>
        /// <param name="timer"></param>
        /// <param name="btn"></param>
        /// <param name="panel"></param>
        public static void OpenMenu(Timer timer, Button btn, Panel panel)
        {
            var allbtnsvisible = panel.Controls.OfType<Button>().Where(x => x.Visible);
            if(allbtnsvisible.Count() > 1)
            {
                var pheight = allbtnsvisible.Sum(y => y.Height);
                btn.Image = Resources.arrowDown1;
                panel.Height += 4;
                if (panel.Height >= pheight)
                {
                    timer.Stop();
                    IsOpen = true;
                    isPanel = panel;
                    isTimer = timer;
                    isbtn = btn;
                }
            }
            else
            {
                timer.Stop();
            }
        }
        public static void CloseMenu(Timer timer, Button btn, Panel panel)
        {
            btn.Image = Resources.arrowLeft1;
            panel.Height -= 4;
            var mheight = panel.Controls.OfType<Button>().FirstOrDefault().Height;
            if (panel.Height <= mheight)
            {
                timer.Stop();
                IsOpen = false;
            }
        }

        // Fix DropDown (Panel)
        public static void FixDropMenuPanelTop(Panel Main, Button btn)
        {

            btn.Dock = DockStyle.Top;
            Main.Controls.Add(btn);
            btn.BringToFront();

        }
        public static void FixDropMenuPanelTop(Panel Main, Panel panel)
        {

            panel.Dock = DockStyle.Top;
            Main.Controls.Add(panel);
            panel.BringToFront();

        }
        public static void FixDropMenuPanelBottom(Panel Main, Button btn)
        {

            btn.Dock = DockStyle.Bottom;
            Main.Controls.Add(btn);
            btn.BringToFront();

        }
        public static void FixDropMenuPanelBottom(Panel Main, Panel panel)
        {
            panel.Dock = DockStyle.Bottom;
            Main.Controls.Add(panel);
            panel.BringToFront();
        }

        public static void CursorChanger(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is Panel)
                    CursorChanger(c);
                else if (c is Button)
                    ((Button)c).Cursor = Cursors.Hand;
            }
        }

        //#region shadow
        //public static Dropshadow shadow;
        //public static int step = 10;

        //public static void showShadow(UserControl form)
        //{
        //    shadow = new Dropshadow(form)
        //    {
        //        ShadowBlur = 12,
        //        ShadowSpread = 1,
        //        ShadowColor = Color.FromArgb(120, 0, 0, 0)

        //    };
        //    shadow.RefreshShadow();
        //}
        //#endregion

    }
}
