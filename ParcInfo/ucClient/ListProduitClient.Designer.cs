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
            this.btnStartInterv = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lineVertical = new System.Windows.Forms.Panel();
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
            this.dgProduit.Location = new System.Drawing.Point(-16, 206);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.ReadOnly = true;
            this.dgProduit.Size = new System.Drawing.Size(863, 363);
            this.dgProduit.TabIndex = 118;
            this.dgProduit.DoubleClick += new System.EventHandler(this.dgProduit_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartInterv);
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
            // btnStartInterv
            // 
            this.btnStartInterv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnStartInterv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartInterv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartInterv.ForeColor = System.Drawing.Color.White;
            this.btnStartInterv.Image = global::ParcInfo.Properties.Resources.start;
            this.btnStartInterv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartInterv.Location = new System.Drawing.Point(719, 10);
            this.btnStartInterv.Name = "btnStartInterv";
            this.btnStartInterv.Size = new System.Drawing.Size(141, 35);
            this.btnStartInterv.TabIndex = 123;
            this.btnStartInterv.Text = "    Demarer intervention";
            this.btnStartInterv.UseVisualStyleBackColor = false;
            this.btnStartInterv.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.Find16;
            this.btnFind.Location = new System.Drawing.Point(829, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(122, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(591, 20);
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
            this.lblClient.Location = new System.Drawing.Point(195, 16);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 124;
            this.lblClient.Text = "Client";
            this.lblClient.Visible = false;
            // 
            // lineVertical
            // 
            this.lineVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(237)))));
            this.lineVertical.Location = new System.Drawing.Point(186, 12);
            this.lineVertical.Name = "lineVertical";
            this.lineVertical.Size = new System.Drawing.Size(1, 20);
            this.lineVertical.TabIndex = 125;
            this.lineVertical.UseWaitCursor = true;
            this.lineVertical.Visible = false;
            // 
            // ListProduitClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lineVertical);
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
        private System.Windows.Forms.Button btnStartInterv;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblClient;
        public System.Windows.Forms.Panel lineVertical;
    }
}
