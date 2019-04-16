using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.ucControls;

namespace ParcInfo.ucClient
{
    public partial class DetailProduit : UserControl
    {
        int userName = 1;
        int logName = 1;
        
        public DetailProduit()
        {
            InitializeComponent();
            lblTextbox.ClickedAdd += new EventHandler(ShowUserList_clicked);
            AffectEmloyee.Close += new EventHandler(HideEmployeClient_clicked);

            //ListUser.Clicked += new EventHandler(hideLog_click);

        }



        void ShowUserList_clicked(object sender, EventArgs e)
        {
            // ctrlName = ((Control)sender).Name;
            //if (ctrlName.StartsWith("userC"))
            //{
            //    panel2.Visible = true;
            //    AffectEmloyee lis = new AffectEmloyee();
            //    lis.Dock = DockStyle.Fill;
            //    panel2.Controls.Add(lis);

            //    lis.BringToFront();
            //    panel2.Location = new Point(164, 3);
            //    panel2.Size = new Size(600, 468);
            //    panel2.BringToFront();
            //}
            //else
            //{
            //    panel2.Visible = true;
            //    ListUser lis = new ListUser();
            //    lis.Dock = DockStyle.Fill;
            //    panel2.Controls.Add(lis);

            //    lis.BringToFront();
            //    panel2.Location = new Point(164, 3);
            //    panel2.Size = new Size(589, 370);
            //    panel2.BringToFront();
            //}
            
          
        }
        void hideLog_click(object sender, EventArgs e)
        {

            AffectEmloyee lis = new AffectEmloyee();
            lis.Dock = DockStyle.Fill;
            panel2.Controls.Add(lis);

            lis.BringToFront();
            panel2.Visible = false;
        }
        void HideEmployeClient_clicked(object sender, EventArgs e)
        {
            
            AffectEmloyee lis = new AffectEmloyee();
            lis.Dock = DockStyle.Fill;
            panel2.Controls.Add(lis);

            lis.BringToFront();
            panel2.Visible = false;
        }
        private void ListProduitClient_Load(object sender, EventArgs e)
        {
            lblTextbox user1 = new lblTextbox();
            user1.Name = "userC" + userName;
            user1.LblText = "Nom :";
            user1.Margin = new Padding(0, 0, 0, 12);
            userName++;

            FpEmployee.Controls.Add(user1);

            lblTextbox user2 = new lblTextbox();
            user2.Name = "log" + userName;
            user2.LblText = "Nom :";
            user2.Margin = new Padding(0, 0, 0, 12);
            logName++;

            FpProduit.Controls.Add(user2);
        }

       
    }
}
