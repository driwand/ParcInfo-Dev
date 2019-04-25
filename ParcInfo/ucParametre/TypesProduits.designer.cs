namespace ParcInfo.settings
{
    partial class TypesProduits
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddProp = new System.Windows.Forms.Button();
            this.pnlProp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgType = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewType = new System.Windows.Forms.Button();
            this.btnDelType = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgType)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(18, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 2);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Types Produits";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.cbUser);
            this.groupBox1.Controls.Add(this.cbLog);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 101);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(338, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(74, 77);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(125, 17);
            this.cbUser.TabIndex = 3;
            this.cbUser.Text = "Supporte utilisateur ?";
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // cbLog
            // 
            this.cbLog.AutoSize = true;
            this.cbLog.Location = new System.Drawing.Point(74, 55);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(124, 17);
            this.cbLog.TabIndex = 2;
            this.cbLog.Text = "Supporte le logiciel ?";
            this.cbLog.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(74, 28);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(253, 20);
            this.txtType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddProp);
            this.groupBox2.Controls.Add(this.pnlProp);
            this.groupBox2.Location = new System.Drawing.Point(18, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 268);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les proprietes du produit";
            // 
            // btnAddProp
            // 
            this.btnAddProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAddProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProp.ForeColor = System.Drawing.Color.White;
            this.btnAddProp.Location = new System.Drawing.Point(252, 228);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(113, 28);
            this.btnAddProp.TabIndex = 72;
            this.btnAddProp.Text = "Ajouter";
            this.btnAddProp.UseVisualStyleBackColor = false;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // pnlProp
            // 
            this.pnlProp.Location = new System.Drawing.Point(6, 21);
            this.pnlProp.MaximumSize = new System.Drawing.Size(381, 215);
            this.pnlProp.Name = "pnlProp";
            this.pnlProp.Size = new System.Drawing.Size(359, 201);
            this.pnlProp.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(759, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 28);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.addForms;
            this.pictureBox1.Location = new System.Drawing.Point(18, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // dgType
            // 
            this.dgType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgType.Location = new System.Drawing.Point(401, 111);
            this.dgType.Name = "dgType";
            this.dgType.Size = new System.Drawing.Size(468, 319);
            this.dgType.TabIndex = 0;
            this.dgType.DoubleClick += new System.EventHandler(this.dgType_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(401, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(471, 50);
            this.groupBox4.TabIndex = 170;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recherche";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ParcInfo.Properties.Resources.Find16;
            this.button2.Location = new System.Drawing.Point(424, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 51;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 20);
            this.textBox2.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Filtrer les produit";
            // 
            // btnNewType
            // 
            this.btnNewType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnNewType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewType.ForeColor = System.Drawing.Color.White;
            this.btnNewType.Location = new System.Drawing.Point(640, 436);
            this.btnNewType.Name = "btnNewType";
            this.btnNewType.Size = new System.Drawing.Size(113, 28);
            this.btnNewType.TabIndex = 171;
            this.btnNewType.Text = "Nouveau";
            this.btnNewType.UseVisualStyleBackColor = false;
            this.btnNewType.Visible = false;
            this.btnNewType.Click += new System.EventHandler(this.btnNewType_Click);
            // 
            // btnDelType
            // 
            this.btnDelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelType.ForeColor = System.Drawing.Color.White;
            this.btnDelType.Image = global::ParcInfo.Properties.Resources.btndelete;
            this.btnDelType.Location = new System.Drawing.Point(18, 436);
            this.btnDelType.Name = "btnDelType";
            this.btnDelType.Size = new System.Drawing.Size(28, 28);
            this.btnDelType.TabIndex = 10016;
            this.btnDelType.UseVisualStyleBackColor = false;
            this.btnDelType.Visible = false;
            this.btnDelType.Click += new System.EventHandler(this.btnDelType_Click);
            // 
            // TypesProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelType);
            this.Controls.Add(this.btnNewType);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "TypesProduits";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.TypesProduits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgType)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUser;
        private System.Windows.Forms.CheckBox cbLog;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel pnlProp;
        private System.Windows.Forms.Button btnAddProp;
        private System.Windows.Forms.DataGridView dgType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnNewType;
        private System.Windows.Forms.Button btnDelType;
    }
}
