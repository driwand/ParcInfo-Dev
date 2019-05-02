namespace ParcInfo.ucParametre
{
    partial class AppSettingcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingcs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpGeneral = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPickIcon = new System.Windows.Forms.Button();
            this.applogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.txtappname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDifferentialBackup = new System.Windows.Forms.Button();
            this.btnFullback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnpicklogo = new System.Windows.Forms.Button();
            this.gradientPanel3 = new ParcInfo.Classes.GradientPanel();
            this.gradientPanel2 = new ParcInfo.Classes.GradientPanel();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.gpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(16, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 2);
            this.panel1.TabIndex = 159;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 157;
            this.label1.Text = "Settings";
            // 
            // gpGeneral
            // 
            this.gpGeneral.Controls.Add(this.btnpicklogo);
            this.gpGeneral.Controls.Add(this.label5);
            this.gpGeneral.Controls.Add(this.applogo);
            this.gpGeneral.Controls.Add(this.gradientPanel1);
            this.gpGeneral.Controls.Add(this.btnPickIcon);
            this.gpGeneral.Controls.Add(this.label3);
            this.gpGeneral.Controls.Add(this.txtappname);
            this.gpGeneral.Controls.Add(this.label2);
            this.gpGeneral.Controls.Add(this.picIcon);
            this.gpGeneral.Location = new System.Drawing.Point(16, 62);
            this.gpGeneral.Name = "gpGeneral";
            this.gpGeneral.Padding = new System.Windows.Forms.Padding(0);
            this.gpGeneral.Size = new System.Drawing.Size(401, 243);
            this.gpGeneral.TabIndex = 160;
            this.gpGeneral.TabStop = false;
            this.gpGeneral.Text = "General";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 165;
            this.label5.Text = "Icon :";
            // 
            // btnPickIcon
            // 
            this.btnPickIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnPickIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickIcon.ForeColor = System.Drawing.Color.White;
            this.btnPickIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPickIcon.Location = new System.Drawing.Point(111, 166);
            this.btnPickIcon.Name = "btnPickIcon";
            this.btnPickIcon.Size = new System.Drawing.Size(76, 24);
            this.btnPickIcon.TabIndex = 164;
            this.btnPickIcon.Text = "pick icon";
            this.btnPickIcon.UseVisualStyleBackColor = false;
            this.btnPickIcon.Click += new System.EventHandler(this.btnPickIcon_Click);
            // 
            // applogo
            // 
            this.applogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applogo.Location = new System.Drawing.Point(111, 89);
            this.applogo.Name = "applogo";
            this.applogo.Size = new System.Drawing.Size(226, 67);
            this.applogo.TabIndex = 162;
            this.applogo.TabStop = false;
            this.applogo.DragDrop += new System.Windows.Forms.DragEventHandler(this.applogo_DragDrop);
            this.applogo.DragEnter += new System.Windows.Forms.DragEventHandler(this.applogo_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logo :";
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Location = new System.Drawing.Point(111, 200);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(31, 28);
            this.picIcon.TabIndex = 164;
            this.picIcon.TabStop = false;
            // 
            // txtappname
            // 
            this.txtappname.Location = new System.Drawing.Point(111, 25);
            this.txtappname.Name = "txtappname";
            this.txtappname.Size = new System.Drawing.Size(245, 20);
            this.txtappname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom Application :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gradientPanel2);
            this.groupBox1.Controls.Add(this.btnDifferentialBackup);
            this.groupBox1.Controls.Add(this.btnFullback);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Location = new System.Drawing.Point(16, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(401, 134);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup and Restore";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(41, 84);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(141, 35);
            this.btnRestore.TabIndex = 162;
            this.btnRestore.Text = "  Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDifferentialBackup
            // 
            this.btnDifferentialBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnDifferentialBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDifferentialBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifferentialBackup.ForeColor = System.Drawing.Color.White;
            this.btnDifferentialBackup.Image = global::ParcInfo.Properties.Resources.deffBackup;
            this.btnDifferentialBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDifferentialBackup.Location = new System.Drawing.Point(41, 34);
            this.btnDifferentialBackup.Name = "btnDifferentialBackup";
            this.btnDifferentialBackup.Size = new System.Drawing.Size(141, 35);
            this.btnDifferentialBackup.TabIndex = 162;
            this.btnDifferentialBackup.Text = "     Differential Backup";
            this.btnDifferentialBackup.UseVisualStyleBackColor = false;
            this.btnDifferentialBackup.Click += new System.EventHandler(this.btnDifferentialBackup_Click);
            // 
            // btnFullback
            // 
            this.btnFullback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFullback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFullback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullback.ForeColor = System.Drawing.Color.White;
            this.btnFullback.Image = ((System.Drawing.Image)(resources.GetObject("btnFullback.Image")));
            this.btnFullback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFullback.Location = new System.Drawing.Point(215, 34);
            this.btnFullback.Name = "btnFullback";
            this.btnFullback.Size = new System.Drawing.Size(141, 35);
            this.btnFullback.TabIndex = 162;
            this.btnFullback.Text = "  Full Backup";
            this.btnFullback.UseVisualStyleBackColor = false;
            this.btnFullback.Click += new System.EventHandler(this.btnFullBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.addForms;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(761, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 35);
            this.btnSave.TabIndex = 163;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numDays);
            this.groupBox2.Controls.Add(this.gradientPanel3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(423, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(447, 59);
            this.groupBox2.TabIndex = 164;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autre";
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(335, 22);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(72, 20);
            this.numDays.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre des jours pour definire le retard d\'une demande :";
            // 
            // btnpicklogo
            // 
            this.btnpicklogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnpicklogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpicklogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpicklogo.ForeColor = System.Drawing.Color.White;
            this.btnpicklogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpicklogo.Location = new System.Drawing.Point(111, 55);
            this.btnpicklogo.Name = "btnpicklogo";
            this.btnpicklogo.Size = new System.Drawing.Size(76, 24);
            this.btnpicklogo.TabIndex = 165;
            this.btnpicklogo.Text = "pick logo";
            this.btnpicklogo.UseVisualStyleBackColor = false;
            this.btnpicklogo.Click += new System.EventHandler(this.btnpicklogo_Click);
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Angle = 0F;
            this.gradientPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 56);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(447, 3);
            this.gradientPanel3.TabIndex = 5;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 131);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(401, 3);
            this.gradientPanel2.TabIndex = 5;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 240);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(401, 3);
            this.gradientPanel1.TabIndex = 5;
            // 
            // AppSettingcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpGeneral);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AppSettingcs";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.AppSettingcs_Load);
            this.gpGeneral.ResumeLayout(false);
            this.gpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpGeneral;
        private System.Windows.Forms.TextBox txtappname;
        private System.Windows.Forms.Label label2;
        private Classes.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Classes.GradientPanel gradientPanel2;
        private System.Windows.Forms.PictureBox applogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnFullback;
        public System.Windows.Forms.Button btnDifferentialBackup;
        public System.Windows.Forms.Button btnRestore;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnPickIcon;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDays;
        private Classes.GradientPanel gradientPanel3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnpicklogo;
    }
}
