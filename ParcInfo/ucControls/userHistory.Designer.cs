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
            this.leftLine = new ParcInfo.Classes.GradientPanel();
            this.SuspendLayout();
            // 
            // leftLine
            // 
            this.leftLine.Angle = 0F;
            this.leftLine.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.leftLine.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.leftLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLine.Location = new System.Drawing.Point(0, 0);
            this.leftLine.Name = "leftLine";
            this.leftLine.Size = new System.Drawing.Size(3, 68);
            this.leftLine.TabIndex = 0;
            // 
            // userHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.leftLine);
            this.Name = "userHistory";
            this.Size = new System.Drawing.Size(442, 68);
            this.ResumeLayout(false);

        }

        #endregion

        private Classes.GradientPanel leftLine;
    }
}
