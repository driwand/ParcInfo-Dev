﻿namespace ParcInfo.ucClient
{
    partial class DetailProduit
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDelAffeProduct = new System.Windows.Forms.Button();
            this.gpMaterielLogiciel = new System.Windows.Forms.GroupBox();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.btnAddProduit = new System.Windows.Forms.Button();
            this.FpProduit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gpEmploye = new System.Windows.Forms.GroupBox();
            this.gradientPanel4 = new ParcInfo.Classes.GradientPanel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.FpEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDateAff = new System.Windows.Forms.Label();
            this.lblAffecter = new System.Windows.Forms.Label();
            this.lblPrixVente = new System.Windows.Forms.Label();
            this.lblDateAffectation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.LinkLabel();
            this.lblIDU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpMaterielLogiciel.SuspendLayout();
            this.gpEmploye.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.listForms;
            this.pictureBox1.Location = new System.Drawing.Point(-356, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(897, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 468);
            this.panel2.TabIndex = 10000;
            // 
            // BtnDelAffeProduct
            // 
            this.BtnDelAffeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.BtnDelAffeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelAffeProduct.ForeColor = System.Drawing.Color.White;
            this.BtnDelAffeProduct.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.BtnDelAffeProduct.Location = new System.Drawing.Point(18, 439);
            this.BtnDelAffeProduct.Name = "BtnDelAffeProduct";
            this.BtnDelAffeProduct.Size = new System.Drawing.Size(32, 32);
            this.BtnDelAffeProduct.TabIndex = 10011;
            this.BtnDelAffeProduct.UseVisualStyleBackColor = false;
            this.BtnDelAffeProduct.Click += new System.EventHandler(this.BtnDelAffeProduct_Click);
            // 
            // gpMaterielLogiciel
            // 
            this.gpMaterielLogiciel.Controls.Add(this.gradientPanel1);
            this.gpMaterielLogiciel.Controls.Add(this.btnAddProduit);
            this.gpMaterielLogiciel.Controls.Add(this.FpProduit);
            this.gpMaterielLogiciel.Location = new System.Drawing.Point(405, 279);
            this.gpMaterielLogiciel.Margin = new System.Windows.Forms.Padding(0);
            this.gpMaterielLogiciel.Name = "gpMaterielLogiciel";
            this.gpMaterielLogiciel.Padding = new System.Windows.Forms.Padding(0);
            this.gpMaterielLogiciel.Size = new System.Drawing.Size(467, 148);
            this.gpMaterielLogiciel.TabIndex = 10009;
            this.gpMaterielLogiciel.TabStop = false;
            this.gpMaterielLogiciel.Text = "Logicial et Materiel";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 145);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(467, 3);
            this.gradientPanel1.TabIndex = 133;
            // 
            // btnAddProduit
            // 
            this.btnAddProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduit.ForeColor = System.Drawing.Color.White;
            this.btnAddProduit.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnAddProduit.Location = new System.Drawing.Point(410, 112);
            this.btnAddProduit.Name = "btnAddProduit";
            this.btnAddProduit.Size = new System.Drawing.Size(32, 32);
            this.btnAddProduit.TabIndex = 131;
            this.btnAddProduit.UseVisualStyleBackColor = false;
            this.btnAddProduit.Click += new System.EventHandler(this.btnAddProduit_Click);
            // 
            // FpProduit
            // 
            this.FpProduit.Location = new System.Drawing.Point(19, 19);
            this.FpProduit.Name = "FpProduit";
            this.FpProduit.Size = new System.Drawing.Size(423, 88);
            this.FpProduit.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::ParcInfo.Properties.Resources.btnedit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(755, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 32);
            this.btnEdit.TabIndex = 10008;
            this.btnEdit.Text = "    Enregistrer";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gpEmploye
            // 
            this.gpEmploye.Controls.Add(this.gradientPanel4);
            this.gpEmploye.Controls.Add(this.btnAddEmployee);
            this.gpEmploye.Controls.Add(this.FpEmployee);
            this.gpEmploye.Location = new System.Drawing.Point(405, 112);
            this.gpEmploye.Name = "gpEmploye";
            this.gpEmploye.Padding = new System.Windows.Forms.Padding(0);
            this.gpEmploye.Size = new System.Drawing.Size(467, 161);
            this.gpEmploye.TabIndex = 10007;
            this.gpEmploye.TabStop = false;
            this.gpEmploye.Text = "Employees";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Angle = 0F;
            this.gradientPanel4.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel4.Location = new System.Drawing.Point(0, 158);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(467, 3);
            this.gradientPanel4.TabIndex = 132;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnAddEmployee.Location = new System.Drawing.Point(414, 125);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(32, 32);
            this.btnAddEmployee.TabIndex = 131;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // FpEmployee
            // 
            this.FpEmployee.Location = new System.Drawing.Point(19, 19);
            this.FpEmployee.MaximumSize = new System.Drawing.Size(473, 101);
            this.FpEmployee.Name = "FpEmployee";
            this.FpEmployee.Size = new System.Drawing.Size(427, 101);
            this.FpEmployee.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblPrix);
            this.groupBox1.Controls.Add(this.lblDateAff);
            this.groupBox1.Controls.Add(this.lblAffecter);
            this.groupBox1.Controls.Add(this.lblPrixVente);
            this.groupBox1.Controls.Add(this.lblDateAffectation);
            this.groupBox1.Location = new System.Drawing.Point(405, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 49);
            this.groupBox1.TabIndex = 10006;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autre Info";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(335, 21);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(23, 13);
            this.lblPrix.TabIndex = 5;
            this.lblPrix.Text = "prix";
            // 
            // lblDateAff
            // 
            this.lblDateAff.AutoSize = true;
            this.lblDateAff.Location = new System.Drawing.Point(215, 21);
            this.lblDateAff.Name = "lblDateAff";
            this.lblDateAff.Size = new System.Drawing.Size(45, 13);
            this.lblDateAff.TabIndex = 4;
            this.lblDateAff.Text = "**-**-****";
            // 
            // lblAffecter
            // 
            this.lblAffecter.AutoSize = true;
            this.lblAffecter.Location = new System.Drawing.Point(14, 21);
            this.lblAffecter.Name = "lblAffecter";
            this.lblAffecter.Size = new System.Drawing.Size(62, 13);
            this.lblAffecter.TabIndex = 2;
            this.lblAffecter.Text = "Affect par  :";
            // 
            // lblPrixVente
            // 
            this.lblPrixVente.AutoSize = true;
            this.lblPrixVente.Location = new System.Drawing.Point(266, 21);
            this.lblPrixVente.Name = "lblPrixVente";
            this.lblPrixVente.Size = new System.Drawing.Size(63, 13);
            this.lblPrixVente.TabIndex = 1;
            this.lblPrixVente.Text = "Prix vente  :";
            // 
            // lblDateAffectation
            // 
            this.lblDateAffectation.AutoSize = true;
            this.lblDateAffectation.Location = new System.Drawing.Point(112, 21);
            this.lblDateAffectation.Name = "lblDateAffectation";
            this.lblDateAffectation.Size = new System.Drawing.Size(97, 13);
            this.lblDateAffectation.TabIndex = 0;
            this.lblDateAffectation.Text = "Date d\'affectation :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(18, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 2);
            this.panel1.TabIndex = 10005;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ParcInfo.Properties.Resources.addForms;
            this.pictureBox2.Location = new System.Drawing.Point(18, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10004;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 10003;
            this.label1.Text = "produit du client";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.lblClient.Location = new System.Drawing.Point(174, 21);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(57, 13);
            this.lblClient.TabIndex = 10012;
            this.lblClient.Text = " [client1]";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(79, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(27, 13);
            this.lblUser.TabIndex = 10013;
            this.lblUser.TabStop = true;
            this.lblUser.Text = "user";
            this.lblUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblUser_LinkClicked);
            // 
            // lblIDU
            // 
            this.lblIDU.AutoSize = true;
            this.lblIDU.Location = new System.Drawing.Point(484, 50);
            this.lblIDU.Name = "lblIDU";
            this.lblIDU.Size = new System.Drawing.Size(13, 13);
            this.lblIDU.TabIndex = 10013;
            this.lblIDU.Text = "0";
            this.lblIDU.Visible = false;
            // 
            // DetailProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblIDU);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.BtnDelAffeProduct);
            this.Controls.Add(this.gpMaterielLogiciel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gpEmploye);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DetailProduit";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.ListProduitClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpMaterielLogiciel.ResumeLayout(false);
            this.gpEmploye.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDelAffeProduct;
        private System.Windows.Forms.GroupBox gpMaterielLogiciel;
        private System.Windows.Forms.Button btnAddProduit;
        private System.Windows.Forms.FlowLayoutPanel FpProduit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gpEmploye;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.FlowLayoutPanel FpEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAffecter;
        private System.Windows.Forms.Label lblPrixVente;
        private System.Windows.Forms.Label lblDateAffectation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDateAff;
        private Classes.GradientPanel gradientPanel4;
        private Classes.GradientPanel gradientPanel1;
        private System.Windows.Forms.LinkLabel lblUser;
        private System.Windows.Forms.Label lblIDU;
    }
}
