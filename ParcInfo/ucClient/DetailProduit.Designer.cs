namespace ParcInfo.ucClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.gpMaterielLogiciel = new System.Windows.Forms.GroupBox();
            this.btnAddProduit = new System.Windows.Forms.Button();
            this.FpProduit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.FpEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDateAff = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAffecter = new System.Windows.Forms.Label();
            this.lblPrixVente = new System.Windows.Forms.Label();
            this.lblDateAffectation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpMaterielLogiciel.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.button1.Location = new System.Drawing.Point(18, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 10011;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gpMaterielLogiciel
            // 
            this.gpMaterielLogiciel.Controls.Add(this.btnAddProduit);
            this.gpMaterielLogiciel.Controls.Add(this.FpProduit);
            this.gpMaterielLogiciel.Location = new System.Drawing.Point(352, 279);
            this.gpMaterielLogiciel.Name = "gpMaterielLogiciel";
            this.gpMaterielLogiciel.Size = new System.Drawing.Size(520, 148);
            this.gpMaterielLogiciel.TabIndex = 10009;
            this.gpMaterielLogiciel.TabStop = false;
            this.gpMaterielLogiciel.Text = "Logicial et Materiel";
            // 
            // btnAddProduit
            // 
            this.btnAddProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduit.ForeColor = System.Drawing.Color.White;
            this.btnAddProduit.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnAddProduit.Location = new System.Drawing.Point(478, 112);
            this.btnAddProduit.Name = "btnAddProduit";
            this.btnAddProduit.Size = new System.Drawing.Size(32, 32);
            this.btnAddProduit.TabIndex = 131;
            this.btnAddProduit.UseVisualStyleBackColor = false;
            this.btnAddProduit.Click += new System.EventHandler(this.btnAddProduit_Click);
            // 
            // FpProduit
            // 
            this.FpProduit.Location = new System.Drawing.Point(22, 19);
            this.FpProduit.Name = "FpProduit";
            this.FpProduit.Size = new System.Drawing.Size(473, 88);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddEmployee);
            this.groupBox2.Controls.Add(this.FpEmployee);
            this.groupBox2.Location = new System.Drawing.Point(352, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 161);
            this.groupBox2.TabIndex = 10007;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employees";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnAddEmployee.Location = new System.Drawing.Point(478, 125);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(32, 32);
            this.btnAddEmployee.TabIndex = 131;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // FpEmployee
            // 
            this.FpEmployee.Location = new System.Drawing.Point(22, 19);
            this.FpEmployee.MaximumSize = new System.Drawing.Size(473, 101);
            this.FpEmployee.Name = "FpEmployee";
            this.FpEmployee.Size = new System.Drawing.Size(473, 100);
            this.FpEmployee.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrix);
            this.groupBox1.Controls.Add(this.lblDateAff);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblAffecter);
            this.groupBox1.Controls.Add(this.lblPrixVente);
            this.groupBox1.Controls.Add(this.lblDateAffectation);
            this.groupBox1.Location = new System.Drawing.Point(352, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 49);
            this.groupBox1.TabIndex = 10006;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autre Info";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(340, 20);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(23, 13);
            this.lblPrix.TabIndex = 5;
            this.lblPrix.Text = "prix";
            // 
            // lblDateAff
            // 
            this.lblDateAff.AutoSize = true;
            this.lblDateAff.Location = new System.Drawing.Point(220, 20);
            this.lblDateAff.Name = "lblDateAff";
            this.lblDateAff.Size = new System.Drawing.Size(45, 13);
            this.lblDateAff.TabIndex = 4;
            this.lblDateAff.Text = "**-**-****";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(82, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // lblAffecter
            // 
            this.lblAffecter.AutoSize = true;
            this.lblAffecter.Location = new System.Drawing.Point(19, 20);
            this.lblAffecter.Name = "lblAffecter";
            this.lblAffecter.Size = new System.Drawing.Size(62, 13);
            this.lblAffecter.TabIndex = 2;
            this.lblAffecter.Text = "Affect par  :";
            // 
            // lblPrixVente
            // 
            this.lblPrixVente.AutoSize = true;
            this.lblPrixVente.Location = new System.Drawing.Point(271, 20);
            this.lblPrixVente.Name = "lblPrixVente";
            this.lblPrixVente.Size = new System.Drawing.Size(63, 13);
            this.lblPrixVente.TabIndex = 1;
            this.lblPrixVente.Text = "Prix vente  :";
            // 
            // lblDateAffectation
            // 
            this.lblDateAffectation.AutoSize = true;
            this.lblDateAffectation.Location = new System.Drawing.Point(117, 20);
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
            // DetailProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpMaterielLogiciel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpMaterielLogiciel;
        private System.Windows.Forms.Button btnAddProduit;
        private System.Windows.Forms.FlowLayoutPanel FpProduit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Label lblUser;
    }
}
