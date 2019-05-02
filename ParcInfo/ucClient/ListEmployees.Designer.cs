namespace ParcInfo.ucClient
{
    partial class ListEmployees
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEditedDate = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDeleted = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnEditEmploye = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEdited = new System.Windows.Forms.LinkLabel();
            this.gpProduits = new ParcInfo.Classes.GradientPanel();
            this.produitCount = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gpDemandeRetard = new ParcInfo.Classes.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.enretardCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gpDemandeEnCours = new ParcInfo.Classes.GradientPanel();
            this.encoursCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpDemande = new ParcInfo.Classes.GradientPanel();
            this.allCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gpDemandeRetard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gpDemandeEnCours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpDemande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(191, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 15);
            this.panel2.TabIndex = 84;
            // 
            // lblEditedDate
            // 
            this.lblEditedDate.AutoSize = true;
            this.lblEditedDate.Location = new System.Drawing.Point(437, 462);
            this.lblEditedDate.Name = "lblEditedDate";
            this.lblEditedDate.Size = new System.Drawing.Size(65, 13);
            this.lblEditedDate.TabIndex = 83;
            this.lblEditedDate.Text = "2018/08/08";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(379, 462);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(61, 13);
            this.lblMod.TabIndex = 82;
            this.lblMod.Text = "Modifier le :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Dernier modification par :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(14, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 50);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.Find16;
            this.btnFind.Location = new System.Drawing.Point(682, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(126, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(550, 20);
            this.txtFind.TabIndex = 42;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filtrer les employees";
            // 
            // cbDeleted
            // 
            this.cbDeleted.AutoSize = true;
            this.cbDeleted.Location = new System.Drawing.Point(14, 460);
            this.cbDeleted.Name = "cbDeleted";
            this.cbDeleted.Size = new System.Drawing.Size(171, 17);
            this.cbDeleted.TabIndex = 75;
            this.cbDeleted.Text = "Afficher les elements supprimer";
            this.cbDeleted.UseVisualStyleBackColor = true;
            this.cbDeleted.Click += new System.EventHandler(this.cbDeleted_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "Liste des employees";
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.AllowUserToDeleteRows = false;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Location = new System.Drawing.Point(14, 104);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.ReadOnly = true;
            this.dgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployees.Size = new System.Drawing.Size(716, 351);
            this.dgEmployees.TabIndex = 69;
            this.dgEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_CellDoubleClick);
            this.dgEmployees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_RowEnter);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.White;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.lblClientName.Location = new System.Drawing.Point(197, 16);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(76, 13);
            this.lblClientName.TabIndex = 90;
            this.lblClientName.Text = "[Nom Client]";
            this.lblClientName.Visible = false;
            // 
            // btnEditEmploye
            // 
            this.btnEditEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnEditEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmploye.ForeColor = System.Drawing.Color.White;
            this.btnEditEmploye.Image = global::ParcInfo.Properties.Resources.details;
            this.btnEditEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditEmploye.Location = new System.Drawing.Point(736, 420);
            this.btnEditEmploye.Name = "btnEditEmploye";
            this.btnEditEmploye.Size = new System.Drawing.Size(141, 35);
            this.btnEditEmploye.TabIndex = 74;
            this.btnEditEmploye.Text = "    Consulter";
            this.btnEditEmploye.UseVisualStyleBackColor = false;
            this.btnEditEmploye.Click += new System.EventHandler(this.btnEditEmploye_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployee.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployee.Location = new System.Drawing.Point(736, 57);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(141, 35);
            this.btnNewEmployee.TabIndex = 72;
            this.btnNewEmployee.Text = "  Nouveau";
            this.btnNewEmployee.UseVisualStyleBackColor = false;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmploye_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.listForms;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // lblEdited
            // 
            this.lblEdited.AutoSize = true;
            this.lblEdited.Location = new System.Drawing.Point(330, 462);
            this.lblEdited.Name = "lblEdited";
            this.lblEdited.Size = new System.Drawing.Size(43, 13);
            this.lblEdited.TabIndex = 113;
            this.lblEdited.TabStop = true;
            this.lblEdited.Text = "aucune";
            // 
            // gpProduits
            // 
            this.gpProduits.Angle = 0F;
            this.gpProduits.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(205)))), ((int)(((byte)(207)))));
            this.gpProduits.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.gpProduits.Controls.Add(this.produitCount);
            this.gpProduits.Controls.Add(this.panel6);
            this.gpProduits.Controls.Add(this.label12);
            this.gpProduits.Controls.Add(this.pictureBox6);
            this.gpProduits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpProduits.Location = new System.Drawing.Point(736, 341);
            this.gpProduits.Name = "gpProduits";
            this.gpProduits.Size = new System.Drawing.Size(141, 73);
            this.gpProduits.TabIndex = 111;
            this.gpProduits.Click += new System.EventHandler(this.gpProduits_Click);
            // 
            // produitCount
            // 
            this.produitCount.AutoSize = true;
            this.produitCount.BackColor = System.Drawing.Color.Transparent;
            this.produitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.produitCount.Location = new System.Drawing.Point(77, 41);
            this.produitCount.Name = "produitCount";
            this.produitCount.Size = new System.Drawing.Size(16, 16);
            this.produitCount.TabIndex = 9;
            this.produitCount.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel6.Location = new System.Drawing.Point(51, 49);
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
            this.label12.Location = new System.Drawing.Point(60, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Produits";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::ParcInfo.Properties.Resources.request;
            this.pictureBox6.Location = new System.Drawing.Point(7, 18);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // gpDemandeRetard
            // 
            this.gpDemandeRetard.Angle = 0F;
            this.gpDemandeRetard.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(84)))));
            this.gpDemandeRetard.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(16)))));
            this.gpDemandeRetard.Controls.Add(this.label3);
            this.gpDemandeRetard.Controls.Add(this.enretardCount);
            this.gpDemandeRetard.Controls.Add(this.panel3);
            this.gpDemandeRetard.Controls.Add(this.pictureBox4);
            this.gpDemandeRetard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpDemandeRetard.Location = new System.Drawing.Point(736, 183);
            this.gpDemandeRetard.Name = "gpDemandeRetard";
            this.gpDemandeRetard.Size = new System.Drawing.Size(141, 73);
            this.gpDemandeRetard.TabIndex = 110;
            this.gpDemandeRetard.Click += new System.EventHandler(this.gpDemandeRetard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(55, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Demande en\r\n     retard";
            // 
            // enretardCount
            // 
            this.enretardCount.AutoSize = true;
            this.enretardCount.BackColor = System.Drawing.Color.Transparent;
            this.enretardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enretardCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enretardCount.Location = new System.Drawing.Point(77, 42);
            this.enretardCount.Name = "enretardCount";
            this.enretardCount.Size = new System.Drawing.Size(16, 16);
            this.enretardCount.TabIndex = 9;
            this.enretardCount.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel3.Location = new System.Drawing.Point(51, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 1);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::ParcInfo.Properties.Resources.request;
            this.pictureBox4.Location = new System.Drawing.Point(7, 18);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // gpDemandeEnCours
            // 
            this.gpDemandeEnCours.Angle = 0F;
            this.gpDemandeEnCours.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(193)))), ((int)(((byte)(231)))));
            this.gpDemandeEnCours.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(176)))), ((int)(((byte)(224)))));
            this.gpDemandeEnCours.Controls.Add(this.encoursCount);
            this.gpDemandeEnCours.Controls.Add(this.panel4);
            this.gpDemandeEnCours.Controls.Add(this.label9);
            this.gpDemandeEnCours.Controls.Add(this.pictureBox2);
            this.gpDemandeEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpDemandeEnCours.Location = new System.Drawing.Point(736, 104);
            this.gpDemandeEnCours.Name = "gpDemandeEnCours";
            this.gpDemandeEnCours.Size = new System.Drawing.Size(141, 73);
            this.gpDemandeEnCours.TabIndex = 109;
            this.gpDemandeEnCours.Click += new System.EventHandler(this.gpDemandeEnCours_Click);
            // 
            // encoursCount
            // 
            this.encoursCount.AutoSize = true;
            this.encoursCount.BackColor = System.Drawing.Color.Transparent;
            this.encoursCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encoursCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.encoursCount.Location = new System.Drawing.Point(77, 38);
            this.encoursCount.Name = "encoursCount";
            this.encoursCount.Size = new System.Drawing.Size(16, 16);
            this.encoursCount.TabIndex = 9;
            this.encoursCount.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel4.Location = new System.Drawing.Point(52, 45);
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
            this.label9.Location = new System.Drawing.Point(55, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Demande en \r\n     cours";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ParcInfo.Properties.Resources.request;
            this.pictureBox2.Location = new System.Drawing.Point(7, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // gpDemande
            // 
            this.gpDemande.Angle = 0F;
            this.gpDemande.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(131)))), ((int)(((byte)(231)))));
            this.gpDemande.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.gpDemande.Controls.Add(this.allCount);
            this.gpDemande.Controls.Add(this.panel5);
            this.gpDemande.Controls.Add(this.label7);
            this.gpDemande.Controls.Add(this.pictureBox5);
            this.gpDemande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpDemande.Location = new System.Drawing.Point(736, 262);
            this.gpDemande.Name = "gpDemande";
            this.gpDemande.Size = new System.Drawing.Size(141, 73);
            this.gpDemande.TabIndex = 112;
            this.gpDemande.Click += new System.EventHandler(this.gpDemande_Click);
            // 
            // allCount
            // 
            this.allCount.AutoSize = true;
            this.allCount.BackColor = System.Drawing.Color.Transparent;
            this.allCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allCount.Location = new System.Drawing.Point(77, 44);
            this.allCount.Name = "allCount";
            this.allCount.Size = new System.Drawing.Size(16, 16);
            this.allCount.TabIndex = 9;
            this.allCount.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.panel5.Location = new System.Drawing.Point(51, 51);
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
            this.label7.Location = new System.Drawing.Point(55, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Demandes";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::ParcInfo.Properties.Resources.request;
            this.pictureBox5.Location = new System.Drawing.Point(7, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // ListEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEdited);
            this.Controls.Add(this.gpProduits);
            this.Controls.Add(this.gpDemandeRetard);
            this.Controls.Add(this.gpDemandeEnCours);
            this.Controls.Add(this.gpDemande);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEditedDate);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbDeleted);
            this.Controls.Add(this.btnEditEmploye);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEmployees);
            this.Name = "ListEmployees";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.ListEmployees_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpProduits.ResumeLayout(false);
            this.gpProduits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gpDemandeRetard.ResumeLayout(false);
            this.gpDemandeRetard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gpDemandeEnCours.ResumeLayout(false);
            this.gpDemandeEnCours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpDemande.ResumeLayout(false);
            this.gpDemande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEditedDate;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbDeleted;
        private System.Windows.Forms.Button btnEditEmploye;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Label lblClientName;
        private Classes.GradientPanel gpProduits;
        private System.Windows.Forms.Label produitCount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Classes.GradientPanel gpDemandeRetard;
        private System.Windows.Forms.Label enretardCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Classes.GradientPanel gpDemandeEnCours;
        private System.Windows.Forms.Label encoursCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Classes.GradientPanel gpDemande;
        private System.Windows.Forms.Label allCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblEdited;
    }
}
