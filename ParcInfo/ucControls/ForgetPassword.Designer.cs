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
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnForgetPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "vous avez oublie votre mot de passe ?";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.InitialImage = global::ParcInfo.Properties.Resources.User_48px;
            this.pictureBox7.Location = new System.Drawing.Point(65, 106);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 109;
            this.pictureBox7.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 106);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 28);
            this.txtEmail.TabIndex = 108;
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnForgetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPass.ForeColor = System.Drawing.Color.White;
            this.btnForgetPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnForgetPass.Location = new System.Drawing.Point(165, 177);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(210, 39);
            this.btnForgetPass.TabIndex = 110;
            this.btnForgetPass.Text = "retrouver mon mot de passe";
            this.btnForgetPass.UseVisualStyleBackColor = false;
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(106, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 47);
            this.label1.TabIndex = 112;
            this.label1.Text = "Pour réinitialiser votre mot de passe, saisissez votre adresse email";
            // 
            // lblErr
            // 
            this.lblErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.lblErr.Location = new System.Drawing.Point(108, 140);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(329, 34);
            this.lblErr.TabIndex = 113;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForgetPass);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Name = "ForgetPassword";
            this.Size = new System.Drawing.Size(512, 247);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnForgetPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErr;
    }
}
