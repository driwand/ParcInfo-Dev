
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


        public static void CreateRadiusBorder(UserControl panel)
        {
            panel.BorderStyle = BorderStyle.None;
            panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 15, 15));
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
            btn.Image = Resources.arrowDown1;
            panel.Height += 10;
            if (panel.Size == panel.MaximumSize)
            {
                timer.Stop();
                IsOpen = true;
                isPanel = panel;
                isTimer = timer;
                isbtn = btn;
            }
        }
        public static void CloseMenu(Timer timer, Button btn, Panel panel)
        {
            btn.Image = Resources.arrowLeft1;
            panel.Height -= 10;
            if (panel.Size == panel.MinimumSize)
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

        public static void Nice_grid(string[] columns, string[] columnstext, DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeColumns = true;
            grid.AllowUserToResizeRows = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewCellStyle DataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            DataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25f);
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            DataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("fr-FR");
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid.BackgroundColor = Color.WhiteSmoke;
            grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            grid.ReadOnly = true;
            grid.ColumnHeadersHeight = 30;
            grid.RowHeadersVisible = false;
            grid.ScrollBars = ScrollBars.Vertical;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            int index = 0;
            foreach (DataGridViewColumn r in grid.Columns)
            {
                if (!(Array.IndexOf(columns, r.Name) > -1))
                {
                    r.Visible = false;
                }
                else
                {
                    index = index + 1;
                    r.Width = grid.Width / columns.Length;
                    r.HeaderText = columnstext[index - 1];
                }
            }
        }
    }
}
