using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcInfo.Classes;
using ParcInfo.ucClient;
using ParcInfo.settings;
using ParcInfo.ucInterevntion;
using ParcInfo.ucDemande;
using ParcInfo.ucParametre;
using ParcInfo.ucControls;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace ParcInfo.frmDefault
{
    public partial class FrmDefault : Form
    {
        public bool isClicked = true;
        public Button btnClicked;
        public FrmDefault()
        {
        
            InitializeComponent();
            ControlsClass.CreateRadiusBorder(PanelContainer);
            this.MaximizeBox = false;
            GlobVars.frmindex = this;
            MenuLeft();
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

            }

            ControlsClass.CursorChanger(pnlMenu);
            tmrReal.Start();

            //MailMessage mail = new MailMessage("myogyt2@gmail.com", "abdelhakim.kssiba@gmail.com");
            //mail.Subject = "subj";
            //mail.Body = "hello";

            //using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            //{
            //    client.EnableSsl = true;
            //    #region hhhh
            //    client.Credentials = new System.Net.NetworkCredential("myogyt2@gmail.com", "ZXCVBNM123");

            //    #endregion

            //    client.Send(mail);
            //}
        }

        public int countIntervTerminer;
        public int countIntervCours;
        public int countIntervRetard;
        public int countIntervDeInt;

        public int countRequestTerminer;
        public int countRequestAttente;
        public int countRequestCours;
        public int countRequestRetard;
        public int countRequestDeInt;

        public void ShowControl(Control mycontrol, bool hideback = false)
        {
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(mycontrol);
            mycontrol.BringToFront();
            PicBack.Visible = hideback;
        }

        MultiLineLabel ml = new MultiLineLabel();

        #region Timers
        private void TmrParms_Tick(object sender, EventArgs e)
        {
            if (ControlsClass.IsOpen)
            {
                ControlsClass.CloseMenu(ControlsClass.isTimer, ControlsClass.isbtn, ControlsClass.isPanel);
            }
            else
            {
                ControlsClass.OpenMenu(TmrParms, btnParam, DropParametre);

            }
        }
        private void TmrClient_Tick(object sender, EventArgs e)
        {
            if (ControlsClass.IsOpen)
            {
                ControlsClass.CloseMenu(ControlsClass.isTimer, ControlsClass.isbtn, ControlsClass.isPanel);
            }
            else
            {
                ControlsClass.OpenMenu(TmrClient, btnClients, DropClient);
            }
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            TmrClient.Start();

        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            TmrProduits.Start();
        }
        private void btnIntervention_Click(object sender, EventArgs e)
        {
            tmrIntervention.Start();
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            tmrRequest.Start();
        }
        private void TmrRequest_Tick(object sender, EventArgs e)
        {
            if (ControlsClass.IsOpen)
            {
                ControlsClass.CloseMenu(ControlsClass.isTimer, ControlsClass.isbtn, ControlsClass.isPanel);
            }
            else
            {
                ControlsClass.OpenMenu(tmrRequest, btnRequest, DropDemande);

            }
        }

        private void TmrIntervention_Tick(object sender, EventArgs e)
        {
            if (ControlsClass.IsOpen)
            {
                ControlsClass.CloseMenu(ControlsClass.isTimer, ControlsClass.isbtn, ControlsClass.isPanel);
            }
            else
            {
                ControlsClass.OpenMenu(tmrIntervention, btnIntervention, DropIntervention);

            }
        }
        private void TmrProduits_Tick(object sender, EventArgs e)
        {
            if (ControlsClass.IsOpen)
            {
                ControlsClass.CloseMenu(ControlsClass.isTimer, ControlsClass.isbtn, ControlsClass.isPanel);
            }
            else
            {
                ControlsClass.OpenMenu(TmrProduits, BtnProduct, DropProduit);

            }
        }
        private void btnParam_Click(object sender, EventArgs e)
        {
            TmrParms.Start();
        }
        #endregion

        // Create Client 
        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            CreateClient frmcc = new CreateClient(0,"");
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
         //  BtnCreateClient.BackColor = Color.FromArgb(93, 98, 132);
            activeBtn(BtnCreateClient);
        }
        private void BtnListClient_Click(object sender, EventArgs e)
        {
            ListClients frmcc = new ListClients();
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
            activeBtn(BtnListClient);

        }

        #region profileMenu
        // Show Profile Menu
        private void PicShowMenu_Click(object sender, EventArgs e)
        {
            showLogin();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showLogin();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            showLogin();
        }
        void showLogin()
        {
            if (isClicked)
            {
                DropdownUserMenu.Visible = true;
                isClicked = false;

            }
            else
            {
                DropdownUserMenu.Visible = false;
                isClicked = true;
            }
        }
        public void HideMenu(object sender, EventArgs e)
        {
            DropdownUserMenu.Visible = false;
            isClicked = true;
        }

        // Hide Profile Menu
        private void PanelHeader_Click(object sender, EventArgs e)
        {
            DropdownUserMenu.Visible = false;
            isClicked = true;
        }

        #region list of request


        private void btnListDemande_Click(object sender, EventArgs e)
        {
            ListDemande req = new ListDemande("", 0, 0);
            ShowControl(req);
        }
        private void btnDemandeAttent_Click(object sender, EventArgs e)
        {
            ListDemande req = new ListDemande("en attente", 0, 0);
            ShowControl(req);
        }

        private void btnDemandeCours_Click(object sender, EventArgs e)
        {
            ListDemande req = new ListDemande("en cours", countRequestCours, 0);
            ShowControl(req);
        }

        private void btnDemandeRetard_Click(object sender, EventArgs e)
        {
            ListDemande req = new ListDemande("en retard", countRequestRetard, 0);
            ShowControl(req);
        }
        private void btnDemandeTerminer_Click(object sender, EventArgs e)
        {
            ListDemande req = new ListDemande("terminer", countRequestTerminer, 0);
            ShowControl(req);
        }
        #endregion


        // Dock Menus
        public void MenuLeft()
        {
            // Top
            ControlsClass.FixDropMenuPanelTop(pnlMenu, BtnHome);
            ControlsClass.FixDropMenuPanelTop(pnlMenu, DropClient);
            ControlsClass.FixDropMenuPanelTop(pnlMenu, DropDemande);
            ControlsClass.FixDropMenuPanelTop(pnlMenu, DropIntervention);
            ControlsClass.FixDropMenuPanelTop(pnlMenu, DropProduit);
            ControlsClass.FixDropMenuPanelTop(pnlMenu, DropParametre);
        }

        #endregion



        private void btnTypeProduct_Click(object sender, EventArgs e)
        {
            TypesProduits frmcc = new TypesProduits();
            ShowControl(frmcc);
            activeBtn(BtnListClient);
        }


        private void btnNewInterevention_Click(object sender, EventArgs e)
        {

        }


        #region list of interventions
        //all the interventions
        private void btnListIntervention_Click(object sender, EventArgs e)
        {
                ListeIntervention intervention = new ListeIntervention("",0);
            ShowControl(intervention);
        }
        //intervention 'en cours'
        private void btnInterventionCours_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention("en cours", countIntervCours);
            ShowControl(intervention);
        }
        //intervention 'en retard'
        private void btnInterventionRetard_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention("en retard", countIntervRetard);
            ShowControl(intervention);
        }
        //intervention 'terminer'
        private void btnInterventionTerminer_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention("terminer",countIntervTerminer);
            ShowControl(intervention);
        }
        #endregion


        #region Buttonsmenu

        private void PicBack_Click(object sender, EventArgs e)
        {
            ListClients frmcc = new ListClients();
            frmcc.txtFind.Text = GlobVars.SearchValue;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
            PicBack.Visible = false;
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            listProduits product = new listProduits();
            ShowControl(product);
        }


        private void btnNewUser_Click(object sender, EventArgs e)
        {
            CreateUser ceateUser = new CreateUser();
            ShowControl(ceateUser);
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            ListUtilisateur listUsers = new ListUtilisateur();
            ShowControl(listUsers);
        }

        private void tmrReal_Tick(object sender, EventArgs e)
        {
            if (!getRealdata.IsBusy)
                getRealdata.RunWorkerAsync();
        }

        #endregion


        private void getRealdata_DoWork(object sender, DoWorkEventArgs e)
        {
            checkDb();
        }
        void checkDb()
        {
            using (var db = new ParcInformatiqueEntities())
            {

                countIntervTerminer = db.GetIntervtermine.Count();
                countIntervCours = db.GetIntervEncours.Count();
                countIntervRetard = db.GetIntervenretard.Count();

                countIntervDeInt = countIntervRetard + countIntervCours;


                countRequestTerminer = db.GetRequestTerminer.Count();
                countRequestCours = db.GetRequestCours.Count();
                countRequestRetard = db.GetRequestRetard.Count();
                countRequestAttente = db.GetRequestAttent.Count();
                

                countRequestDeInt = countRequestRetard + countRequestCours;
            }
        }

        private void getRealdata_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            lblInterventionTerminer.Text = countIntervTerminer.ToString();

            lblIntereventionCours.Text = countIntervCours.ToString();

            lblInterventionRetard.Text = countIntervRetard.ToString();

            lblTotalIntervention.Text = countIntervDeInt.ToString();

            lblTotalRequest.Text = countRequestDeInt.ToString();
            lblRequestCours.Text = countRequestCours.ToString();
            lblRequestRetard.Text = countRequestRetard.ToString();
            lblRequestTerminer.Text = countRequestTerminer.ToString();
            lblRequestAttente.Text = countRequestAttente.ToString();

            lblNotif.Text = countRequestAttente.ToString();

            lblInterventionTerminer.Update();
            lblTotalIntervention.Update();
            lblInterventionRetard.Update();
            lblIntereventionCours.Update();
        }

        private void FrmDefault_Load(object sender, EventArgs e)
        {
          //  this.ControlBox = false;
          
        }

        private void PicBack_Click_1(object sender, EventArgs e)
        {
            if (GlobVars.frmBack != null && GlobVars.frmBack2 == null)
            {
                ShowControl(GlobVars.frmBack);
            }
            else if (GlobVars.frmBack != null && GlobVars.frmBack2 != null)
            {
                ShowControl(GlobVars.frmBack2);
                
            }
         
        }

        public void activeBtn(Button btn )
        {
            btn.BackColor = Color.FromArgb(93, 98, 132);
            foreach (Control item in pnlMenu.Controls)
            {
                if (item is Panel)
                {
                    foreach (Control c in item.Controls)
                    {
                        if (c is Button)
                        {
                            if (c.BackColor.Name == "ff5d6284")
                            {
                                c.BackColor = Color.FromArgb(44, 46, 62);
                                btn.BackColor = Color.FromArgb(93, 98, 132);
                            }
                        }
                    }
                }
           
            }
        }
  
    }
}
