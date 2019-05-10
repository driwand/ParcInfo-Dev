namespace ParcInfo.ucControls
{
    partial class ucNotifList
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
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewMore = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.btnViewMore);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(202, 29);
            this.pnlList.TabIndex = 0;
            // 
            // btnViewMore
            // 
            this.btnViewMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnViewMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMore.ForeColor = System.Drawing.Color.White;
            this.btnViewMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMore.Location = new System.Drawing.Point(0, 0);
            this.btnViewMore.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Size = new System.Drawing.Size(202, 29);
            this.btnViewMore.TabIndex = 74;
            this.btnViewMore.Text = "View More";
            this.btnViewMore.UseVisualStyleBackColor = false;
            this.btnViewMore.Click += new System.EventHandler(this.btnViewMore_Click);
            // 
            // ucNotifList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(202, 29);
            this.Name = "ucNotifList";
            this.Size = new System.Drawing.Size(202, 29);
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel pnlList;
        private System.Windows.Forms.Button btnViewMore;
    }
}
