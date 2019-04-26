namespace ParcInfo.ucControls
{
    partial class loginCntrl
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
            this.pnlError = new ParcInfo.Classes.GradientPanel();
            this.closeError = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblForget = new System.Windows.Forms.LinkLabel();
            this.pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlError
            // 
            this.pnlError.Angle = 0F;
            this.pnlError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlError.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(159)))), ((int)(((byte)(164)))));
            this.pnlError.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.pnlError.Controls.Add(this.closeError);
            this.pnlError.Controls.Add(this.label3);
            this.pnlError.Location = new System.Drawing.Point(32, 36);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(401, 44);
            this.pnlError.TabIndex = 116;
            this.pnlError.Visible = false;
            // 
            // closeError
            // 
            this.closeError.BackColor = System.Drawing.Color.Transparent;
            this.closeError.Image = global::ParcInfo.Properties.Resources.closec;
            this.closeError.Location = new System.Drawing.Point(372, 12);
            this.closeError.Name = "closeError";
            this.closeError.Size = new System.Drawing.Size(20, 20);
            this.closeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeError.TabIndex = 1;
            this.closeError.TabStop = false;
            this.closeError.Click += new System.EventHandler(this.closeError_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inccorect email or password. Please try again.";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(139, 182);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 39);
            this.btnLogin.TabIndex = 114;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Log in";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ParcInfo.Properties.Resources.Password_48px;
            this.pictureBox3.Location = new System.Drawing.Point(32, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 112;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.InitialImage = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.Location = new System.Drawing.Point(32, 86);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 111;
            this.pictureBox7.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(73, 133);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(360, 28);
            this.txtPassword.TabIndex = 110;
            this.txtPassword.Tag = "required";
            this.txtPassword.Text = "ifwxswIc";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(73, 86);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 28);
            this.txtEmail.TabIndex = 109;
            this.txtEmail.Tag = "required";
            this.txtEmail.Text = "p";
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Location = new System.Drawing.Point(200, 230);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(95, 13);
            this.lblForget.TabIndex = 115;
            this.lblForget.TabStop = true;
            this.lblForget.Text = "Forget Password ?";
            this.lblForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForget_LinkClicked);
            // 
            // loginCntrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlError);
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "loginCntrl";
            this.Size = new System.Drawing.Size(464, 251);
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Classes.GradientPanel pnlError;
        private System.Windows.Forms.PictureBox closeError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.LinkLabel lblForget;
    }
}
