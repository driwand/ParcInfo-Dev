﻿namespace ParcInfo.ucClient
{
    partial class listProduits
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
            this.nuAffecter = new System.Windows.Forms.NumericUpDown();
            this.gpAffectationProduit = new System.Windows.Forms.GroupBox();
            this.btnAffecter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDateMod = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.dgProduits = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDelP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewType = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.LinkLabel();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuAffecter)).BeginInit();
            this.gpAffectationProduit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuAffecter
            // 
            this.nuAffecter.Location = new System.Drawing.Point(14, 18);
            this.nuAffecter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAffecter.Name = "nuAffecter";
            this.nuAffecter.Size = new System.Drawing.Size(44, 20);
            this.nuAffecter.TabIndex = 0;
            this.nuAffecter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAffecter.ValueChanged += new System.EventHandler(this.nuAffecter_ValueChanged);
            // 
            // gpAffectationProduit
            // 
            this.gpAffectationProduit.Controls.Add(this.btnAffecter);
            this.gpAffectationProduit.Controls.Add(this.nuAffecter);
            this.gpAffectationProduit.Location = new System.Drawing.Point(772, 49);
            this.gpAffectationProduit.Name = "gpAffectationProduit";
            this.gpAffectationProduit.Size = new System.Drawing.Size(102, 49);
            this.gpAffectationProduit.TabIndex = 151;
            this.gpAffectationProduit.TabStop = false;
            this.gpAffectationProduit.Text = "affecter";
            // 
            // btnAffecter
            // 
            this.btnAffecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAffecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAffecter.ForeColor = System.Drawing.Color.White;
            this.btnAffecter.Image = global::ParcInfo.Properties.Resources.Taskicon20;
            this.btnAffecter.Location = new System.Drawing.Point(67, 14);
            this.btnAffecter.Name = "btnAffecter";
            this.btnAffecter.Size = new System.Drawing.Size(28, 28);
            this.btnAffecter.TabIndex = 52;
            this.btnAffecter.UseVisualStyleBackColor = false;
            this.btnAffecter.Click += new System.EventHandler(this.btnAffecter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(392, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(374, 50);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.ClearSearch;
            this.btnFind.Location = new System.Drawing.Point(347, 18);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(20, 20);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(103, 18);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(264, 20);
            this.txtFind.TabIndex = 42;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filtrer les produit :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Dernier modification par :";
            // 
            // lblDateMod
            // 
            this.lblDateMod.AutoSize = true;
            this.lblDateMod.Location = new System.Drawing.Point(629, 454);
            this.lblDateMod.Name = "lblDateMod";
            this.lblDateMod.Size = new System.Drawing.Size(45, 13);
            this.lblDateMod.TabIndex = 148;
            this.lblDateMod.Text = "**-**-****";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(562, 454);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(61, 13);
            this.lblM.TabIndex = 149;
            this.lblM.Text = "Modifier le :";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(392, 429);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(171, 17);
            this.cbDelete.TabIndex = 143;
            this.cbDelete.Text = "Afficher les elements supprimer";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // dgProduits
            // 
            this.dgProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduits.Location = new System.Drawing.Point(392, 113);
            this.dgProduits.Name = "dgProduits";
            this.dgProduits.Size = new System.Drawing.Size(482, 310);
            this.dgProduits.TabIndex = 142;
            this.dgProduits.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduits_RowEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 138;
            this.label1.Text = "Liste des produits";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::ParcInfo.Properties.Resources.btnedit;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(278, 435);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(107, 32);
            this.btnAddProduct.TabIndex = 147;
            this.btnAddProduct.Text = "  Enregister";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduit_Click);
            // 
            // btnDelP
            // 
            this.btnDelP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelP.ForeColor = System.Drawing.Color.White;
            this.btnDelP.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.btnDelP.Location = new System.Drawing.Point(16, 435);
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.Size = new System.Drawing.Size(32, 32);
            this.btnDelP.TabIndex = 141;
            this.btnDelP.UseVisualStyleBackColor = false;
            this.btnDelP.Visible = false;
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.listForms;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewType
            // 
            this.btnNewType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewType.ForeColor = System.Drawing.Color.White;
            this.btnNewType.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnNewType.Location = new System.Drawing.Point(240, 435);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(32, 32);
            this.btnNewType.TabIndex = 153;
            this.btnNewType.UseVisualStyleBackColor = false;
            this.btnNewType.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(517, 454);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 154;
            this.lblUser.TabStop = true;
            this.lblUser.Text = "aucune";
            this.lblUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblUser_LinkClicked);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(575, 433);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 155;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // listProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.gpAffectationProduit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnDelP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDateMod);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.dgProduits);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "listProduits";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.listProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuAffecter)).EndInit();
            this.gpAffectationProduit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuAffecter;
        private System.Windows.Forms.GroupBox gpAffectationProduit;
        private System.Windows.Forms.Button btnAffecter;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDelP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDateMod;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.DataGridView dgProduits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.LinkLabel lblUser;
        private System.Windows.Forms.Label lblID;
    }
}
