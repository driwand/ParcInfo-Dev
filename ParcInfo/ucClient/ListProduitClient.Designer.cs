namespace ParcInfo.ucClient
{
    partial class ListProduitClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEditedDate = new System.Windows.Forms.Label();
            this.lblMod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CkDeletedClient = new System.Windows.Forms.CheckBox();
            this.lblEdited = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 117;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.listForms;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 115;
            this.label1.Text = "Liste des Produits";
            // 
            // dgProduit
            // 
            this.dgProduit.AllowUserToAddRows = false;
            this.dgProduit.AllowUserToDeleteRows = false;
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(14, 103);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.ReadOnly = true;
            this.dgProduit.Size = new System.Drawing.Size(863, 351);
            this.dgProduit.TabIndex = 118;
            this.dgProduit.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduit_RowEnter);
            this.dgProduit.DoubleClick += new System.EventHandler(this.dgProduit_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 50);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.Find16;
            this.btnFind.Location = new System.Drawing.Point(829, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(122, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(701, 20);
            this.txtFind.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Filtrer les produits : ";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.lblClient.Location = new System.Drawing.Point(178, 16);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 124;
            this.lblClient.Text = "Client";
            this.lblClient.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(194, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 15);
            this.panel2.TabIndex = 131;
            // 
            // lblEditedDate
            // 
            this.lblEditedDate.AutoSize = true;
            this.lblEditedDate.Location = new System.Drawing.Point(442, 463);
            this.lblEditedDate.Name = "lblEditedDate";
            this.lblEditedDate.Size = new System.Drawing.Size(65, 13);
            this.lblEditedDate.TabIndex = 129;
            this.lblEditedDate.Text = "2018/08/08";
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(375, 464);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(61, 13);
            this.lblMod.TabIndex = 130;
            this.lblMod.Text = "Modifier le :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 127;
            this.label8.Text = "Dernier modification par :";
            // 
            // CkDeletedClient
            // 
            this.CkDeletedClient.AutoSize = true;
            this.CkDeletedClient.Location = new System.Drawing.Point(17, 460);
            this.CkDeletedClient.Name = "CkDeletedClient";
            this.CkDeletedClient.Size = new System.Drawing.Size(171, 17);
            this.CkDeletedClient.TabIndex = 126;
            this.CkDeletedClient.Text = "Afficher les elements supprimer";
            this.CkDeletedClient.UseVisualStyleBackColor = true;
            // 
            // lblEdited
            // 
            this.lblEdited.AutoSize = true;
            this.lblEdited.Location = new System.Drawing.Point(331, 462);
            this.lblEdited.Name = "lblEdited";
            this.lblEdited.Size = new System.Drawing.Size(43, 13);
            this.lblEdited.TabIndex = 132;
            this.lblEdited.TabStop = true;
            this.lblEdited.Text = "aucune";
            // 
            // ListProduitClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEdited);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEditedDate);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CkDeletedClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgProduit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ListProduitClient";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.ListProduitClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEditedDate;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CkDeletedClient;
        private System.Windows.Forms.LinkLabel lblEdited;
    }
}
