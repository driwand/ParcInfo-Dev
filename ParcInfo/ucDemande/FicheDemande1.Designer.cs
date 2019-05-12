namespace ParcInfo.ucDemande
{
    partial class FicheDemande1
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
            this.gpEmploye = new System.Windows.Forms.GroupBox();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDemande = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpDemande = new System.Windows.Forms.GroupBox();
            this.pnlDesc = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientPanel2 = new ParcInfo.Classes.GradientPanel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtStatut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panInterv = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientPanel4 = new ParcInfo.Classes.GradientPanel();
            this.BtnstartInterventionFich = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.gpEmploye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpDemande.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpEmploye
            // 
            this.gpEmploye.Controls.Add(this.gradientPanel1);
            this.gpEmploye.Controls.Add(this.txtDepart);
            this.gpEmploye.Controls.Add(this.txtTel);
            this.gpEmploye.Controls.Add(this.txtPrenom);
            this.gpEmploye.Controls.Add(this.txtNom);
            this.gpEmploye.Controls.Add(this.label4);
            this.gpEmploye.Controls.Add(this.label3);
            this.gpEmploye.Controls.Add(this.label2);
            this.gpEmploye.Controls.Add(this.label1);
            this.gpEmploye.Location = new System.Drawing.Point(17, 57);
            this.gpEmploye.Name = "gpEmploye";
            this.gpEmploye.Padding = new System.Windows.Forms.Padding(0);
            this.gpEmploye.Size = new System.Drawing.Size(404, 166);
            this.gpEmploye.TabIndex = 72;
            this.gpEmploye.TabStop = false;
            this.gpEmploye.Text = "Employée ";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 163);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(404, 3);
            this.gradientPanel1.TabIndex = 41;
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(90, 126);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.ReadOnly = true;
            this.txtDepart.Size = new System.Drawing.Size(230, 20);
            this.txtDepart.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(90, 92);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(230, 20);
            this.txtTel.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(90, 58);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(230, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(90, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(230, 20);
            this.txtNom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Département :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 75;
            // 
            // lblDemande
            // 
            this.lblDemande.AutoSize = true;
            this.lblDemande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemande.ForeColor = System.Drawing.Color.Black;
            this.lblDemande.Location = new System.Drawing.Point(55, 14);
            this.lblDemande.Name = "lblDemande";
            this.lblDemande.Size = new System.Drawing.Size(109, 15);
            this.lblDemande.TabIndex = 73;
            this.lblDemande.Text = "Demande N° 15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcInfo.Properties.Resources.detailx;
            this.pictureBox1.Location = new System.Drawing.Point(14, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // gpDemande
            // 
            this.gpDemande.Controls.Add(this.pnlDesc);
            this.gpDemande.Controls.Add(this.gradientPanel2);
            this.gpDemande.Controls.Add(this.txtDate);
            this.gpDemande.Controls.Add(this.txtStatut);
            this.gpDemande.Controls.Add(this.label6);
            this.gpDemande.Controls.Add(this.label7);
            this.gpDemande.Controls.Add(this.label8);
            this.gpDemande.Location = new System.Drawing.Point(17, 229);
            this.gpDemande.Name = "gpDemande";
            this.gpDemande.Padding = new System.Windows.Forms.Padding(0);
            this.gpDemande.Size = new System.Drawing.Size(404, 199);
            this.gpDemande.TabIndex = 73;
            this.gpDemande.TabStop = false;
            this.gpDemande.Text = "Demande";
            // 
            // pnlDesc
            // 
            this.pnlDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDesc.Location = new System.Drawing.Point(10, 110);
            this.pnlDesc.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(376, 83);
            this.pnlDesc.TabIndex = 42;
            this.pnlDesc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesc_Paint);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 196);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(404, 3);
            this.gradientPanel2.TabIndex = 41;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(122, 58);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(198, 20);
            this.txtDate.TabIndex = 5;
            // 
            // txtStatut
            // 
            this.txtStatut.Location = new System.Drawing.Point(122, 24);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.ReadOnly = true;
            this.txtStatut.Size = new System.Drawing.Size(198, 20);
            this.txtStatut.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Description :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Date de la demande :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Statut :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panInterv);
            this.groupBox3.Controls.Add(this.gradientPanel4);
            this.groupBox3.Location = new System.Drawing.Point(428, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(449, 371);
            this.groupBox3.TabIndex = 76;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interventions :";
            // 
            // panInterv
            // 
            this.panInterv.AutoScroll = true;
            this.panInterv.Location = new System.Drawing.Point(3, 16);
            this.panInterv.Name = "panInterv";
            this.panInterv.Padding = new System.Windows.Forms.Padding(10);
            this.panInterv.Size = new System.Drawing.Size(443, 349);
            this.panInterv.TabIndex = 43;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Angle = 0F;
            this.gradientPanel4.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(83)))), ((int)(((byte)(112)))));
            this.gradientPanel4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.gradientPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel4.Location = new System.Drawing.Point(0, 368);
            this.gradientPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(449, 3);
            this.gradientPanel4.TabIndex = 42;
            // 
            // BtnstartInterventionFich
            // 
            this.BtnstartInterventionFich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.BtnstartInterventionFich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnstartInterventionFich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnstartInterventionFich.ForeColor = System.Drawing.Color.White;
            this.BtnstartInterventionFich.Image = global::ParcInfo.Properties.Resources.start;
            this.BtnstartInterventionFich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnstartInterventionFich.Location = new System.Drawing.Point(731, 434);
            this.BtnstartInterventionFich.Name = "BtnstartInterventionFich";
            this.BtnstartInterventionFich.Size = new System.Drawing.Size(146, 35);
            this.BtnstartInterventionFich.TabIndex = 124;
            this.BtnstartInterventionFich.Text = "  Demarer Intervention";
            this.BtnstartInterventionFich.UseVisualStyleBackColor = false;
            this.BtnstartInterventionFich.Click += new System.EventHandler(this.BtnstartInterventionFich_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.White;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.lblClientName.Location = new System.Drawing.Point(170, 16);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(76, 13);
            this.lblClientName.TabIndex = 125;
            this.lblClientName.Text = "[Nom Client]";
            // 
            // FicheDemande1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.BtnstartInterventionFich);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpDemande);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDemande);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpEmploye);
            this.Name = "FicheDemande1";
            this.Size = new System.Drawing.Size(890, 481);
            this.Load += new System.EventHandler(this.FicheDemande1_Load);
            this.gpEmploye.ResumeLayout(false);
            this.gpEmploye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpDemande.ResumeLayout(false);
            this.gpDemande.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpEmploye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDemande;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private Classes.GradientPanel gradientPanel1;
        private System.Windows.Forms.GroupBox gpDemande;
        private Classes.GradientPanel gradientPanel2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtStatut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Classes.GradientPanel gradientPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel panInterv;
        private System.Windows.Forms.FlowLayoutPanel pnlDesc;
        public System.Windows.Forms.Button BtnstartInterventionFich;
        private System.Windows.Forms.Label lblClientName;
    }
}
