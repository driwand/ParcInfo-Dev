namespace ParcInfo.ucControls
{
    partial class ForgetPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.multiLineLabel1 = new ParcInfo.MultiLineLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForget = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "vous avez oublie votre mot de passe ?";
            // 
            // multiLineLabel1
            // 
            this.multiLineLabel1.Location = new System.Drawing.Point(82, 56);
            this.multiLineLabel1.MultiLine = false;
            this.multiLineLabel1.Name = "multiLineLabel1";
            this.multiLineLabel1.Size = new System.Drawing.Size(303, 44);
            this.multiLineLabel1.TabIndex = 107;
            this.multiLineLabel1.Text = "Pour réinitialiser votre mot de passe, saisissez votre adresse email";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.InitialImage = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.Location = new System.Drawing.Point(41, 128);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 109;
            this.pictureBox7.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 128);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 28);
            this.txtEmail.TabIndex = 108;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(137, 167);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 39);
            this.btnLogin.TabIndex = 110;
            this.btnLogin.Text = "retrouver mon mot de passe";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.Location = new System.Drawing.Point(226, 214);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(32, 13);
            this.lblForget.TabIndex = 111;
            this.lblForget.TabStop = true;
            this.lblForget.Text = "Back";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.multiLineLabel1);
            this.Controls.Add(this.label2);
            this.Name = "ForgetPassword";
            this.Size = new System.Drawing.Size(464, 251);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MultiLineLabel multiLineLabel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblForget;
    }
}
