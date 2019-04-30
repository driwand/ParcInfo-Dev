using System;

namespace ParcInfo.frmDefault
{
    partial class FrmDefault
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.DropdownUserMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.line3 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicBack = new System.Windows.Forms.PictureBox();
            this.pnlUserName = new System.Windows.Forms.Panel();
            this.PicShowMenu = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNotif = new System.Windows.Forms.Label();
            this.lineVertical = new System.Windows.Forms.Panel();
            this.PickBell = new System.Windows.Forms.PictureBox();
            this.PanelLeftSide = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.DropIntervention = new System.Windows.Forms.Panel();
            this.lblInterventionTerminer = new System.Windows.Forms.Label();
            this.btnInterventionTerminer = new System.Windows.Forms.Button();
            this.lblIntereventionCours = new System.Windows.Forms.Label();
            this.lblInterventionRetard = new System.Windows.Forms.Label();
            this.lblTotalIntervention = new System.Windows.Forms.Label();
            this.btnInterventionRetard = new System.Windows.Forms.Button();
            this.btnInterventionCours = new System.Windows.Forms.Button();
            this.btnListIntervention = new System.Windows.Forms.Button();
            this.btnIntervention = new System.Windows.Forms.Button();
            this.DropParametre = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTypeProduct = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnParam = new System.Windows.Forms.Button();
            this.DropProduit = new System.Windows.Forms.Panel();
            this.btnListProduct = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.DropClient = new System.Windows.Forms.Panel();
            this.BtnListClient = new System.Windows.Forms.Button();
            this.BtnCreateClient = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.DropDemande = new System.Windows.Forms.Panel();
            this.lblRequestRetard = new System.Windows.Forms.Label();
            this.lblRequestTerminer = new System.Windows.Forms.Label();
            this.btnDemandeTerminer = new System.Windows.Forms.Button();
            this.btnDemandeRetard = new System.Windows.Forms.Button();
            this.lblRequestAttente = new System.Windows.Forms.Label();
            this.lblRequestCours = new System.Windows.Forms.Label();
            this.lblTotalRequest = new System.Windows.Forms.Label();
            this.btnDemandeCours = new System.Windows.Forms.Button();
            this.btnDemandeAttent = new System.Windows.Forms.Button();
            this.btnListDemande = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.lblLogoName = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.FrmPanel = new System.Windows.Forms.Panel();
            this.tmrIntervention = new System.Windows.Forms.Timer(this.components);
            this.TmrUtilisateurs = new System.Windows.Forms.Timer(this.components);
            this.TmrProduits = new System.Windows.Forms.Timer(this.components);
            this.TmrClient = new System.Windows.Forms.Timer(this.components);
            this.tmrRequest = new System.Windows.Forms.Timer(this.components);
            this.TmrParms = new System.Windows.Forms.Timer(this.components);
            this.tmrReal = new System.Windows.Forms.Timer(this.components);
            this.tmrRetard = new System.Windows.Forms.Timer(this.components);
            this.getRealdata = new System.ComponentModel.BackgroundWorker();
            this.dragControl1 = new ParcInfo.ucControls.DragControl();
            this.panel2.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.DropdownUserMenu.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
            this.pnlUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickBell)).BeginInit();
            this.PanelLeftSide.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.DropIntervention.SuspendLayout();
            this.DropParametre.SuspendLayout();
            this.DropProduit.SuspendLayout();
            this.DropClient.SuspendLayout();
            this.DropDemande.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.FrmPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.PanelMain);
            this.panel2.Controls.Add(this.PanelHeader);
            this.panel2.Controls.Add(this.PanelLeftSide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1156, 590);
            this.panel2.TabIndex = 3;
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.DropdownUserMenu);
            this.PanelMain.Controls.Add(this.PanelContainer);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(224, 67);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(20);
            this.PanelMain.Size = new System.Drawing.Size(932, 523);
            this.PanelMain.TabIndex = 2;
            // 
            // DropdownUserMenu
            // 
            this.DropdownUserMenu.BackColor = System.Drawing.Color.White;
            this.DropdownUserMenu.Controls.Add(this.button1);
            this.DropdownUserMenu.Controls.Add(this.line3);
            this.DropdownUserMenu.Controls.Add(this.btnProfile);
            this.DropdownUserMenu.Location = new System.Drawing.Point(765, 1);
            this.DropdownUserMenu.MaximumSize = new System.Drawing.Size(146, 93);
            this.DropdownUserMenu.MinimumSize = new System.Drawing.Size(146, 93);
            this.DropdownUserMenu.Name = "DropdownUserMenu";
            this.DropdownUserMenu.Size = new System.Drawing.Size(146, 93);
            this.DropdownUserMenu.TabIndex = 0;
            this.DropdownUserMenu.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ParcInfo.Properties.Resources.userLogout;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.line3.Dock = System.Windows.Forms.DockStyle.Top;
            this.line3.Location = new System.Drawing.Point(0, 48);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(146, 1);
            this.line3.TabIndex = 2;
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = global::ParcInfo.Properties.Resources.userProfile;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(146, 48);
            this.btnProfile.TabIndex = 99;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.White;
            this.PanelContainer.Controls.Add(this.DropClient);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(20, 20);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(892, 483);
            this.PanelContainer.TabIndex = 0;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.pictureBox2);
            this.PanelHeader.Controls.Add(this.PicBack);
            this.PanelHeader.Controls.Add(this.pnlUserName);
            this.PanelHeader.Controls.Add(this.lblNotif);
            this.PanelHeader.Controls.Add(this.lineVertical);
            this.PanelHeader.Controls.Add(this.PickBell);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(224, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(932, 67);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.Click += new System.EventHandler(this.PanelHeader_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::ParcInfo.Properties.Resources.Back_100px;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            
            // 
            // PicBack
            // 
            this.PicBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBack.Image = global::ParcInfo.Properties.Resources.Back_100px;
            this.PicBack.Location = new System.Drawing.Point(235, 15);
            this.PicBack.Name = "PicBack";
            this.PicBack.Size = new System.Drawing.Size(38, 35);
            this.PicBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBack.TabIndex = 12;
            this.PicBack.TabStop = false;
            this.PicBack.Visible = false;
            this.PicBack.Click += new System.EventHandler(this.PicBack_Click_1);
            // 
            // pnlUserName
            // 
            this.pnlUserName.Controls.Add(this.PicShowMenu);
            this.pnlUserName.Controls.Add(this.lblUser);
            this.pnlUserName.Controls.Add(this.pictureBox1);
            this.pnlUserName.Location = new System.Drawing.Point(734, 18);
            this.pnlUserName.Name = "pnlUserName";
            this.pnlUserName.Size = new System.Drawing.Size(176, 32);
            this.pnlUserName.TabIndex = 11;
            this.pnlUserName.Click += new System.EventHandler(this.panel1_Click);
            // 
            // PicShowMenu
            // 
            this.PicShowMenu.Image = global::ParcInfo.Properties.Resources.arrowDown1;
            this.PicShowMenu.Location = new System.Drawing.Point(150, 5);
            this.PicShowMenu.Name = "PicShowMenu";
            this.PicShowMenu.Size = new System.Drawing.Size(20, 20);
            this.PicShowMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicShowMenu.TabIndex = 13;
            this.PicShowMenu.TabStop = false;
            this.PicShowMenu.Click += new System.EventHandler(this.PicShowMenu_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(4, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 17);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Username";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(116, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.lblNotif.ForeColor = System.Drawing.Color.White;
            this.lblNotif.Location = new System.Drawing.Point(705, 15);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(13, 13);
            this.lblNotif.TabIndex = 6;
            this.lblNotif.Text = "0";
            // 
            // lineVertical
            // 
            this.lineVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.lineVertical.Location = new System.Drawing.Point(727, 18);
            this.lineVertical.Name = "lineVertical";
            this.lineVertical.Size = new System.Drawing.Size(1, 32);
            this.lineVertical.TabIndex = 2;
            // 
            // PickBell
            // 
            this.PickBell.Image = global::ParcInfo.Properties.Resources.Notification;
            this.PickBell.Location = new System.Drawing.Point(684, 18);
            this.PickBell.Name = "PickBell";
            this.PickBell.Size = new System.Drawing.Size(32, 32);
            this.PickBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PickBell.TabIndex = 0;
            this.PickBell.TabStop = false;
            // 
            // PanelLeftSide
            // 
            this.PanelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.PanelLeftSide.Controls.Add(this.pnlMenu);
            this.PanelLeftSide.Controls.Add(this.PanelLogo);
            this.PanelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.PanelLeftSide.Name = "PanelLeftSide";
            this.PanelLeftSide.Size = new System.Drawing.Size(224, 590);
            this.PanelLeftSide.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.DropIntervention);
            this.pnlMenu.Controls.Add(this.DropParametre);
            this.pnlMenu.Controls.Add(this.DropProduit);
            this.pnlMenu.Controls.Add(this.DropDemande);
            this.pnlMenu.Controls.Add(this.BtnHome);
            this.pnlMenu.Location = new System.Drawing.Point(0, 87);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(224, 503);
            this.pnlMenu.TabIndex = 4;
            // 
            // DropIntervention
            // 
            this.DropIntervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.DropIntervention.Controls.Add(this.lblInterventionTerminer);
            this.DropIntervention.Controls.Add(this.btnInterventionTerminer);
            this.DropIntervention.Controls.Add(this.lblIntereventionCours);
            this.DropIntervention.Controls.Add(this.lblInterventionRetard);
            this.DropIntervention.Controls.Add(this.lblTotalIntervention);
            this.DropIntervention.Controls.Add(this.btnInterventionRetard);
            this.DropIntervention.Controls.Add(this.btnInterventionCours);
            this.DropIntervention.Controls.Add(this.btnListIntervention);
            this.DropIntervention.Controls.Add(this.btnIntervention);
            this.DropIntervention.Location = new System.Drawing.Point(3, 257);
            this.DropIntervention.MinimumSize = new System.Drawing.Size(224, 41);
            this.DropIntervention.Name = "DropIntervention";
            this.DropIntervention.Size = new System.Drawing.Size(224, 41);
            this.DropIntervention.TabIndex = 9;
            // 
            // lblInterventionTerminer
            // 
            this.lblInterventionTerminer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblInterventionTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterventionTerminer.ForeColor = System.Drawing.Color.White;
            this.lblInterventionTerminer.Location = new System.Drawing.Point(193, 175);
            this.lblInterventionTerminer.Name = "lblInterventionTerminer";
            this.lblInterventionTerminer.Size = new System.Drawing.Size(21, 18);
            this.lblInterventionTerminer.TabIndex = 14;
            this.lblInterventionTerminer.Text = "0";
            this.lblInterventionTerminer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInterventionTerminer
            // 
            this.btnInterventionTerminer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInterventionTerminer.FlatAppearance.BorderSize = 0;
            this.btnInterventionTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterventionTerminer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterventionTerminer.ForeColor = System.Drawing.Color.White;
            this.btnInterventionTerminer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInterventionTerminer.Location = new System.Drawing.Point(0, 164);
            this.btnInterventionTerminer.Name = "btnInterventionTerminer";
            this.btnInterventionTerminer.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInterventionTerminer.Size = new System.Drawing.Size(224, 41);
            this.btnInterventionTerminer.TabIndex = 13;
            this.btnInterventionTerminer.Text = "Intervention terminer";
            this.btnInterventionTerminer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterventionTerminer.UseVisualStyleBackColor = true;
            this.btnInterventionTerminer.Click += new System.EventHandler(this.btnInterventionTerminer_Click);
            // 
            // lblIntereventionCours
            // 
            this.lblIntereventionCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblIntereventionCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntereventionCours.ForeColor = System.Drawing.Color.White;
            this.lblIntereventionCours.Location = new System.Drawing.Point(193, 93);
            this.lblIntereventionCours.Name = "lblIntereventionCours";
            this.lblIntereventionCours.Size = new System.Drawing.Size(21, 18);
            this.lblIntereventionCours.TabIndex = 12;
            this.lblIntereventionCours.Text = "0";
            this.lblIntereventionCours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInterventionRetard
            // 
            this.lblInterventionRetard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.lblInterventionRetard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterventionRetard.ForeColor = System.Drawing.Color.White;
            this.lblInterventionRetard.Location = new System.Drawing.Point(193, 134);
            this.lblInterventionRetard.Name = "lblInterventionRetard";
            this.lblInterventionRetard.Size = new System.Drawing.Size(21, 18);
            this.lblInterventionRetard.TabIndex = 9;
            this.lblInterventionRetard.Text = "0";
            this.lblInterventionRetard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalIntervention
            // 
            this.lblTotalIntervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.lblTotalIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIntervention.ForeColor = System.Drawing.Color.White;
            this.lblTotalIntervention.Location = new System.Drawing.Point(124, 11);
            this.lblTotalIntervention.Name = "lblTotalIntervention";
            this.lblTotalIntervention.Size = new System.Drawing.Size(21, 18);
            this.lblTotalIntervention.TabIndex = 8;
            this.lblTotalIntervention.Text = "0";
            this.lblTotalIntervention.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInterventionRetard
            // 
            this.btnInterventionRetard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInterventionRetard.FlatAppearance.BorderSize = 0;
            this.btnInterventionRetard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterventionRetard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterventionRetard.ForeColor = System.Drawing.Color.White;
            this.btnInterventionRetard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInterventionRetard.Location = new System.Drawing.Point(0, 123);
            this.btnInterventionRetard.Name = "btnInterventionRetard";
            this.btnInterventionRetard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInterventionRetard.Size = new System.Drawing.Size(224, 41);
            this.btnInterventionRetard.TabIndex = 7;
            this.btnInterventionRetard.Text = "Intervention en retard";
            this.btnInterventionRetard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterventionRetard.UseVisualStyleBackColor = true;
            this.btnInterventionRetard.Click += new System.EventHandler(this.btnInterventionRetard_Click);
            // 
            // btnInterventionCours
            // 
            this.btnInterventionCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInterventionCours.FlatAppearance.BorderSize = 0;
            this.btnInterventionCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterventionCours.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterventionCours.ForeColor = System.Drawing.Color.White;
            this.btnInterventionCours.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInterventionCours.Location = new System.Drawing.Point(0, 82);
            this.btnInterventionCours.Name = "btnInterventionCours";
            this.btnInterventionCours.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInterventionCours.Size = new System.Drawing.Size(224, 41);
            this.btnInterventionCours.TabIndex = 6;
            this.btnInterventionCours.Text = "Intervetion en cours";
            this.btnInterventionCours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInterventionCours.UseVisualStyleBackColor = true;
            this.btnInterventionCours.Click += new System.EventHandler(this.btnInterventionCours_Click);
            // 
            // btnListIntervention
            // 
            this.btnListIntervention.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListIntervention.FlatAppearance.BorderSize = 0;
            this.btnListIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListIntervention.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListIntervention.ForeColor = System.Drawing.Color.White;
            this.btnListIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListIntervention.Location = new System.Drawing.Point(0, 41);
            this.btnListIntervention.Name = "btnListIntervention";
            this.btnListIntervention.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnListIntervention.Size = new System.Drawing.Size(224, 41);
            this.btnListIntervention.TabIndex = 5;
            this.btnListIntervention.Text = "Liste des interventions";
            this.btnListIntervention.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListIntervention.UseVisualStyleBackColor = true;
            this.btnListIntervention.Click += new System.EventHandler(this.btnListIntervention_Click);
            // 
            // btnIntervention
            // 
            this.btnIntervention.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIntervention.FlatAppearance.BorderSize = 0;
            this.btnIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntervention.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntervention.ForeColor = System.Drawing.Color.White;
            this.btnIntervention.Image = global::ParcInfo.Properties.Resources.arrowLeft1;
            this.btnIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIntervention.Location = new System.Drawing.Point(0, 0);
            this.btnIntervention.Name = "btnIntervention";
            this.btnIntervention.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIntervention.Size = new System.Drawing.Size(224, 41);
            this.btnIntervention.TabIndex = 3;
            this.btnIntervention.Text = "Intervention";
            this.btnIntervention.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntervention.UseVisualStyleBackColor = true;
            this.btnIntervention.Click += new System.EventHandler(this.btnIntervention_Click);
            // 
            // DropParametre
            // 
            this.DropParametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.DropParametre.Controls.Add(this.btnSettings);
            this.DropParametre.Controls.Add(this.btnTypeProduct);
            this.DropParametre.Controls.Add(this.btnListUsers);
            this.DropParametre.Controls.Add(this.btnNewUser);
            this.DropParametre.Controls.Add(this.btnParam);
            this.DropParametre.Location = new System.Drawing.Point(0, 313);
            this.DropParametre.MinimumSize = new System.Drawing.Size(224, 41);
            this.DropParametre.Name = "DropParametre";
            this.DropParametre.Size = new System.Drawing.Size(224, 41);
            this.DropParametre.TabIndex = 7;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 164);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(224, 41);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Reglage application";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTypeProduct
            // 
            this.btnTypeProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTypeProduct.FlatAppearance.BorderSize = 0;
            this.btnTypeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeProduct.ForeColor = System.Drawing.Color.White;
            this.btnTypeProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypeProduct.Location = new System.Drawing.Point(0, 123);
            this.btnTypeProduct.Name = "btnTypeProduct";
            this.btnTypeProduct.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTypeProduct.Size = new System.Drawing.Size(224, 41);
            this.btnTypeProduct.TabIndex = 7;
            this.btnTypeProduct.Text = "Type des produits";
            this.btnTypeProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeProduct.UseVisualStyleBackColor = true;
            this.btnTypeProduct.Click += new System.EventHandler(this.btnTypeProduct_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListUsers.FlatAppearance.BorderSize = 0;
            this.btnListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListUsers.ForeColor = System.Drawing.Color.White;
            this.btnListUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListUsers.Location = new System.Drawing.Point(0, 82);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnListUsers.Size = new System.Drawing.Size(224, 41);
            this.btnListUsers.TabIndex = 6;
            this.btnListUsers.Text = "Liste des utilisateurs";
            this.btnListUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUser.Location = new System.Drawing.Point(0, 41);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNewUser.Size = new System.Drawing.Size(224, 41);
            this.btnNewUser.TabIndex = 4;
            this.btnNewUser.Text = "Nouveu utilisateur";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnParam
            // 
            this.btnParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParam.FlatAppearance.BorderSize = 0;
            this.btnParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParam.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParam.ForeColor = System.Drawing.Color.White;
            this.btnParam.Image = global::ParcInfo.Properties.Resources.arrowLeft1;
            this.btnParam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParam.Location = new System.Drawing.Point(0, 0);
            this.btnParam.Name = "btnParam";
            this.btnParam.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnParam.Size = new System.Drawing.Size(224, 41);
            this.btnParam.TabIndex = 3;
            this.btnParam.Text = "paramétre";
            this.btnParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParam.UseVisualStyleBackColor = true;
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // DropProduit
            // 
            this.DropProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.DropProduit.Controls.Add(this.btnListProduct);
            this.DropProduit.Controls.Add(this.BtnProduct);
            this.DropProduit.Location = new System.Drawing.Point(3, 115);
            this.DropProduit.MinimumSize = new System.Drawing.Size(224, 41);
            this.DropProduit.Name = "DropProduit";
            this.DropProduit.Size = new System.Drawing.Size(224, 41);
            this.DropProduit.TabIndex = 6;
            // 
            // btnListProduct
            // 
            this.btnListProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListProduct.FlatAppearance.BorderSize = 0;
            this.btnListProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListProduct.ForeColor = System.Drawing.Color.White;
            this.btnListProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListProduct.Location = new System.Drawing.Point(0, 41);
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnListProduct.Size = new System.Drawing.Size(224, 41);
            this.btnListProduct.TabIndex = 5;
            this.btnListProduct.Text = "List des produits";
            this.btnListProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProduct.FlatAppearance.BorderSize = 0;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduct.ForeColor = System.Drawing.Color.White;
            this.BtnProduct.Image = global::ParcInfo.Properties.Resources.arrowLeft1;
            this.BtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProduct.Location = new System.Drawing.Point(0, 0);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnProduct.Size = new System.Drawing.Size(224, 41);
            this.BtnProduct.TabIndex = 3;
            this.BtnProduct.Text = "Produit";
            this.BtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // DropClient
            // 
            this.DropClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.DropClient.Controls.Add(this.BtnListClient);
            this.DropClient.Controls.Add(this.BtnCreateClient);
            this.DropClient.Controls.Add(this.btnClients);
            this.DropClient.Location = new System.Drawing.Point(133, 94);
            this.DropClient.MinimumSize = new System.Drawing.Size(224, 41);
            this.DropClient.Name = "DropClient";
            this.DropClient.Size = new System.Drawing.Size(224, 131);
            this.DropClient.TabIndex = 4;
            // 
            // BtnListClient
            // 
            this.BtnListClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnListClient.FlatAppearance.BorderSize = 0;
            this.BtnListClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListClient.ForeColor = System.Drawing.Color.White;
            this.BtnListClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListClient.Location = new System.Drawing.Point(0, 82);
            this.BtnListClient.Name = "BtnListClient";
            this.BtnListClient.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnListClient.Size = new System.Drawing.Size(224, 41);
            this.BtnListClient.TabIndex = 5;
            this.BtnListClient.Text = "Liste des clients";
            this.BtnListClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListClient.UseVisualStyleBackColor = true;
            this.BtnListClient.Click += new System.EventHandler(this.BtnListClient_Click);
            // 
            // BtnCreateClient
            // 
            this.BtnCreateClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCreateClient.FlatAppearance.BorderSize = 0;
            this.BtnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateClient.ForeColor = System.Drawing.Color.White;
            this.BtnCreateClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreateClient.Location = new System.Drawing.Point(0, 41);
            this.BtnCreateClient.Name = "BtnCreateClient";
            this.BtnCreateClient.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.BtnCreateClient.Size = new System.Drawing.Size(224, 41);
            this.BtnCreateClient.TabIndex = 4;
            this.BtnCreateClient.Text = "Nouveau client";
            this.BtnCreateClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreateClient.UseVisualStyleBackColor = true;
            this.BtnCreateClient.Click += new System.EventHandler(this.BtnCreateClient_Click);
            // 
            // btnClients
            // 
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.Image = global::ParcInfo.Properties.Resources.arrowLeft1;
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClients.Location = new System.Drawing.Point(0, 0);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClients.Size = new System.Drawing.Size(224, 41);
            this.btnClients.TabIndex = 3;
            this.btnClients.Text = "Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // DropDemande
            // 
            this.DropDemande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.DropDemande.Controls.Add(this.lblRequestRetard);
            this.DropDemande.Controls.Add(this.lblRequestTerminer);
            this.DropDemande.Controls.Add(this.btnDemandeTerminer);
            this.DropDemande.Controls.Add(this.btnDemandeRetard);
            this.DropDemande.Controls.Add(this.lblRequestAttente);
            this.DropDemande.Controls.Add(this.lblRequestCours);
            this.DropDemande.Controls.Add(this.lblTotalRequest);
            this.DropDemande.Controls.Add(this.btnDemandeCours);
            this.DropDemande.Controls.Add(this.btnDemandeAttent);
            this.DropDemande.Controls.Add(this.btnListDemande);
            this.DropDemande.Controls.Add(this.btnRequest);
            this.DropDemande.Location = new System.Drawing.Point(1, 196);
            this.DropDemande.MinimumSize = new System.Drawing.Size(224, 41);
            this.DropDemande.Name = "DropDemande";
            this.DropDemande.Size = new System.Drawing.Size(224, 41);
            this.DropDemande.TabIndex = 7;
            // 
            // lblRequestRetard
            // 
            this.lblRequestRetard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.lblRequestRetard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestRetard.ForeColor = System.Drawing.Color.White;
            this.lblRequestRetard.Location = new System.Drawing.Point(191, 176);
            this.lblRequestRetard.Name = "lblRequestRetard";
            this.lblRequestRetard.Size = new System.Drawing.Size(21, 18);
            this.lblRequestRetard.TabIndex = 13;
            this.lblRequestRetard.Text = "12";
            this.lblRequestRetard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRequestTerminer
            // 
            this.lblRequestTerminer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblRequestTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestTerminer.ForeColor = System.Drawing.Color.White;
            this.lblRequestTerminer.Location = new System.Drawing.Point(191, 217);
            this.lblRequestTerminer.Name = "lblRequestTerminer";
            this.lblRequestTerminer.Size = new System.Drawing.Size(21, 18);
            this.lblRequestTerminer.TabIndex = 16;
            this.lblRequestTerminer.Text = "12";
            this.lblRequestTerminer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDemandeTerminer
            // 
            this.btnDemandeTerminer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemandeTerminer.FlatAppearance.BorderSize = 0;
            this.btnDemandeTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemandeTerminer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeTerminer.ForeColor = System.Drawing.Color.White;
            this.btnDemandeTerminer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDemandeTerminer.Location = new System.Drawing.Point(0, 205);
            this.btnDemandeTerminer.Name = "btnDemandeTerminer";
            this.btnDemandeTerminer.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDemandeTerminer.Size = new System.Drawing.Size(224, 41);
            this.btnDemandeTerminer.TabIndex = 17;
            this.btnDemandeTerminer.Text = "Demande terminer";
            this.btnDemandeTerminer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemandeTerminer.UseVisualStyleBackColor = true;
            this.btnDemandeTerminer.Click += new System.EventHandler(this.btnDemandeTerminer_Click);
            // 
            // btnDemandeRetard
            // 
            this.btnDemandeRetard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemandeRetard.FlatAppearance.BorderSize = 0;
            this.btnDemandeRetard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemandeRetard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeRetard.ForeColor = System.Drawing.Color.White;
            this.btnDemandeRetard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDemandeRetard.Location = new System.Drawing.Point(0, 164);
            this.btnDemandeRetard.Name = "btnDemandeRetard";
            this.btnDemandeRetard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDemandeRetard.Size = new System.Drawing.Size(224, 41);
            this.btnDemandeRetard.TabIndex = 15;
            this.btnDemandeRetard.Text = "Demande en retard";
            this.btnDemandeRetard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemandeRetard.UseVisualStyleBackColor = true;
            this.btnDemandeRetard.Click += new System.EventHandler(this.btnDemandeRetard_Click);
            // 
            // lblRequestAttente
            // 
            this.lblRequestAttente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.lblRequestAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestAttente.ForeColor = System.Drawing.Color.White;
            this.lblRequestAttente.Location = new System.Drawing.Point(191, 94);
            this.lblRequestAttente.Name = "lblRequestAttente";
            this.lblRequestAttente.Size = new System.Drawing.Size(21, 18);
            this.lblRequestAttente.TabIndex = 14;
            this.lblRequestAttente.Text = "21";
            this.lblRequestAttente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRequestCours
            // 
            this.lblRequestCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblRequestCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestCours.ForeColor = System.Drawing.Color.White;
            this.lblRequestCours.Location = new System.Drawing.Point(191, 135);
            this.lblRequestCours.Name = "lblRequestCours";
            this.lblRequestCours.Size = new System.Drawing.Size(21, 18);
            this.lblRequestCours.TabIndex = 14;
            this.lblRequestCours.Text = "21";
            this.lblRequestCours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalRequest
            // 
            this.lblTotalRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.lblTotalRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequest.ForeColor = System.Drawing.Color.White;
            this.lblTotalRequest.Location = new System.Drawing.Point(124, 11);
            this.lblTotalRequest.Name = "lblTotalRequest";
            this.lblTotalRequest.Size = new System.Drawing.Size(21, 18);
            this.lblTotalRequest.TabIndex = 9;
            this.lblTotalRequest.Text = "0";
            this.lblTotalRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDemandeCours
            // 
            this.btnDemandeCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemandeCours.FlatAppearance.BorderSize = 0;
            this.btnDemandeCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemandeCours.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeCours.ForeColor = System.Drawing.Color.White;
            this.btnDemandeCours.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDemandeCours.Location = new System.Drawing.Point(0, 123);
            this.btnDemandeCours.Name = "btnDemandeCours";
            this.btnDemandeCours.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDemandeCours.Size = new System.Drawing.Size(224, 41);
            this.btnDemandeCours.TabIndex = 6;
            this.btnDemandeCours.Text = "Demande en cours";
            this.btnDemandeCours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemandeCours.UseVisualStyleBackColor = true;
            this.btnDemandeCours.Click += new System.EventHandler(this.btnDemandeCours_Click);
            // 
            // btnDemandeAttent
            // 
            this.btnDemandeAttent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemandeAttent.FlatAppearance.BorderSize = 0;
            this.btnDemandeAttent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemandeAttent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemandeAttent.ForeColor = System.Drawing.Color.White;
            this.btnDemandeAttent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDemandeAttent.Location = new System.Drawing.Point(0, 82);
            this.btnDemandeAttent.Name = "btnDemandeAttent";
            this.btnDemandeAttent.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDemandeAttent.Size = new System.Drawing.Size(224, 41);
            this.btnDemandeAttent.TabIndex = 5;
            this.btnDemandeAttent.Text = "Demande en attente";
            this.btnDemandeAttent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemandeAttent.UseVisualStyleBackColor = true;
            this.btnDemandeAttent.Click += new System.EventHandler(this.btnDemandeAttent_Click);
            // 
            // btnListDemande
            // 
            this.btnListDemande.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListDemande.FlatAppearance.BorderSize = 0;
            this.btnListDemande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListDemande.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDemande.ForeColor = System.Drawing.Color.White;
            this.btnListDemande.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListDemande.Location = new System.Drawing.Point(0, 41);
            this.btnListDemande.Name = "btnListDemande";
            this.btnListDemande.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnListDemande.Size = new System.Drawing.Size(224, 41);
            this.btnListDemande.TabIndex = 4;
            this.btnListDemande.Text = "Liste des demandes";
            this.btnListDemande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListDemande.UseVisualStyleBackColor = true;
            this.btnListDemande.Click += new System.EventHandler(this.btnListDemande_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.ForeColor = System.Drawing.Color.White;
            this.btnRequest.Image = global::ParcInfo.Properties.Resources.arrowLeft1;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequest.Location = new System.Drawing.Point(0, 0);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRequest.Size = new System.Drawing.Size(224, 41);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = "Demande";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnHome.Size = new System.Drawing.Size(224, 41);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Accueil";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.lblLogoName);
            this.PanelLogo.Controls.Add(this.line1);
            this.PanelLogo.Controls.Add(this.pnlLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(224, 87);
            this.PanelLogo.TabIndex = 3;
            // 
            // lblLogoName
            // 
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogoName.Location = new System.Drawing.Point(35, 18);
            this.lblLogoName.Name = "lblLogoName";
            this.lblLogoName.Size = new System.Drawing.Size(143, 30);
            this.lblLogoName.TabIndex = 0;
            this.lblLogoName.Text = "PARC INFO";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.line1.Location = new System.Drawing.Point(4, 66);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(212, 1);
            this.line1.TabIndex = 1;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Location = new System.Drawing.Point(1, 1);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(223, 66);
            this.pnlLogo.TabIndex = 1;
            // 
            // FrmPanel
            // 
            this.FrmPanel.Controls.Add(this.panel2);
            this.FrmPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrmPanel.Location = new System.Drawing.Point(0, 0);
            this.FrmPanel.Name = "FrmPanel";
            this.FrmPanel.Size = new System.Drawing.Size(1156, 590);
            this.FrmPanel.TabIndex = 0;
            // 
            // tmrIntervention
            // 
            this.tmrIntervention.Interval = 10;
            this.tmrIntervention.Tick += new System.EventHandler(this.TmrIntervention_Tick);
            // 
            // TmrUtilisateurs
            // 
            this.TmrUtilisateurs.Interval = 10;
            // 
            // TmrProduits
            // 
            this.TmrProduits.Interval = 10;
            this.TmrProduits.Tick += new System.EventHandler(this.TmrProduits_Tick);
            // 
            // TmrClient
            // 
            this.TmrClient.Interval = 10;
            this.TmrClient.Tick += new System.EventHandler(this.TmrClient_Tick);
            // 
            // tmrRequest
            // 
            this.tmrRequest.Interval = 10;
            this.tmrRequest.Tick += new System.EventHandler(this.TmrRequest_Tick);
            // 
            // TmrParms
            // 
            this.TmrParms.Interval = 10;
            this.TmrParms.Tick += new System.EventHandler(this.TmrParms_Tick);
            // 
            // tmrReal
            // 
            this.tmrReal.Enabled = true;
            this.tmrReal.Interval = 1000;
            this.tmrReal.Tick += new System.EventHandler(this.tmrReal_Tick);
            // 
            // getRealdata
            // 
            this.getRealdata.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getRealdata_DoWork);
            this.getRealdata.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.getRealdata_RunWorkerCompleted);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.PanelHeader;
            // 
            // FrmDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 590);
            this.Controls.Add(this.FrmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDefault";
            this.Load += new System.EventHandler(this.FrmDefault_Load);
            this.panel2.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.DropdownUserMenu.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
            this.pnlUserName.ResumeLayout(false);
            this.pnlUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PickBell)).EndInit();
            this.PanelLeftSide.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.DropIntervention.ResumeLayout(false);
            this.DropParametre.ResumeLayout(false);
            this.DropProduit.ResumeLayout(false);
            this.DropClient.ResumeLayout(false);
            this.DropDemande.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.FrmPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel DropdownUserMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Button btnProfile;
        public System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Panel lineVertical;
        private System.Windows.Forms.PictureBox PickBell;
        private System.Windows.Forms.Panel PanelLeftSide;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel DropClient;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Panel DropProduit;
        private System.Windows.Forms.Button btnListProduct;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label lblLogoName;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel FrmPanel;
        private System.Windows.Forms.Timer tmrIntervention;
        private System.Windows.Forms.Timer TmrUtilisateurs;
        private System.Windows.Forms.Timer TmrProduits;
        private System.Windows.Forms.Timer TmrClient;
        private System.Windows.Forms.Timer tmrRequest;
        private ucControls.DragControl dragControl1;
        private System.Windows.Forms.Panel pnlUserName;
        private System.Windows.Forms.PictureBox PicShowMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DropDemande;
        private System.Windows.Forms.Button btnDemandeAttent;
        private System.Windows.Forms.Button btnListDemande;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnDemandeCours;
        private System.Windows.Forms.Label lblTotalRequest;
        private System.Windows.Forms.Panel DropParametre;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.Timer TmrParms;
        private System.Windows.Forms.PictureBox PicBack;
        private System.Windows.Forms.Label lblRequestCours;
        private System.Windows.Forms.Label lblRequestRetard;
        private System.Windows.Forms.Panel DropIntervention;
        private System.Windows.Forms.Label lblIntereventionCours;
        private System.Windows.Forms.Label lblInterventionRetard;
        private System.Windows.Forms.Label lblTotalIntervention;
        private System.Windows.Forms.Button btnInterventionRetard;
        private System.Windows.Forms.Button btnInterventionCours;
        private System.Windows.Forms.Button btnListIntervention;
        private System.Windows.Forms.Button btnIntervention;
        private System.Windows.Forms.Button btnDemandeRetard;
        private System.Windows.Forms.Button btnInterventionTerminer;
        private System.Windows.Forms.Label lblRequestTerminer;
        private System.Windows.Forms.Label lblInterventionTerminer;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnTypeProduct;
        private System.Windows.Forms.Timer tmrReal;
        private System.Windows.Forms.Timer tmrRetard;
        private System.ComponentModel.BackgroundWorker getRealdata;
        private System.Windows.Forms.Button btnDemandeTerminer;
        private System.Windows.Forms.Label lblRequestAttente;
        private System.Windows.Forms.Button btnSettings;
        public System.Windows.Forms.Panel pnlLogo;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Button BtnListClient;
        public System.Windows.Forms.Button BtnCreateClient;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}