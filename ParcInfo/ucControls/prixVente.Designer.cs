namespace ParcInfo.ucControls
{
    partial class prixVente
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
            this.lblCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(44, 4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(58, 13);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Product ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel1.Location = new System.Drawing.Point(18, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 2);
            this.panel1.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 26);
            this.lbl.Margin = new System.Windows.Forms.Padding(0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 13);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Prix Vente :";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(80, 22);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(215, 20);
            this.txtValue.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel2.Location = new System.Drawing.Point(22, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 1);
            this.panel2.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(124, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // prixVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCode);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "prixVente";
            this.Size = new System.Drawing.Size(314, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
    }
}
