namespace ParcInfo.ucParametre
{
    partial class userProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpPass = new System.Windows.Forms.GroupBox();
            this.gradientPanel2 = new ParcInfo.Classes.GradientPanel();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpInfo.SuspendLayout();
            this.grpPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mon profil";
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.txtEmail);
            this.gpInfo.Controls.Add(this.txtTel);
            this.gpInfo.Controls.Add(this.txtVille);
            this.gpInfo.Controls.Add(this.txtAdr);
            this.gpInfo.Controls.Add(this.txtPrenom);
            this.gpInfo.Controls.Add(this.txtNom);
            this.gpInfo.Controls.Add(this.label10);
            this.gpInfo.Controls.Add(this.gradientPanel1);
            this.gpInfo.Controls.Add(this.label6);
            this.gpInfo.Controls.Add(this.label5);
            this.gpInfo.Controls.Add(this.label4);
            this.gpInfo.Controls.Add(this.label2);
            this.gpInfo.Controls.Add(this.label3);
            this.gpInfo.Location = new System.Drawing.Point(14, 49);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gpInfo.Size = new System.Drawing.Size(398, 220);
            this.gpInfo.TabIndex = 38;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Information personnel";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 59;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(81, 145);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(280, 20);
            this.txtTel.TabIndex = 58;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(81, 116);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(280, 20);
            this.txtVille.TabIndex = 57;
            // 
            // txtAdr
            // 
            this.txtAdr.Location = new System.Drawing.Point(81, 87);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(280, 20);
            this.txtAdr.TabIndex = 56;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(81, 58);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(280, 20);
            this.txtPrenom.TabIndex = 55;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(81, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(280, 20);
            this.txtNom.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Tel :";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 217);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(398, 3);
            this.gradientPanel1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ville :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nom :";
            // 
            // grpPass
            // 
            this.grpPass.Controls.Add(this.gradientPanel2);
            this.grpPass.Controls.Add(this.txtConfPass);
            this.grpPass.Controls.Add(this.label9);
            this.grpPass.Controls.Add(this.txtNewPass);
            this.grpPass.Controls.Add(this.label8);
            this.grpPass.Controls.Add(this.txtOldPass);
            this.grpPass.Controls.Add(this.label7);
            this.grpPass.Location = new System.Drawing.Point(14, 275);
            this.grpPass.Name = "grpPass";
            this.grpPass.Padding = new System.Windows.Forms.Padding(0);
            this.grpPass.Size = new System.Drawing.Size(398, 152);
            this.grpPass.TabIndex = 39;
            this.grpPass.TabStop = false;
            this.grpPass.Text = "Changer votre mot de passe";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 149);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(398, 3);
            this.gradientPanel2.TabIndex = 57;
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(143, 105);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(218, 20);
            this.txtConfPass.TabIndex = 56;
            this.txtConfPass.Tag = "required";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Confirmation :";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(143, 68);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(218, 20);
            this.txtNewPass.TabIndex = 54;
            this.txtNewPass.Tag = "required";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Nouveau mot de passe :";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(143, 31);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(218, 20);
            this.txtOldPass.TabIndex = 52;
            this.txtOldPass.Tag = "required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Mot de passe actuel :";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Image = global::ParcInfo.Properties.Resources.edit;
            this.btnEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProfile.Location = new System.Drawing.Point(299, 433);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(113, 28);
            this.btnEditProfile.TabIndex = 10015;
            this.btnEditProfile.Text = "   Enregister";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // userProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.grpPass);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "userProfile";
            this.Size = new System.Drawing.Size(890, 481);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.grpPass.ResumeLayout(false);
            this.grpPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.GroupBox grpPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label7;
        private Classes.GradientPanel gradientPanel1;
        private Classes.GradientPanel gradientPanel2;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label10;
    }
}
