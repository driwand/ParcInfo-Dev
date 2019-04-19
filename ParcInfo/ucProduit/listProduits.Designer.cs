namespace ParcInfo.ucClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgProduits = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddProduit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produitInfo1 = new ParcInfo.ucControls.ProduitInfo();
            ((System.ComponentModel.ISupportInitialize)(this.nuAffecter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuAffecter
            // 
            this.nuAffecter.Location = new System.Drawing.Point(14, 18);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nuAffecter);
            this.groupBox1.Location = new System.Drawing.Point(772, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 49);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "affecter";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ParcInfo.Properties.Resources.Taskicon20;
            this.button1.Location = new System.Drawing.Point(67, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(348, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(418, 50);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::ParcInfo.Properties.Resources.Find16;
            this.btnFind.Location = new System.Drawing.Point(375, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(101, 18);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(268, 20);
            this.txtFind.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filtrer les produit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 144;
            this.label8.Text = "Dernier modification par :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(581, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 148;
            this.label14.Text = "2018/08/08";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(514, 454);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 149;
            this.label13.Text = "Modifier le :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 146;
            this.label10.Text = "user1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(347, 429);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 17);
            this.checkBox1.TabIndex = 143;
            this.checkBox1.Text = "Afficher les elements supprimer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgProduits
            // 
            this.dgProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduits.Location = new System.Drawing.Point(347, 113);
            this.dgProduits.Name = "dgProduits";
            this.dgProduits.Size = new System.Drawing.Size(527, 310);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ParcInfo.Properties.Resources.edit201;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(120, 437);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 32);
            this.button5.TabIndex = 145;
            this.button5.Text = "  Modifier";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAddProduit
            // 
            this.btnAddProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduit.ForeColor = System.Drawing.Color.White;
            this.btnAddProduit.Image = global::ParcInfo.Properties.Resources.btnadd;
            this.btnAddProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduit.Location = new System.Drawing.Point(233, 437);
            this.btnAddProduit.Name = "btnAddProduit";
            this.btnAddProduit.Size = new System.Drawing.Size(91, 32);
            this.btnAddProduit.TabIndex = 147;
            this.btnAddProduit.Text = "   Ajouter";
            this.btnAddProduit.UseVisualStyleBackColor = false;
            this.btnAddProduit.Click += new System.EventHandler(this.btnAddProduit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.button2.Location = new System.Drawing.Point(15, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 141;
            this.button2.UseVisualStyleBackColor = false;
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
            // produitInfo1
            // 
            this.produitInfo1.BackColor = System.Drawing.Color.White;
            this.produitInfo1.Location = new System.Drawing.Point(17, 50);
            this.produitInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.produitInfo1.Name = "produitInfo1";
            this.produitInfo1.Size = new System.Drawing.Size(309, 386);
            this.produitInfo1.TabIndex = 152;
            // 
            // listProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.produitInfo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnAddProduit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgProduits);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "listProduits";
            this.Size = new System.Drawing.Size(890, 481);
            ((System.ComponentModel.ISupportInitialize)(this.nuAffecter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuAffecter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddProduit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dgProduits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ucControls.ProduitInfo produitInfo1;
    }
}
