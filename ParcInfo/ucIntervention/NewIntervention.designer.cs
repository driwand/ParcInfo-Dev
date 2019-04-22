namespace ParcInfo.ucInterevntion
{
    partial class NewIntervention
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewIntervention));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numHeur = new System.Windows.Forms.NumericUpDown();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnDelInt = new System.Windows.Forms.Button();
            this.lblModifierPar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDateModification = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIntervention = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddDexcription = new System.Windows.Forms.Button();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gpDemandeActivite = new System.Windows.Forms.GroupBox();
            this.pnlObservetion = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlStatut = new System.Windows.Forms.Panel();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblStatut = new System.Windows.Forms.Label();
            this.tmrDone = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gpDemandeActivite.SuspendLayout();
            this.pnlStatut.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Lieux :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numHeur);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.btnDelInt);
            this.groupBox1.Controls.Add(this.lblModifierPar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblDateModification);
            this.groupBox1.Controls.Add(this.cbPlace);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtFin);
            this.groupBox1.Controls.Add(this.dtDebut);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 348);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // numHeur
            // 
            this.numHeur.Location = new System.Drawing.Point(100, 195);
            this.numHeur.Name = "numHeur";
            this.numHeur.Size = new System.Drawing.Size(90, 20);
            this.numHeur.TabIndex = 132;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSource.ForeColor = System.Drawing.Color.Blue;
            this.lblSource.Location = new System.Drawing.Point(97, 27);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(57, 13);
            this.lblSource.TabIndex = 131;
            this.lblSource.Text = "[Id source]";
            this.lblSource.Click += new System.EventHandler(this.lblSource_Click);
            // 
            // btnDelInt
            // 
            this.btnDelInt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelInt.ForeColor = System.Drawing.Color.White;
            this.btnDelInt.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.btnDelInt.Location = new System.Drawing.Point(14, 308);
            this.btnDelInt.Name = "btnDelInt";
            this.btnDelInt.Size = new System.Drawing.Size(32, 28);
            this.btnDelInt.TabIndex = 130;
            this.btnDelInt.UseVisualStyleBackColor = false;
            this.btnDelInt.Click += new System.EventHandler(this.btnDelInt_Click);
            // 
            // lblModifierPar
            // 
            this.lblModifierPar.AutoSize = true;
            this.lblModifierPar.Location = new System.Drawing.Point(125, 267);
            this.lblModifierPar.Name = "lblModifierPar";
            this.lblModifierPar.Size = new System.Drawing.Size(35, 13);
            this.lblModifierPar.TabIndex = 52;
            this.lblModifierPar.Text = "User1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Nombre heur :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Modifier par :";
            // 
            // lblDateModification
            // 
            this.lblDateModification.AutoSize = true;
            this.lblDateModification.Location = new System.Drawing.Point(125, 237);
            this.lblDateModification.Name = "lblDateModification";
            this.lblDateModification.Size = new System.Drawing.Size(65, 13);
            this.lblDateModification.TabIndex = 50;
            this.lblDateModification.Text = "[4/12/2019]";
            // 
            // cbPlace
            // 
            this.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Items.AddRange(new object[] {
            "Site",
            "A distance"});
            this.cbPlace.Location = new System.Drawing.Point(100, 90);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(155, 21);
            this.cbPlace.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Date de modification:";
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(100, 159);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(155, 20);
            this.dtFin.TabIndex = 44;
            // 
            // dtDebut
            // 
            this.dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDebut.Location = new System.Drawing.Point(100, 125);
            this.dtDebut.Name = "dtDebut";
            this.dtDebut.Size = new System.Drawing.Size(155, 20);
            this.dtDebut.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Date Fin :";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Maintenance",
            "Reparation",
            "Installation"});
            this.cbType.Location = new System.Drawing.Point(100, 55);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(155, 21);
            this.cbType.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Date Debut :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(173, 308);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 28);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Type :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.addForms;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // lblIntervention
            // 
            this.lblIntervention.AutoSize = true;
            this.lblIntervention.Location = new System.Drawing.Point(143, 21);
            this.lblIntervention.Name = "lblIntervention";
            this.lblIntervention.Size = new System.Drawing.Size(62, 13);
            this.lblIntervention.TabIndex = 45;
            this.lblIntervention.Text = "[INTV0001]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddDexcription);
            this.groupBox3.Controls.Add(this.txtAddDescription);
            this.groupBox3.Location = new System.Drawing.Point(307, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 83);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // btnAddDexcription
            // 
            this.btnAddDexcription.BackColor = System.Drawing.Color.White;
            this.btnAddDexcription.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddDexcription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDexcription.ForeColor = System.Drawing.Color.White;
            this.btnAddDexcription.Image = global::ParcInfo.Properties.Resources.icons8_paper_plane_30;
            this.btnAddDexcription.Location = new System.Drawing.Point(464, 21);
            this.btnAddDexcription.Name = "btnAddDexcription";
            this.btnAddDexcription.Size = new System.Drawing.Size(51, 51);
            this.btnAddDexcription.TabIndex = 65;
            this.btnAddDexcription.UseVisualStyleBackColor = false;
            this.btnAddDexcription.Click += new System.EventHandler(this.btnAddDexcription_Click);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(14, 21);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(451, 51);
            this.txtAddDescription.TabIndex = 0;
            this.txtAddDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddDescription_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 69;
            this.label1.Text = "Intervention";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(19, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 2);
            this.panel1.TabIndex = 71;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(836, 384);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(37, 74);
            this.btnAddProduct.TabIndex = 66;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // gpDemandeActivite
            // 
            this.gpDemandeActivite.Controls.Add(this.pnlObservetion);
            this.gpDemandeActivite.Location = new System.Drawing.Point(307, 63);
            this.gpDemandeActivite.Name = "gpDemandeActivite";
            this.gpDemandeActivite.Size = new System.Drawing.Size(566, 297);
            this.gpDemandeActivite.TabIndex = 75;
            this.gpDemandeActivite.TabStop = false;
            this.gpDemandeActivite.Text = "Demande et activites";
            // 
            // pnlObservetion
            // 
            this.pnlObservetion.AutoScroll = true;
            this.pnlObservetion.Location = new System.Drawing.Point(18, 32);
            this.pnlObservetion.Name = "pnlObservetion";
            this.pnlObservetion.Padding = new System.Windows.Forms.Padding(3);
            this.pnlObservetion.Size = new System.Drawing.Size(529, 250);
            this.pnlObservetion.TabIndex = 0;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(238, 21);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(122, 13);
            this.lblDetails.TabIndex = 79;
            this.lblDetails.Text = "[Client,employee,produit]";
            // 
            // pnlStatut
            // 
            this.pnlStatut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(49)))));
            this.pnlStatut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatut.Controls.Add(this.btnDone);
            this.pnlStatut.Controls.Add(this.lblStatut);
            this.pnlStatut.Location = new System.Drawing.Point(15, 69);
            this.pnlStatut.Name = "pnlStatut";
            this.pnlStatut.Size = new System.Drawing.Size(275, 35);
            this.pnlStatut.TabIndex = 80;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Image = global::ParcInfo.Properties.Resources.icons8_checkmark_201;
            this.btnDone.Location = new System.Drawing.Point(240, 0);
            this.btnDone.Margin = new System.Windows.Forms.Padding(0);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(33, 33);
            this.btnDone.TabIndex = 67;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.ForeColor = System.Drawing.Color.White;
            this.lblStatut.Location = new System.Drawing.Point(91, 7);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(68, 18);
            this.lblStatut.TabIndex = 0;
            this.lblStatut.Text = "En cours";
            // 
            // tmrDone
            // 
            this.tmrDone.Tick += new System.EventHandler(this.tmrDone_Tick);
            // 
            // NewIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.pnlStatut);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIntervention);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpDemandeActivite);
            this.Name = "NewIntervention";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.NewIntervention_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpDemandeActivite.ResumeLayout(false);
            this.pnlStatut.ResumeLayout(false);
            this.pnlStatut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelInt;
        public System.Windows.Forms.Label lblModifierPar;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblDateModification;
        public System.Windows.Forms.ComboBox cbPlace;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker dtFin;
        public System.Windows.Forms.DateTimePicker dtDebut;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblIntervention;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnAddDexcription;
        public System.Windows.Forms.TextBox txtAddDescription;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.GroupBox gpDemandeActivite;
        public System.Windows.Forms.FlowLayoutPanel pnlObservetion;
        public System.Windows.Forms.Label lblDetails;
        public System.Windows.Forms.Button btnDone;
        public System.Windows.Forms.Label lblSource;
        public System.Windows.Forms.NumericUpDown numHeur;
        private System.Windows.Forms.Timer tmrDone;
        public System.Windows.Forms.Panel pnlStatut;
        public System.Windows.Forms.Label lblStatut;
    }
}
