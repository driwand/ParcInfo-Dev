namespace ParcInfo.ucControls
{
    partial class TxtDescription
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlText = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblProdut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(65, 8);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(35, 13);
            this.lblDetails.TabIndex = 14;
            this.lblDetails.Text = "label2";
            // 
            // pnlText
            // 
            this.pnlText.AutoSize = true;
            this.pnlText.Location = new System.Drawing.Point(13, 33);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(461, 80);
            this.pnlText.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 1);
            this.panel1.TabIndex = 13;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(10, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "label1";
            // 
            // lblProdut
            // 
            this.lblProdut.AutoSize = true;
            this.lblProdut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProdut.Location = new System.Drawing.Point(202, 8);
            this.lblProdut.Name = "lblProdut";
            this.lblProdut.Size = new System.Drawing.Size(0, 13);
            this.lblProdut.TabIndex = 15;
            // 
            // TxtDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblProdut);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "TxtDescription";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(484, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDetails;
        public System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblProdut;
    }
}
