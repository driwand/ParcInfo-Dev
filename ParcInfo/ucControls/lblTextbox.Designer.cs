namespace ParcInfo.ucControls
{
    partial class lblTextbox
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(4, 5);
            this.lbl.Margin = new System.Windows.Forms.Padding(0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(44, 2);
            this.txtValue.Margin = new System.Windows.Forms.Padding(0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(217, 20);
            this.txtValue.TabIndex = 1;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.FlatAppearance.BorderSize = 0;
            this.btn_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nouveau.Image = global::ParcInfo.Properties.Resources.User20;
            this.btn_nouveau.Location = new System.Drawing.Point(267, 2);
            this.btn_nouveau.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(20, 20);
            this.btn_nouveau.TabIndex = 2;
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.btn_nouveau_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Image = global::ParcInfo.Properties.Resources.Delete20;
            this.btn_supprimer.Location = new System.Drawing.Point(291, 2);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(20, 20);
            this.btn_supprimer.TabIndex = 2;
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(30, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 3;
            this.lblid.Visible = false;
            // 
            // lblTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lbl);
            this.Location = new System.Drawing.Point(45, 2);
            this.Name = "lblTextbox";
            this.Size = new System.Drawing.Size(317, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label lblid;
    }
}
