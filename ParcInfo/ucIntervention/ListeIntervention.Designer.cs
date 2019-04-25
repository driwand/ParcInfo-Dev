namespace ParcInfo.ucInterevntion
{
    partial class ListeIntervention
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleIntervention = new System.Windows.Forms.Label();
            this.dgIntervention = new System.Windows.Forms.DataGridView();
            this.lblTotalIntervention = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEditedDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEdited = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chDelIntr = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEdited = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEditedDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervention)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFind);
            this.groupBox2.Controls.Add(this.txtFind);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(14, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 50);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
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
            this.txtFind.Location = new System.Drawing.Point(140, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(683, 20);
            this.txtFind.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Filter les interventions :";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(209, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 115;
            this.lblSource.Text = "[ text ]";
            this.lblSource.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 114;
            // 
            // lblTitleIntervention
            // 
            this.lblTitleIntervention.AutoSize = true;
            this.lblTitleIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIntervention.ForeColor = System.Drawing.Color.Black;
            this.lblTitleIntervention.Location = new System.Drawing.Point(55, 14);
            this.lblTitleIntervention.Name = "lblTitleIntervention";
            this.lblTitleIntervention.Size = new System.Drawing.Size(151, 15);
            this.lblTitleIntervention.TabIndex = 111;
            this.lblTitleIntervention.Text = "Liste des interventions";
            // 
            // dgIntervention
            // 
            this.dgIntervention.AllowUserToAddRows = false;
            this.dgIntervention.AllowUserToDeleteRows = false;
            this.dgIntervention.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIntervention.Location = new System.Drawing.Point(14, 104);
            this.dgIntervention.Name = "dgIntervention";
            this.dgIntervention.ReadOnly = true;
            this.dgIntervention.Size = new System.Drawing.Size(863, 347);
            this.dgIntervention.TabIndex = 112;
            this.dgIntervention.Click += new System.EventHandler(this.dgIntervention_Click);
            this.dgIntervention.Paint += new System.Windows.Forms.PaintEventHandler(this.dgIntervention_Paint);
            this.dgIntervention.DoubleClick += new System.EventHandler(this.dgIntervention_DoubleClick);
            // 
            // lblTotalIntervention
            // 
            this.lblTotalIntervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.lblTotalIntervention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIntervention.ForeColor = System.Drawing.Color.White;
            this.lblTotalIntervention.Location = new System.Drawing.Point(22, 13);
            this.lblTotalIntervention.Name = "lblTotalIntervention";
            this.lblTotalIntervention.Size = new System.Drawing.Size(21, 18);
            this.lblTotalIntervention.TabIndex = 52;
            this.lblTotalIntervention.Text = "41";
            this.lblTotalIntervention.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chDelIntr
            // 
            this.chDelIntr.AutoSize = true;
            this.chDelIntr.Location = new System.Drawing.Point(14, 457);
            this.chDelIntr.Name = "chDelIntr";
            this.chDelIntr.Size = new System.Drawing.Size(171, 17);
            this.chDelIntr.TabIndex = 131;
            this.chDelIntr.Text = "Afficher les elements supprimer";
            this.chDelIntr.UseVisualStyleBackColor = true;
            this.chDelIntr.CheckedChanged += new System.EventHandler(this.chDelIntr_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 132;
            this.label8.Text = "Dernier modification par :";
            // 
            // lblEdited
            // 
            this.lblEdited.AutoSize = true;
            this.lblEdited.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEdited.ForeColor = System.Drawing.Color.Blue;
            this.lblEdited.Location = new System.Drawing.Point(333, 459);
            this.lblEdited.Name = "lblEdited";
            this.lblEdited.Size = new System.Drawing.Size(37, 13);
            this.lblEdited.TabIndex = 133;
            this.lblEdited.Text = "aucun";
            this.lblEdited.Click += new System.EventHandler(this.lblEdited_Click);
            // 
            // lblMod
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 135;
            this.label13.Text = "Modifier le :";
            // 
            // lblEditedDate
            // 
            this.lblEditedDate.AutoSize = true;
            this.lblEditedDate.Location = new System.Drawing.Point(456, 459);
            this.lblEditedDate.Name = "lblEditedDate";
            this.lblEditedDate.Size = new System.Drawing.Size(49, 13);
            this.lblEditedDate.TabIndex = 134;
            this.lblEditedDate.Text = "****/**/**";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(191, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 15);
            this.panel2.TabIndex = 136;
            // 
            // lblEdited
            // 
            this.lblEdited.AutoSize = true;
            this.lblEdited.Location = new System.Drawing.Point(324, 458);
            this.lblEdited.Name = "lblEdited";
            this.lblEdited.Size = new System.Drawing.Size(43, 13);
            this.lblEdited.TabIndex = 137;
            this.lblEdited.TabStop = true;
            this.lblEdited.Text = "aucune";
            // 
            // ListeIntervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblEdited);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEditedDate);
 
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chDelIntr);
            this.Controls.Add(this.lblTotalIntervention);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitleIntervention);
            this.Controls.Add(this.dgIntervention);
            this.Name = "ListeIntervention";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.ListeIntervention_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervention)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleIntervention;
        public System.Windows.Forms.Label lblSource;
        public System.Windows.Forms.Label lblTotalIntervention;
        public System.Windows.Forms.DataGridView dgIntervention;
        public System.Windows.Forms.Button btnFind;
        public System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox chDelIntr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEdited;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEditedDate;
        private System.Windows.Forms.Panel panel2;
    }
}
