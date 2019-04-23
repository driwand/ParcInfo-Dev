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
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblIdAffecta = new System.Windows.Forms.Label();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.lblidobs = new System.Windows.Forms.Label();
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
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.DarkGray;
            this.pnlLine.Location = new System.Drawing.Point(13, 26);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(461, 1);
            this.pnlLine.TabIndex = 13;
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
            // lblIdAffecta
            // 
            this.lblIdAffecta.AutoSize = true;
            this.lblIdAffecta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIdAffecta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIdAffecta.Location = new System.Drawing.Point(202, 8);
            this.lblIdAffecta.Name = "lblIdAffecta";
            this.lblIdAffecta.Size = new System.Drawing.Size(17, 13);
            this.lblIdAffecta.TabIndex = 15;
            this.lblIdAffecta.Text = "lbl";
            this.lblIdAffecta.Visible = false;
            // 
            // btnDelProd
            // 
            this.btnDelProd.BackColor = System.Drawing.Color.Transparent;
            this.btnDelProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProd.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelProd.Image = global::ParcInfo.Properties.Resources.wtclose;
            this.btnDelProd.Location = new System.Drawing.Point(456, 4);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(18, 18);
            this.btnDelProd.TabIndex = 131;
            this.btnDelProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelProd.UseVisualStyleBackColor = false;
            this.btnDelProd.Visible = false;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            this.btnDelProd.MouseEnter += new System.EventHandler(this.btnDelProd_MouseEnter);
            this.btnDelProd.MouseLeave += new System.EventHandler(this.btnDelProd_MouseLeave);
            // 
            // lblidobs
            // 
            this.lblidobs.AutoSize = true;
            this.lblidobs.Location = new System.Drawing.Point(318, 8);
            this.lblidobs.Name = "lblidobs";
            this.lblidobs.Size = new System.Drawing.Size(35, 13);
            this.lblidobs.TabIndex = 132;
            this.lblidobs.Text = "label1";
            this.lblidobs.Visible = false;
            // 
            // TxtDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblidobs);
            this.Controls.Add(this.btnDelProd);
            this.Controls.Add(this.lblIdAffecta);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "TxtDescription";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(484, 121);
            this.Load += new System.EventHandler(this.TxtDescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDetails;
        public System.Windows.Forms.Panel pnlText;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblIdAffecta;
        public System.Windows.Forms.Panel pnlLine;
        public System.Windows.Forms.Button btnDelProd;
        public System.Windows.Forms.Label lblidobs;
    }
}
