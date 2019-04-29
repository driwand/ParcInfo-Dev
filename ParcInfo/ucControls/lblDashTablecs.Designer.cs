namespace ParcInfo.ucControls
{
    partial class lblDashTablecs
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblClient.Location = new System.Drawing.Point(117, 6);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(29, 16);
            this.lblClient.TabIndex = 7;
            this.lblClient.Text = "DPS";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(309, 6);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatut.Size = new System.Drawing.Size(65, 15);
            this.lblStatut.TabIndex = 6;
            this.lblStatut.Text = "En retard";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblDate.Location = new System.Drawing.Point(178, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "4/19/2019 1:21:50 PM";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 6);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 16);
            this.lblID.TabIndex = 8;
            this.lblID.TabStop = true;
            this.lblID.Text = "DEM-1904192";
            this.lblID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblID_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel5.Controls.Add(this.id);
            this.panel5.Location = new System.Drawing.Point(0, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 1);
            this.panel5.TabIndex = 9;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.id.Location = new System.Drawing.Point(-3, -13);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(14, 16);
            this.id.TabIndex = 10;
            this.id.Text = "0";
            // 
            // lblDashTablecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.lblDate);
            this.Name = "lblDashTablecs";
            this.Size = new System.Drawing.Size(380, 29);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.LinkLabel lblID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label id;
    }
}
