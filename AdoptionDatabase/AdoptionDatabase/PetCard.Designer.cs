namespace AdoptionDatabase
{
    partial class PetCard
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
            this.AgencyPanel = new System.Windows.Forms.Panel();
            this.AgencyLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AgencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgencyPanel
            // 
            this.AgencyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.AgencyPanel.Controls.Add(this.AgencyLabel);
            this.AgencyPanel.Location = new System.Drawing.Point(16, 216);
            this.AgencyPanel.Name = "AgencyPanel";
            this.AgencyPanel.Size = new System.Drawing.Size(441, 61);
            this.AgencyPanel.TabIndex = 3;
            // 
            // AgencyLabel
            // 
            this.AgencyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgencyLabel.AutoSize = true;
            this.AgencyLabel.Font = new System.Drawing.Font("Arial", 14.2F, System.Drawing.FontStyle.Bold);
            this.AgencyLabel.ForeColor = System.Drawing.Color.White;
            this.AgencyLabel.Location = new System.Drawing.Point(3, 15);
            this.AgencyLabel.Name = "AgencyLabel";
            this.AgencyLabel.Size = new System.Drawing.Size(263, 29);
            this.AgencyLabel.TabIndex = 0;
            this.AgencyLabel.Text = "AGENCY GOES HERE";
            this.AgencyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.NameLabel.Location = new System.Drawing.Point(267, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(102, 38);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(271, 71);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(27, 16);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PetCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AgencyPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PetCard";
            this.Size = new System.Drawing.Size(472, 290);
            this.AgencyPanel.ResumeLayout(false);
            this.AgencyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel AgencyPanel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label AgencyLabel;
        public System.Windows.Forms.Label InfoLabel;
    }
}
