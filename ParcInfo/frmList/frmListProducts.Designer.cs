﻿namespace ParcInfo.frmList
{
    partial class frmListProducts
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
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.rdAffect1 = new System.Windows.Forms.RadioButton();
            this.rdAffect2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdcuts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Location = new System.Drawing.Point(346, 338);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(113, 28);
            this.btn_annuler.TabIndex = 78;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.Btn_annuler_Click);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btn_select.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(464, 338);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(113, 28);
            this.btn_select.TabIndex = 77;
            this.btn_select.Text = "Selectionner";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dgProdcuts
            // 
            this.dgProdcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdcuts.Location = new System.Drawing.Point(14, 92);
            this.dgProdcuts.Name = "dgProdcuts";
            this.dgProdcuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdcuts.Size = new System.Drawing.Size(563, 240);
            this.dgProdcuts.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 55);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.ClearSearch;
            this.btnFind.Location = new System.Drawing.Point(537, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 54;
            this.btnFind.UseVisualStyleBackColor = false;
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
            this.txtFind.Size = new System.Drawing.Size(442, 20);
            this.txtFind.TabIndex = 43;
            // 
            // rdAffect1
            // 
            this.rdAffect1.AutoSize = true;
            this.rdAffect1.Checked = true;
            this.rdAffect1.Location = new System.Drawing.Point(14, 71);
            this.rdAffect1.Name = "rdAffect1";
            this.rdAffect1.Size = new System.Drawing.Size(105, 17);
            this.rdAffect1.TabIndex = 79;
            this.rdAffect1.TabStop = true;
            this.rdAffect1.Text = "Affecter au client";
            this.rdAffect1.UseVisualStyleBackColor = true;
            // 
            // rdAffect2
            // 
            this.rdAffect2.AutoSize = true;
            this.rdAffect2.Location = new System.Drawing.Point(142, 71);
            this.rdAffect2.Name = "rdAffect2";
            this.rdAffect2.Size = new System.Drawing.Size(155, 17);
            this.rdAffect2.TabIndex = 79;
            this.rdAffect2.TabStop = true;
            this.rdAffect2.Text = "Affecter au produit du client";
            this.rdAffect2.UseVisualStyleBackColor = true;
            // 
            // frmListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 378);
            this.Controls.Add(this.rdAffect2);
            this.Controls.Add(this.rdAffect1);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.dgProdcuts);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmListProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select product";
            this.Load += new System.EventHandler(this.frmListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdcuts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DataGridView dgProdcuts;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton rdAffect1;
        private System.Windows.Forms.RadioButton rdAffect2;
    }
}