namespace ParcInfo.ucClient
{
    partial class frmCreateEmploye
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
            this.dragControl1 = new ParcInfo.ucControls.DragControl();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.gbEmploye = new System.Windows.Forms.GroupBox();
            this.txtDeaprt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRespo = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelEmp = new System.Windows.Forms.Button();
            this.gbEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Location = new System.Drawing.Point(198, 446);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 28);
            this.btnAnnuler.TabIndex = 56;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(317, 446);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 28);
            this.btnAjouter.TabIndex = 55;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // gbEmploye
            // 
            this.gbEmploye.Controls.Add(this.txtDeaprt);
            this.gbEmploye.Controls.Add(this.label6);
            this.gbEmploye.Controls.Add(this.cbRespo);
            this.gbEmploye.Controls.Add(this.txtEmail);
            this.gbEmploye.Controls.Add(this.label2);
            this.gbEmploye.Controls.Add(this.txtTel);
            this.gbEmploye.Controls.Add(this.txtPrenom);
            this.gbEmploye.Controls.Add(this.txtNom);
            this.gbEmploye.Controls.Add(this.label5);
            this.gbEmploye.Controls.Add(this.label4);
            this.gbEmploye.Controls.Add(this.label3);
            this.gbEmploye.Location = new System.Drawing.Point(21, 58);
            this.gbEmploye.Name = "gbEmploye";
            this.gbEmploye.Size = new System.Drawing.Size(409, 382);
            this.gbEmploye.TabIndex = 54;
            this.gbEmploye.TabStop = false;
            this.gbEmploye.Text = "Employe";
            // 
            // txtDeaprt
            // 
            this.txtDeaprt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDeaprt.FormattingEnabled = true;
            this.txtDeaprt.Location = new System.Drawing.Point(89, 182);
            this.txtDeaprt.Name = "txtDeaprt";
            this.txtDeaprt.Size = new System.Drawing.Size(134, 21);
            this.txtDeaprt.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Departement :";
            // 
            // cbRespo
            // 
            this.cbRespo.AutoSize = true;
            this.cbRespo.Location = new System.Drawing.Point(89, 221);
            this.cbRespo.Name = "cbRespo";
            this.cbRespo.Size = new System.Drawing.Size(121, 17);
            this.cbRespo.TabIndex = 45;
            this.cbRespo.Text = "C\'es un responsable";
            this.cbRespo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 20);
            this.txtEmail.TabIndex = 44;
            this.txtEmail.Tag = "required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Email :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(89, 104);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(267, 20);
            this.txtTel.TabIndex = 42;
            this.txtTel.Tag = "required";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(89, 65);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(267, 20);
            this.txtPrenom.TabIndex = 41;
            this.txtPrenom.Tag = "required";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(89, 26);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(267, 20);
            this.txtNom.TabIndex = 40;
            this.txtNom.Tag = "required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Tel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nom :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(21, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 2);
            this.panel1.TabIndex = 53;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(59, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(129, 15);
            this.lblHeading.TabIndex = 51;
            this.lblHeading.Text = "Nouveau employee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.addForms;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelEmp
            // 
            this.btnDelEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEmp.ForeColor = System.Drawing.Color.White;
            this.btnDelEmp.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.btnDelEmp.Location = new System.Drawing.Point(21, 446);
            this.btnDelEmp.Name = "btnDelEmp";
            this.btnDelEmp.Size = new System.Drawing.Size(28, 28);
            this.btnDelEmp.TabIndex = 10016;
            this.btnDelEmp.UseVisualStyleBackColor = false;
            this.btnDelEmp.Visible = false;
            this.btnDelEmp.Click += new System.EventHandler(this.btnDelEmp_Click);
            // 
            // frmCreateEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 500);
            this.Controls.Add(this.btnDelEmp);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbEmploye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCreateEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateEmploye";
            this.gbEmploye.ResumeLayout(false);
            this.gbEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucControls.DragControl dragControl1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox gbEmploye;
        private System.Windows.Forms.ComboBox txtDeaprt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbRespo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelEmp;
    }
}