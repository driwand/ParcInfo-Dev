namespace ParcInfo.ucClient
{
    partial class ListClients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.CkDeletedClient = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.lblEditedDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblEdited = new System.Windows.Forms.LinkLabel();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnCons = new System.Windows.Forms.Button();
            this.btnStartIntervention = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpDemande = new ParcInfo.Classes.GradientPanel();
            this.lblDemC = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gpEmployee = new ParcInfo.Classes.GradientPanel();
            this.lblEmpC = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.gpProduit = new ParcInfo.Classes.GradientPanel();
            this.lblProdC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gpIntervention = new ParcInfo.Classes.GradientPanel();
            this.lblInterC = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpDemande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.gpProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gpIntervention.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Clients";
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.AllowUserToDeleteRows = false;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(14, 104);
            this.dgClients.Name = "dgClients";
            this.dgClients.ReadOnly = true;
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(716, 351);
            this.dgClients.TabIndex = 4;
            this.dgClients.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_RowEnter);
            this.dgClients.DoubleClick += new System.EventHandler(this.GridListClient_DoubleClick);
            // 
            // CkDeletedClient
            // 
            this.CkDeletedClient.AutoSize = true;
            this.CkDeletedClient.Location = new System.Drawing.Point(14, 460);
            this.CkDeletedClient.Name = "CkDeletedClient";
            this.CkDeletedClient.Size = new System.Drawing.Size(171, 17);
            this.CkDeletedClient.TabIndex = 55;
            this.CkDeletedClient.Text = "Afficher les elements supprimer";
            this.CkDeletedClient.UseVisualStyleBackColor = true;
            this.CkDeletedClient.CheckedChanged += new System.EventHandler(this.CkDeletedClient_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Dernier modification par :";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(372, 462);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(61, 13);
            this.lblMod.TabIndex = 61;
            this.lblMod.Text = "Modifier le :";
            // 
            // lblEditedDate
            // 
            this.lblEditedDate.AutoSize = true;
            this.lblEditedDate.Location = new System.Drawing.Point(430, 462);
            this.lblEditedDate.Name = "lblEditedDate";
            this.lblEditedDate.Size = new System.Drawing.Size(65, 13);
            this.lblEditedDate.TabIndex = 61;
            this.lblEditedDate.Text = "2018/08/08";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(191, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 15);
            this.panel2.TabIndex = 62;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(14, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 50);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.Find16;
            this.btnFind.Location = new System.Drawing.Point(552, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(101, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(445, 20);
            this.txtFind.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filtrer les client";
            // 
            // lblEdited
            // 
            this.lblEdited.AutoSize = true;
            this.lblEdited.Location = new System.Drawing.Point(325, 462);
            this.lblEdited.Name = "lblEdited";
            this.lblEdited.Size = new System.Drawing.Size(43, 13);
            this.lblEdited.TabIndex = 88;
            this.lblEdited.TabStop = true;
            this.lblEdited.Text = "aucune";
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.White;
            this.btnNewClient.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnNewClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewClient.Location = new System.Drawing.Point(612, 57);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(118, 35);
            this.btnNewClient.TabIndex = 87;
            this.btnNewClient.Text = "  Nouveau";
            this.btnNewClient.UseVisualStyleBackColor = false;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnCons
            // 
            this.btnCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnCons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCons.ForeColor = System.Drawing.Color.White;
            this.btnCons.Image = global::ParcInfo.Properties.Resources.details;
            this.btnCons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCons.Location = new System.Drawing.Point(736, 420);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(141, 35);
            this.btnCons.TabIndex = 54;
            this.btnCons.Text = "    Consulter";
            this.btnCons.UseVisualStyleBackColor = false;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // btnStartIntervention
            // 
            this.btnStartIntervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnStartIntervention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartIntervention.ForeColor = System.Drawing.Color.White;
            this.btnStartIntervention.Image = global::ParcInfo.Properties.Resources.start;
            this.btnStartIntervention.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartIntervention.Location = new System.Drawing.Point(736, 57);
            this.btnStartIntervention.Name = "btnStartIntervention";
            this.btnStartIntervention.Size = new System.Drawing.Size(141, 35);
            this.btnStartIntervention.TabIndex = 52;
            this.btnStartIntervention.Text = "      Demarer Intervention";
            this.btnStartIntervention.UseVisualStyleBackColor = false;
            this.btnStartIntervention.Click += new System.EventHandler(this.btnStartIntervention_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.listForms;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // gpDemande
            // 
            this.gpDemande.Angle = 0F;
            this.gpDemande.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(126)))));
            this.gpDemande.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.gpDemande.Controls.Add(this.lblDemC);
            this.gpDemande.Controls.Add(this.panel6);
            this.gpDemande.Controls.Add(this.label12);
            this.gpDemande.Controls.Add(this.pictureBox6);
            this.gpDemande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpDemande.Location = new System.Drawing.Point(736, 262);
            this.gpDemande.Name = "gpDemande";
            this.gpDemande.Size = new System.Drawing.Size(141, 73);
            this.gpDemande.TabIndex = 58;
            this.gpDemande.Click += new System.EventHandler(this.gpDemande_Click);
            // 
            // lblDemC
            // 
            this.lblDemC.AutoSize = true;
            this.lblDemC.BackColor = System.Drawing.Color.Transparent;
            this.lblDemC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDemC.Location = new System.Drawing.Point(72, 39);
            this.lblDemC.Name = "lblDemC";
            this.lblDemC.Size = new System.Drawing.Size(24, 16);
            this.lblDemC.TabIndex = 9;
            this.lblDemC.Text = "30";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel6.Location = new System.Drawing.Point(50, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(70, 1);
            this.panel6.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(55, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Demandes";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::ParcInfo.Properties.Resources.Demandes;
            this.pictureBox6.Location = new System.Drawing.Point(6, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // gpEmployee
            // 
            this.gpEmployee.Angle = 0F;
            this.gpEmployee.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(119)))), ((int)(((byte)(206)))));
            this.gpEmployee.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.gpEmployee.Controls.Add(this.lblEmpC);
            this.gpEmployee.Controls.Add(this.panel5);
            this.gpEmployee.Controls.Add(this.label7);
            this.gpEmployee.Controls.Add(this.pictureBox5);
            this.gpEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpEmployee.Location = new System.Drawing.Point(736, 104);
            this.gpEmployee.Name = "gpEmployee";
            this.gpEmployee.Size = new System.Drawing.Size(141, 73);
            this.gpEmployee.TabIndex = 58;
            this.gpEmployee.Click += new System.EventHandler(this.gpEmployee_Click);
            // 
            // lblEmpC
            // 
            this.lblEmpC.AutoSize = true;
            this.lblEmpC.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpC.Location = new System.Drawing.Point(74, 39);
            this.lblEmpC.Name = "lblEmpC";
            this.lblEmpC.Size = new System.Drawing.Size(24, 16);
            this.lblEmpC.TabIndex = 9;
            this.lblEmpC.Text = "30";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel5.Location = new System.Drawing.Point(52, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 1);
            this.panel5.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(55, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Employees";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ParcInfo.Properties.Resources.Employe;
            this.pictureBox5.Location = new System.Drawing.Point(6, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // gpProduit
            // 
            this.gpProduit.Angle = 0F;
            this.gpProduit.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(185)))), ((int)(((byte)(244)))));
            this.gpProduit.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.gpProduit.Controls.Add(this.lblProdC);
            this.gpProduit.Controls.Add(this.panel3);
            this.gpProduit.Controls.Add(this.label5);
            this.gpProduit.Controls.Add(this.pictureBox4);
            this.gpProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpProduit.Location = new System.Drawing.Point(736, 341);
            this.gpProduit.Name = "gpProduit";
            this.gpProduit.Size = new System.Drawing.Size(141, 73);
            this.gpProduit.TabIndex = 57;
            this.gpProduit.Click += new System.EventHandler(this.gpProduit_Click);
            // 
            // lblProdC
            // 
            this.lblProdC.AutoSize = true;
            this.lblProdC.BackColor = System.Drawing.Color.Transparent;
            this.lblProdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProdC.Location = new System.Drawing.Point(74, 39);
            this.lblProdC.Name = "lblProdC";
            this.lblProdC.Size = new System.Drawing.Size(24, 16);
            this.lblProdC.TabIndex = 9;
            this.lblProdC.Text = "30";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel3.Location = new System.Drawing.Point(52, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 1);
            this.panel3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(62, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Produits";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // gpIntervention
            // 
            this.gpIntervention.Angle = 0F;
            this.gpIntervention.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(229)))), ((int)(((byte)(190)))));
            this.gpIntervention.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(208)))), ((int)(((byte)(148)))));
            this.gpIntervention.Controls.Add(this.lblInterC);
            this.gpIntervention.Controls.Add(this.panel4);
            this.gpIntervention.Controls.Add(this.label9);
            this.gpIntervention.Controls.Add(this.pictureBox2);
            this.gpIntervention.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpIntervention.Location = new System.Drawing.Point(736, 183);
            this.gpIntervention.Name = "gpIntervention";
            this.gpIntervention.Size = new System.Drawing.Size(141, 73);
            this.gpIntervention.TabIndex = 56;
            this.gpIntervention.Click += new System.EventHandler(this.gpIntervention_Click);
            // 
            // lblInterC
            // 
            this.lblInterC.AutoSize = true;
            this.lblInterC.BackColor = System.Drawing.Color.Transparent;
            this.lblInterC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInterC.Location = new System.Drawing.Point(73, 39);
            this.lblInterC.Name = "lblInterC";
            this.lblInterC.Size = new System.Drawing.Size(24, 16);
            this.lblInterC.TabIndex = 9;
            this.lblInterC.Text = "30";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel4.Location = new System.Drawing.Point(51, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 1);
            this.panel4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(52, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Inteventions";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ParcInfo.Properties.Resources.Employe;
            this.pictureBox2.Location = new System.Drawing.Point(6, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEdited);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEditedDate);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.gpDemande);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gpEmployee);
            this.Controls.Add(this.gpProduit);
            this.Controls.Add(this.gpIntervention);
            this.Controls.Add(this.CkDeletedClient);
            this.Controls.Add(this.btnCons);
            this.Controls.Add(this.btnStartIntervention);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ListClients";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.ListClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpDemande.ResumeLayout(false);
            this.gpDemande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gpEmployee.ResumeLayout(false);
            this.gpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.gpProduit.ResumeLayout(false);
            this.gpProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gpIntervention.ResumeLayout(false);
            this.gpIntervention.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Button btnCons;
        private System.Windows.Forms.Button btnStartIntervention;
        private System.Windows.Forms.CheckBox CkDeletedClient;
        private Classes.GradientPanel gpIntervention;
        private System.Windows.Forms.Label lblInterC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Classes.GradientPanel gpProduit;
        private System.Windows.Forms.Label lblProdC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Classes.GradientPanel gpEmployee;
        private System.Windows.Forms.Label lblEmpC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Classes.GradientPanel gpDemande;
        private System.Windows.Forms.Label lblDemC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label lblEditedDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.LinkLabel lblEdited;
    }
}
