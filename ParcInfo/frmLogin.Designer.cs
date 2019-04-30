namespace ParcInfo
{
    partial class frmLogin
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlError = new ParcInfo.Classes.GradientPanel();
            this.closeError = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.lblForget = new System.Windows.Forms.LinkLabel();
            this.pnlContainer.SuspendLayout();
            this.pnlError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.pnlError);
            this.pnlContainer.Controls.Add(this.btnLogin);
            this.pnlContainer.Controls.Add(this.lblHead);
            this.pnlContainer.Controls.Add(this.pictureBox3);
            this.pnlContainer.Controls.Add(this.pictureBox7);
            this.pnlContainer.Controls.Add(this.txtPassword);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(512, 247);
            this.pnlContainer.TabIndex = 126;
            // 
            // pnlError
            // 
            this.pnlError.Angle = 0F;
            this.pnlError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlError.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(159)))), ((int)(((byte)(164)))));
            this.pnlError.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.pnlError.Controls.Add(this.closeError);
            this.pnlError.Controls.Add(this.label3);
            this.pnlError.Location = new System.Drawing.Point(492, 42);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(396, 44);
            this.pnlError.TabIndex = 131;
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
            this.btnLogin.Location = new System.Drawing.Point(163, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 39);
            this.btnLogin.TabIndex = 130;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(224, 40);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(64, 22);
            this.lblHead.TabIndex = 129;
            this.lblHead.Text = "Log in";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ParcInfo.Properties.Resources.Password_48px;
            this.pictureBox3.Location = new System.Drawing.Point(58, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 128;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.InitialImage = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.Location = new System.Drawing.Point(58, 93);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 127;
            this.pictureBox7.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(94, 140);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(360, 28);
            this.txtPassword.TabIndex = 126;
            this.txtPassword.Tag = "required";
            this.txtPassword.Text = "rIgj93dD";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(94, 93);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 28);
            this.txtEmail.TabIndex = 125;
            this.txtEmail.Tag = "required";
            this.txtEmail.Text = "parcinfoit@gmail.com";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.lblForget);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 247);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(512, 57);
            this.gradientPanel1.TabIndex = 125;
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Location = new System.Drawing.Point(225, 23);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(95, 13);
            this.lblForget.TabIndex = 123;
            this.lblForget.TabStop = true;
            this.lblForget.Text = "Forget Password ?";
            this.lblForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForget_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 304);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblForget;
        private Classes.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel pnlContainer;
        private Classes.GradientPanel pnlError;
        private System.Windows.Forms.PictureBox closeError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
    }
}