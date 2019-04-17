namespace ParcInfo.ucControls
{
    partial class txtlblDepartement
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
            this.btnDelDepar = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelDepar
            // 
            this.btnDelDepar.FlatAppearance.BorderSize = 0;
            this.btnDelDepar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDepar.Image = global::ParcInfo.Properties.Resources.Delete20;
            this.btnDelDepar.Location = new System.Drawing.Point(267, 2);
            this.btnDelDepar.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelDepar.Name = "btnDelDepar";
            this.btnDelDepar.Size = new System.Drawing.Size(20, 20);
            this.btnDelDepar.TabIndex = 5;
            this.btnDelDepar.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(45, 2);
            this.txtValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(217, 20);
            this.txtValue.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(4, 5);
            this.lbl.Margin = new System.Windows.Forms.Padding(0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "label1";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(23, 11);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 6;
            this.lblid.Visible = false;
            // 
            // txtlblDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnDelDepar);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lbl);
            this.Name = "txtlblDepartement";
            this.Size = new System.Drawing.Size(298, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelDepar;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblid;
    }
}
