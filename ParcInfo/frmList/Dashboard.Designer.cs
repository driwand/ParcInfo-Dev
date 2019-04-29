namespace ParcInfo.frmList
{
    partial class Dashboard
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
            this.lblClient = new System.Windows.Forms.Label();
            this.gradientPanel1 = new ParcInfo.Classes.GradientPanel();
            this.lblDemEnRetard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpDemandeEnCours = new ParcInfo.Classes.GradientPanel();
            this.lblDemEncours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradientPanel3 = new ParcInfo.Classes.GradientPanel();
            this.lblIntEnCours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel4 = new ParcInfo.Classes.GradientPanel();
            this.lblIntEnRetard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDemande = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDemInt1 = new ParcInfo.ucControls.lblDemInt();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlIntervention = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDemInt2 = new ParcInfo.ucControls.lblDemInt();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gradientPanel5 = new ParcInfo.Classes.GradientPanel();
            this.gradientPanel7 = new ParcInfo.Classes.GradientPanel();
            this.gradientPanel6 = new ParcInfo.Classes.GradientPanel();
            this.gradientPanel8 = new ParcInfo.Classes.GradientPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.gpDemandeEnCours.SuspendLayout();
            this.gradientPanel3.SuspendLayout();
            this.gradientPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDemande.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlIntervention.SuspendLayout();
            this.gradientPanel5.SuspendLayout();
            this.gradientPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.Black;
            this.lblClient.Location = new System.Drawing.Point(32, 16);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(95, 19);
            this.lblClient.TabIndex = 10005;
            this.lblClient.Text = "Dashboard";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.gradientPanel1.Controls.Add(this.lblDemEnRetard);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Location = new System.Drawing.Point(241, 48);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(198, 80);
            this.gradientPanel1.TabIndex = 10006;
            // 
            // lblDemEnRetard
            // 
            this.lblDemEnRetard.AutoSize = true;
            this.lblDemEnRetard.BackColor = System.Drawing.Color.Transparent;
            this.lblDemEnRetard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemEnRetard.ForeColor = System.Drawing.Color.White;
            this.lblDemEnRetard.Location = new System.Drawing.Point(89, 38);
            this.lblDemEnRetard.Name = "lblDemEnRetard";
            this.lblDemEnRetard.Size = new System.Drawing.Size(18, 19);
            this.lblDemEnRetard.TabIndex = 3;
            this.lblDemEnRetard.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demande en retard";
            // 
            // gpDemandeEnCours
            // 
            this.gpDemandeEnCours.Angle = 0F;
            this.gpDemandeEnCours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpDemandeEnCours.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(113)))), ((int)(((byte)(250)))));
            this.gpDemandeEnCours.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(47)))), ((int)(((byte)(248)))));
            this.gpDemandeEnCours.Controls.Add(this.lblDemEncours);
            this.gpDemandeEnCours.Controls.Add(this.label2);
            this.gpDemandeEnCours.Location = new System.Drawing.Point(35, 48);
            this.gpDemandeEnCours.Name = "gpDemandeEnCours";
            this.gpDemandeEnCours.Size = new System.Drawing.Size(198, 80);
            this.gpDemandeEnCours.TabIndex = 10007;
            // 
            // lblDemEncours
            // 
            this.lblDemEncours.AutoSize = true;
            this.lblDemEncours.BackColor = System.Drawing.Color.Transparent;
            this.lblDemEncours.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemEncours.ForeColor = System.Drawing.Color.White;
            this.lblDemEncours.Location = new System.Drawing.Point(89, 38);
            this.lblDemEncours.Name = "lblDemEncours";
            this.lblDemEncours.Size = new System.Drawing.Size(18, 19);
            this.lblDemEncours.TabIndex = 2;
            this.lblDemEncours.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demande en cours";
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Angle = 0F;
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(231)))), ((int)(((byte)(163)))));
            this.gradientPanel3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(222)))), ((int)(((byte)(129)))));
            this.gradientPanel3.Controls.Add(this.lblIntEnCours);
            this.gradientPanel3.Controls.Add(this.label3);
            this.gradientPanel3.Location = new System.Drawing.Point(447, 48);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(198, 80);
            this.gradientPanel3.TabIndex = 10008;
            // 
            // lblIntEnCours
            // 
            this.lblIntEnCours.AutoSize = true;
            this.lblIntEnCours.BackColor = System.Drawing.Color.Transparent;
            this.lblIntEnCours.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntEnCours.ForeColor = System.Drawing.Color.White;
            this.lblIntEnCours.Location = new System.Drawing.Point(89, 38);
            this.lblIntEnCours.Name = "lblIntEnCours";
            this.lblIntEnCours.Size = new System.Drawing.Size(18, 19);
            this.lblIntEnCours.TabIndex = 4;
            this.lblIntEnCours.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intervention en cours";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.Angle = 0F;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(199)))), ((int)(((byte)(246)))));
            this.gradientPanel4.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.gradientPanel4.Controls.Add(this.lblIntEnRetard);
            this.gradientPanel4.Controls.Add(this.label4);
            this.gradientPanel4.Location = new System.Drawing.Point(653, 48);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(198, 80);
            this.gradientPanel4.TabIndex = 10009;
            // 
            // lblIntEnRetard
            // 
            this.lblIntEnRetard.AutoSize = true;
            this.lblIntEnRetard.BackColor = System.Drawing.Color.Transparent;
            this.lblIntEnRetard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntEnRetard.ForeColor = System.Drawing.Color.White;
            this.lblIntEnRetard.Location = new System.Drawing.Point(89, 38);
            this.lblIntEnRetard.Name = "lblIntEnRetard";
            this.lblIntEnRetard.Size = new System.Drawing.Size(18, 19);
            this.lblIntEnRetard.TabIndex = 5;
            this.lblIntEnRetard.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interventions en retard";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlDemande);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(35, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 247);
            this.panel1.TabIndex = 10012;
            // 
            // pnlDemande
            // 
            this.pnlDemande.Controls.Add(this.label9);
            this.pnlDemande.Controls.Add(this.panel5);
            this.pnlDemande.Controls.Add(this.lblDemInt1);
            this.pnlDemande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDemande.Location = new System.Drawing.Point(0, 0);
            this.pnlDemande.Name = "pnlDemande";
            this.pnlDemande.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlDemande.Size = new System.Drawing.Size(402, 243);
            this.pnlDemande.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Demandes";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel5.Location = new System.Drawing.Point(13, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 1);
            this.panel5.TabIndex = 4;
            // 
            // lblDemInt1
            // 
            this.lblDemInt1.BackColor = System.Drawing.Color.White;
            this.lblDemInt1.DateLbl = "Date Demande";
            this.lblDemInt1.Location = new System.Drawing.Point(13, 37);
            this.lblDemInt1.Name = "lblDemInt1";
            this.lblDemInt1.Size = new System.Drawing.Size(380, 25);
            this.lblDemInt1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(89)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 243);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 2);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlIntervention);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(447, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 247);
            this.panel3.TabIndex = 10013;
            // 
            // pnlIntervention
            // 
            this.pnlIntervention.Controls.Add(this.label10);
            this.pnlIntervention.Controls.Add(this.panel6);
            this.pnlIntervention.Controls.Add(this.lblDemInt2);
            this.pnlIntervention.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIntervention.Location = new System.Drawing.Point(0, 0);
            this.pnlIntervention.Name = "pnlIntervention";
            this.pnlIntervention.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.pnlIntervention.Size = new System.Drawing.Size(402, 243);
            this.pnlIntervention.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Interventions";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel6.Location = new System.Drawing.Point(13, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 1);
            this.panel6.TabIndex = 4;
            // 
            // lblDemInt2
            // 
            this.lblDemInt2.BackColor = System.Drawing.Color.White;
            this.lblDemInt2.DateLbl = "Date Interventions";
            this.lblDemInt2.Location = new System.Drawing.Point(13, 37);
            this.lblDemInt2.Name = "lblDemInt2";
            this.lblDemInt2.Size = new System.Drawing.Size(380, 25);
            this.lblDemInt2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(89)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 2);
            this.panel4.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(45, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Demande en retard";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(45, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 17);
            this.label12.TabIndex = 10014;
            this.label12.Text = "Demande en retard";
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.Angle = 0F;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel5.ColorTop = System.Drawing.Color.White;
            this.gradientPanel5.Controls.Add(this.label13);
            this.gradientPanel5.Controls.Add(this.gradientPanel7);
            this.gradientPanel5.Location = new System.Drawing.Point(447, 395);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(202, 69);
            this.gradientPanel5.TabIndex = 10009;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.Angle = 0F;
            this.gradientPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(211)))), ((int)(((byte)(230)))));
            this.gradientPanel7.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel7.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel7.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(4, 67);
            this.gradientPanel7.TabIndex = 0;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.Angle = 0F;
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel6.ColorBottom = System.Drawing.Color.White;
            this.gradientPanel6.ColorTop = System.Drawing.Color.White;
            this.gradientPanel6.Controls.Add(this.label14);
            this.gradientPanel6.Controls.Add(this.gradientPanel8);
            this.gradientPanel6.Location = new System.Drawing.Point(649, 395);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(202, 69);
            this.gradientPanel6.TabIndex = 10010;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.Angle = 0F;
            this.gradientPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(211)))), ((int)(((byte)(230)))));
            this.gradientPanel8.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel8.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel8.Location = new System.Drawing.Point(196, 0);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(4, 67);
            this.gradientPanel8.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(32, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 17);
            this.label13.TabIndex = 10015;
            this.label13.Text = "Demande en retard";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(32, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 17);
            this.label14.TabIndex = 10016;
            this.label14.Text = "Demande en retard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradientPanel6);
            this.Controls.Add(this.gradientPanel5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel4);
            this.Controls.Add(this.gradientPanel3);
            this.Controls.Add(this.gpDemandeEnCours);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.lblClient);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(890, 481);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.gpDemandeEnCours.ResumeLayout(false);
            this.gpDemandeEnCours.PerformLayout();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlDemande.ResumeLayout(false);
            this.pnlDemande.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlIntervention.ResumeLayout(false);
            this.pnlIntervention.PerformLayout();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            this.gradientPanel6.ResumeLayout(false);
            this.gradientPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblClient;
        private Classes.GradientPanel gradientPanel1;
        private Classes.GradientPanel gpDemandeEnCours;
        private Classes.GradientPanel gradientPanel3;
        private Classes.GradientPanel gradientPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDemEnRetard;
        private System.Windows.Forms.Label lblDemEncours;
        private System.Windows.Forms.Label lblIntEnCours;
        private System.Windows.Forms.Label lblIntEnRetard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel pnlDemande;
        private System.Windows.Forms.FlowLayoutPanel pnlIntervention;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private ucControls.lblDemInt lblDemInt1;
        private ucControls.lblDemInt lblDemInt2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Classes.GradientPanel gradientPanel5;
        private Classes.GradientPanel gradientPanel7;
        private Classes.GradientPanel gradientPanel6;
        private Classes.GradientPanel gradientPanel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
