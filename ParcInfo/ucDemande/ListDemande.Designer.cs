﻿namespace ParcInfo.ucClient
{
    partial class ListDemande
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
            this.gpFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTraiter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListRequest = new System.Windows.Forms.Label();
            this.dgDemande = new System.Windows.Forms.DataGridView();
            this.lblTotalRequest = new System.Windows.Forms.Label();
            this.lblEmployeClient = new System.Windows.Forms.Label();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.gpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDemande)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFind
            // 
            this.gpFind.Controls.Add(this.btnFind);
            this.gpFind.Controls.Add(this.txtFind);
            this.gpFind.Controls.Add(this.label15);
            this.gpFind.Location = new System.Drawing.Point(14, 45);
            this.gpFind.Name = "gpFind";
            this.gpFind.Size = new System.Drawing.Size(711, 50);
            this.gpFind.TabIndex = 122;
            this.gpFind.TabStop = false;
            this.gpFind.Text = "Recherche";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.Find16;
            this.btnFind.Location = new System.Drawing.Point(677, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(140, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(532, 20);
            this.txtFind.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filtrer les damnandes : ";
            // 
            // btnTraiter
            // 
            this.btnTraiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnTraiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraiter.ForeColor = System.Drawing.Color.White;
            this.btnTraiter.Image = global::ParcInfo.Properties.Resources.start;
            this.btnTraiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraiter.Location = new System.Drawing.Point(731, 55);
            this.btnTraiter.Name = "btnTraiter";
            this.btnTraiter.Size = new System.Drawing.Size(146, 35);
            this.btnTraiter.TabIndex = 123;
            this.btnTraiter.Text = "  Demarer Intervention";
            this.btnTraiter.UseVisualStyleBackColor = false;
            this.btnTraiter.Click += new System.EventHandler(this.btnTraiter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 120;
            // 
            // lblListRequest
            // 
            this.lblListRequest.AutoSize = true;
            this.lblListRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListRequest.ForeColor = System.Drawing.Color.Black;
            this.lblListRequest.Location = new System.Drawing.Point(55, 11);
            this.lblListRequest.Name = "lblListRequest";
            this.lblListRequest.Size = new System.Drawing.Size(129, 15);
            this.lblListRequest.TabIndex = 117;
            this.lblListRequest.Text = "Liste des demande";
            // 
            // dgDemande
            // 
            this.dgDemande.AllowUserToAddRows = false;
            this.dgDemande.AllowUserToDeleteRows = false;
            this.dgDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDemande.Location = new System.Drawing.Point(14, 101);
            this.dgDemande.Name = "dgDemande";
            this.dgDemande.ReadOnly = true;
            this.dgDemande.Size = new System.Drawing.Size(863, 347);
            this.dgDemande.TabIndex = 118;
            this.dgDemande.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDemande_CellDoubleClick);
            this.dgDemande.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDemande_CellMouseDown);
            // 
            // lblTotalRequest
            // 
            this.lblTotalRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.lblTotalRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequest.ForeColor = System.Drawing.Color.White;
            this.lblTotalRequest.Location = new System.Drawing.Point(22, 10);
            this.lblTotalRequest.Name = "lblTotalRequest";
            this.lblTotalRequest.Size = new System.Drawing.Size(21, 18);
            this.lblTotalRequest.TabIndex = 123;
            this.lblTotalRequest.Text = "0";
            this.lblTotalRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmployeClient
            // 
            this.lblEmployeClient.AutoSize = true;
            this.lblEmployeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeClient.Location = new System.Drawing.Point(187, 12);
            this.lblEmployeClient.Name = "lblEmployeClient";
            this.lblEmployeClient.Size = new System.Drawing.Size(44, 13);
            this.lblEmployeClient.TabIndex = 121;
            this.lblEmployeClient.Text = "[ text ]";
            this.lblEmployeClient.Visible = false;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(14, 454);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(171, 17);
            this.cbDelete.TabIndex = 125;
            this.cbDelete.Text = "Afficher les elements supprimer";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // ListDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.btnTraiter);
            this.Controls.Add(this.lblTotalRequest);
            this.Controls.Add(this.gpFind);
            this.Controls.Add(this.lblEmployeClient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblListRequest);
            this.Controls.Add(this.dgDemande);
            this.Name = "ListDemande";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.ListRequest_Load);
            this.gpFind.ResumeLayout(false);
            this.gpFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDemande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListRequest;
        private System.Windows.Forms.DataGridView dgDemande;
        public System.Windows.Forms.Label lblTotalRequest;
        private System.Windows.Forms.Label lblEmployeClient;
        public System.Windows.Forms.GroupBox gpFind;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox txtFind;
        public System.Windows.Forms.Button btnTraiter;
        private System.Windows.Forms.CheckBox cbDelete;
    }
}
