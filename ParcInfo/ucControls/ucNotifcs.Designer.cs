namespace ParcInfo.ucControls
{
    partial class ucNotifcs
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
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblidDem = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.lblIDC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.panel1.Location = new System.Drawing.Point(-12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 1);
            this.panel1.TabIndex = 7;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploye.Location = new System.Drawing.Point(9, 5);
            this.lblEmploye.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(99, 16);
            this.lblEmploye.TabIndex = 8;
            this.lblEmploye.Text = "Kanoun Ayoub  -";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.lblClient.Location = new System.Drawing.Point(107, 5);
            this.lblClient.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(36, 15);
            this.lblClient.TabIndex = 9;
            this.lblClient.Text = "[DPS]";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(9, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 16);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "11-08-2019";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ParcInfo.Properties.Resources.Next_16px;
            this.btnNew.Location = new System.Drawing.Point(172, 25);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(21, 21);
            this.btnNew.TabIndex = 52;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblidDem
            // 
            this.lblidDem.AutoSize = true;
            this.lblidDem.Location = new System.Drawing.Point(180, 5);
            this.lblidDem.Name = "lblidDem";
            this.lblidDem.Size = new System.Drawing.Size(13, 13);
            this.lblidDem.TabIndex = 53;
            this.lblidDem.Text = "0";
            this.lblidDem.Visible = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(3, 47);
            this.gradientPanel1.TabIndex = 6;
            // 
            // lblIDC
            // 
            this.lblIDC.AutoSize = true;
            this.lblIDC.Location = new System.Drawing.Point(169, 5);
            this.lblIDC.Name = "lblIDC";
            this.lblIDC.Size = new System.Drawing.Size(13, 13);
            this.lblIDC.TabIndex = 54;
            this.lblIDC.Text = "0";
            this.lblIDC.Visible = false;
            // 
            // ucNotifcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblIDC);
            this.Controls.Add(this.lblidDem);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblEmploye);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucNotifcs";
            this.Size = new System.Drawing.Size(202, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Classes.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblidDem;
        private System.Windows.Forms.Label lblIDC;
    }
}
