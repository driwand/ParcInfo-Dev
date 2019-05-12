namespace ParcInfo.frmList
{
    partial class frmAffectLogMater
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
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.dgProdcuts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblproduct = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdcuts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Location = new System.Drawing.Point(344, 370);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(113, 28);
            this.btn_annuler.TabIndex = 82;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btn_select.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(462, 370);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(113, 28);
            this.btn_select.TabIndex = 81;
            this.btn_select.Text = "Selectionner";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dgProdcuts
            // 
            this.dgProdcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdcuts.Location = new System.Drawing.Point(15, 133);
            this.dgProdcuts.Name = "dgProdcuts";
            this.dgProdcuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdcuts.Size = new System.Drawing.Size(563, 231);
            this.dgProdcuts.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 55);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les produit du client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Filtrer les produits :";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(115, 20);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(431, 20);
            this.txtFind.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltype);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblmodel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblproduct);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Location = new System.Drawing.Point(15, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 55);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "You want to assign to this product";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(356, 24);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(17, 13);
            this.lbltype.TabIndex = 58;
            this.lbltype.Text = "ml";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Type :";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Location = new System.Drawing.Point(220, 24);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(17, 13);
            this.lblmodel.TabIndex = 56;
            this.lblmodel.Text = "ml";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Model :";
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Location = new System.Drawing.Point(67, 24);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(30, 13);
            this.lblproduct.TabIndex = 54;
            this.lblproduct.Text = "PRD";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(15, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 13);
            this.lbl1.TabIndex = 53;
            this.lbl1.Text = "Produit :";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.ClearSearch;
            this.btnFind.Location = new System.Drawing.Point(526, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 54;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // frmAffectLogMater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.dgProdcuts);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAffectLogMater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Product";
            this.Load += new System.EventHandler(this.frmAffectLogMater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdcuts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dgProdcuts;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lbltype;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblmodel;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblproduct;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnFind;
    }
}