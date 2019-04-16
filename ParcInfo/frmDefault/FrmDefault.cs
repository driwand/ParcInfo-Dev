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

        public FrmDefault()
        {
            InitializeComponent();
            GlobVars.frmindex = this;
            MenuLeft();

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

            }

           

            ControlsClass.CursorChanger(pnlMenu);
            tmrReal.Start();

        }
        public int countIntervTerminer;
        public int countIntervCours;
        public int countIntervRetard;
        public int countIntervDeInt;

        void checkDb()
        {
            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {
                
                var allInterv = context.Interventions.ToList();

                countIntervTerminer = allInterv.Where(inr => inr.Statut == "terminer").Count();

                countIntervCours = allInterv.Where(inr => inr.Statut == "en cours").Count();

                countIntervRetard = allInterv.Where(inr => inr.Statut == "en retard").Count();

                countIntervDeInt = countIntervRetard + countIntervCours;

                foreach (var v in allInterv)
                {

                    if (v.DateIntervention != null)
                    {
                        if (DateTime.Now > v.DateIntervention.Value.AddDays(2) && v.Statut != "terminer" && v.Statut != "en cours")
                        {
                            v.Statut = "en retard";
                        }
                    }

                }
                context.SaveChanges();
            }

            using (ParcInformatiqueEntities context = new ParcInformatiqueEntities())
            {

                context.SaveChanges();
            }

        }
       
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
            CreateClient frmcc = new CreateClient();
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
        }
        private void BtnListClient_Click(object sender, EventArgs e)
        {
            ListClients frmcc = new ListClients();
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
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

       

        private void btnTypeProduct_Click(object sender, EventArgs e)
        {
            TypesProduits frmcc = new TypesProduits();
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
        }

        #region list of request
        private void btnListDemande_Click(object sender, EventArgs e)
        {
            ListDemande frmcc = new ListDemande();
            frmcc.lblTotalRequest.BackColor = Color.FromArgb(44, 46, 62);
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
        }

        private void btnDemandeCours_Click(object sender, EventArgs e)
        {
            ListDemande frmcc = new ListDemande();
            frmcc.lblTotalRequest.BackColor = Color.FromArgb(250, 130, 49);
            PanelContainer.Controls.Clear();

            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
        }

        private void btnDemandeRetard_Click(object sender, EventArgs e)
        {
            ListDemande frmcc = new ListDemande();
            frmcc.lblTotalRequest.BackColor = Color.FromArgb(252, 92, 101);
            PanelContainer.Controls.Clear();

            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
        }
        private void btnDemandeTerminer_Click(object sender, EventArgs e)
        {
            ListDemande frmcc = new ListDemande();

            frmcc.lblTotalRequest.BackColor = Color.FromArgb(46, 204, 113);
            frmcc.gpFind.Size = new Size(863, 50);
            frmcc.btnTraiter.Hide();
            frmcc.btnFind.Location = new Point(829, 15);
            frmcc.txtFind.Size = new Size(683, 20);
            PanelContainer.Controls.Clear();

            PanelContainer.Controls.Add(frmcc);
            frmcc.BringToFront();
        }
        #endregion

        private void btnNewInterevention_Click(object sender, EventArgs e)
        {

        }


        #region list of interventions
        //all the interventions
        private void btnListIntervention_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention() { statutInterv = "" };
            ShowControl(intervention);
        }
        //intervention 'en cours'
        private void btnInterventionCours_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention() { countInterv = countIntervCours,statutInterv = "en cours"};
            ShowControl(intervention);
        }
        //intervention 'en retard'
        private void btnInterventionRetard_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention() {countInterv = countIntervRetard , statutInterv = "en retard" };
            ShowControl(intervention);
        }
        //intervention 'terminer'
        private void btnInterventionTerminer_Click(object sender, EventArgs e)
        {
            ListeIntervention intervention = new ListeIntervention() { countInterv = countIntervTerminer, statutInterv = "terminer" };
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
            ListProduit product = new ListProduit();
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
            if(!getRealdata.IsBusy)
                getRealdata.RunWorkerAsync();
        }


        #endregion


        private void getRealdata_DoWork(object sender, DoWorkEventArgs e)
        {
            checkDb();
        }

        private void getRealdata_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            lblInterventionTerminer.Text = countIntervTerminer.ToString();

            lblIntereventionCours.Text = countIntervCours.ToString();

            lblInterventionRetard.Text = countIntervRetard.ToString();

            lblTotalIntervention.Text = countIntervDeInt.ToString();

            lblInterventionTerminer.Update();
            lblTotalIntervention.Update();
            lblInterventionRetard.Update();
            lblIntereventionCours.Update();
        }
    }
}
