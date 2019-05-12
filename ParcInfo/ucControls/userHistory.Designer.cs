namespace ParcInfo.ucControls
{
    partial class userHistory
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
            this.lblVarchar = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leftLine = new ParcInfo.Classes.GradientPanel();
            this.SuspendLayout();
            // 
            // lblVarchar
            // 
            this.lblVarchar.AutoSize = true;
            this.lblVarchar.Location = new System.Drawing.Point(9, 12);
            this.lblVarchar.Name = "lblVarchar";
            this.lblVarchar.Size = new System.Drawing.Size(35, 13);
            this.lblVarchar.TabIndex = 1;
            this.lblVarchar.Text = "label1";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 35);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(483, 1);
            this.pnlBottom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(482, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 34);
            this.panel2.TabIndex = 4;
            // 
            // leftLine
            // 
            this.leftLine.Angle = 0F;
            this.leftLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.leftLine.ColorBottom = System.Drawing.Color.Empty;
            this.leftLine.ColorTop = System.Drawing.Color.Empty;
            this.leftLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLine.Location = new System.Drawing.Point(0, 1);
            this.leftLine.Margin = new System.Windows.Forms.Padding(0);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(2, 34);
            this.leftLine.TabIndex = 5;
            // 
            // userHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.leftLine);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblVarchar);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "userHistory";
            this.Size = new System.Drawing.Size(483, 36);
            this.Load += new System.EventHandler(this.userHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVarchar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Classes.GradientPanel leftLine;
    }
}
