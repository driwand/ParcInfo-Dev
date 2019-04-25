namespace ParcInfo.ucControls
{
    partial class ProduitInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.isHardware = new System.Windows.Forms.CheckBox();
            this.txtQte = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.DateProduit = new System.Windows.Forms.DateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlProp = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.isHardware);
            this.groupBox1.Controls.Add(this.txtQte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateProduit);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.txtPrix);
            this.groupBox1.Controls.Add(this.txtMarque);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 199);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produit";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(327, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 49;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // isHardware
            // 
            this.isHardware.AutoSize = true;
            this.isHardware.Location = new System.Drawing.Point(96, 176);
            this.isHardware.Name = "isHardware";
            this.isHardware.Size = new System.Drawing.Size(79, 17);
            this.isHardware.TabIndex = 48;
            this.isHardware.Text = "isHardware";
            this.isHardware.UseVisualStyleBackColor = true;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(226, 143);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(48, 20);
            this.txtQte.TabIndex = 4;
            this.txtQte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Quantity :";
            // 
            // DateProduit
            // 
            this.DateProduit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateProduit.Location = new System.Drawing.Point(96, 112);
            this.DateProduit.Name = "DateProduit";
            this.DateProduit.Size = new System.Drawing.Size(82, 20);
            this.DateProduit.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(96, 18);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(108, 21);
            this.cbType.TabIndex = 0;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(96, 143);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(69, 20);
            this.txtPrix.TabIndex = 4;
            this.txtPrix.Tag = "required";
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(96, 50);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(244, 20);
            this.txtMarque.TabIndex = 1;
            this.txtMarque.Tag = "required";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(96, 82);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(244, 20);
            this.txtModel.TabIndex = 2;
            this.txtModel.Tag = "required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Date fabrication :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Prix :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Marque :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Type :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pnlProp);
            this.groupBox6.Location = new System.Drawing.Point(3, 212);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(369, 164);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Les proprietes du produit";
            // 
            // pnlProp
            // 
            this.pnlProp.Location = new System.Drawing.Point(5, 19);
            this.pnlProp.MaximumSize = new System.Drawing.Size(358, 124);
            this.pnlProp.Name = "pnlProp";
            this.pnlProp.Size = new System.Drawing.Size(358, 124);
            this.pnlProp.TabIndex = 0;
            // 
            // ProduitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProduitInfo";
            this.Size = new System.Drawing.Size(375, 386);
            this.Load += new System.EventHandler(this.ProduitInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQte)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown txtQte;
        public System.Windows.Forms.DateTimePicker DateProduit;
        public System.Windows.Forms.ComboBox cbType;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtMarque;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.FlowLayoutPanel pnlProp;
        public System.Windows.Forms.CheckBox isHardware;
        public System.Windows.Forms.Label lblID;
    }
}
