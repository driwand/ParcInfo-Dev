namespace ParcInfo.ucClient
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
            this.components = new System.ComponentModel.Container();
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
            this.label8 = new System.Windows.Forms.Label();
            this.lblEdited = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEditedDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStartIntervention = new System.Windows.Forms.ToolStripMenuItem();
            this.gpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDemande)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFind
            // 
            this.gpFind.Controls.Add(this.btnFind);
            this.gpFind.Controls.Add(this.txtFind);
            this.gpFind.Controls.Add(this.label15);
            this.gpFind.Location = new System.Drawing.Point(14, 48);
            this.gpFind.Name = "gpFind";
            this.gpFind.Size = new System.Drawing.Size(732, 50);
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
            this.btnFind.Location = new System.Drawing.Point(699, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 28);
            this.btnFind.TabIndex = 51;
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(140, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(553, 20);
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
            this.btnTraiter.Location = new System.Drawing.Point(752, 56);
            this.btnTraiter.Name = "btnTraiter";
            this.btnTraiter.Size = new System.Drawing.Size(125, 35);
            this.btnTraiter.TabIndex = 123;
            this.btnTraiter.Text = "  Traitee";
            this.btnTraiter.UseVisualStyleBackColor = false;
            this.btnTraiter.Click += new System.EventHandler(this.btnTraiter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 2);
            this.panel1.TabIndex = 120;
            // 
            // lblListRequest
            // 
            this.lblListRequest.AutoSize = true;
            this.lblListRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListRequest.ForeColor = System.Drawing.Color.Black;
            this.lblListRequest.Location = new System.Drawing.Point(55, 14);
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
            this.dgDemande.Location = new System.Drawing.Point(14, 104);
            this.dgDemande.Name = "dgDemande";
            this.dgDemande.ReadOnly = true;
            this.dgDemande.Size = new System.Drawing.Size(863, 347);
            this.dgDemande.TabIndex = 118;
            this.dgDemande.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDemande_CellMouseDown);
            this.dgDemande.DoubleClick += new System.EventHandler(this.dgDemande_DoubleClick);
            // 
            // lblTotalRequest
            // 
            this.lblTotalRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.lblTotalRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRequest.ForeColor = System.Drawing.Color.White;
            this.lblTotalRequest.Location = new System.Drawing.Point(22, 13);
            this.lblTotalRequest.Name = "lblTotalRequest";
            this.lblTotalRequest.Size = new System.Drawing.Size(21, 18);
            this.lblTotalRequest.TabIndex = 123;
            this.lblTotalRequest.Text = "33";
            this.lblTotalRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmployeClient
            // 
            this.lblEmployeClient.AutoSize = true;
            this.lblEmployeClient.Location = new System.Drawing.Point(187, 15);
            this.lblEmployeClient.Name = "lblEmployeClient";
            this.lblEmployeClient.Size = new System.Drawing.Size(36, 13);
            this.lblEmployeClient.TabIndex = 121;
            this.lblEmployeClient.Text = "[ text ]";
            this.lblEmployeClient.Visible = false;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(14, 457);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(171, 17);
            this.cbDelete.TabIndex = 125;
            this.cbDelete.Text = "Afficher les elements supprimer";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "Dernier modification par :";
            // 
            // lblEdited
            // 
            this.lblEdited.AutoSize = true;
            this.lblEdited.Location = new System.Drawing.Point(333, 459);
            this.lblEdited.Name = "lblEdited";
            this.lblEdited.Size = new System.Drawing.Size(37, 13);
            this.lblEdited.TabIndex = 127;
            this.lblEdited.Text = "aucun";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 129;
            this.label13.Text = "Modifier le :";
            // 
            // lblEditedDate
            // 
            this.lblEditedDate.AutoSize = true;
            this.lblEditedDate.Location = new System.Drawing.Point(456, 459);
            this.lblEditedDate.Name = "lblEditedDate";
            this.lblEditedDate.Size = new System.Drawing.Size(49, 13);
            this.lblEditedDate.TabIndex = 128;
            this.lblEditedDate.Text = "****/**/**";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(191, 458);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 15);
            this.panel2.TabIndex = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDetails,
            this.menuStartIntervention});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 48);
            // 
            // menuDetails
            // 
            this.menuDetails.Name = "menuDetails";
            this.menuDetails.Size = new System.Drawing.Size(186, 22);
            this.menuDetails.Text = "Details";
            this.menuDetails.Click += new System.EventHandler(this.menuDetails_Click);
            // 
            // menuStartIntervention
            // 
            this.menuStartIntervention.Name = "menuStartIntervention";
            this.menuStartIntervention.Size = new System.Drawing.Size(186, 22);
            this.menuStartIntervention.Text = "Demarer Intervention";
            this.menuStartIntervention.Click += new System.EventHandler(this.menuStartIntervention_Click);
            // 
            // ListDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblEditedDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblEdited);
            this.Controls.Add(this.label8);
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
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEdited;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEditedDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDetails;
        private System.Windows.Forms.ToolStripMenuItem menuStartIntervention;
    }
}
