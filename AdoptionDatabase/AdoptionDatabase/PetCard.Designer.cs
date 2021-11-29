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
            this.AppointmentButton = new System.Windows.Forms.Button();
            this.AgencyPanel = new System.Windows.Forms.Panel();
            this.AgencyLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AgencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentButton
            // 
            this.AppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.AppointmentButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentButton.Location = new System.Drawing.Point(16, 193);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(245, 42);
            this.AppointmentButton.TabIndex = 1;
            this.AppointmentButton.Text = "APPOINTMENTS";
            this.AppointmentButton.UseVisualStyleBackColor = false;
            this.AppointmentButton.Click += new System.EventHandler(this.appointmentBtnClick);
            // 
            // AgencyPanel
            // 
            this.AgencyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.AgencyPanel.Controls.Add(this.AgencyLabel);
            this.AgencyPanel.Location = new System.Drawing.Point(16, 241);
            this.AgencyPanel.Name = "AgencyPanel";
            this.AgencyPanel.Size = new System.Drawing.Size(441, 41);
            this.AgencyPanel.TabIndex = 3;
            // 
            // AgencyLabel
            // 
            this.AgencyLabel.AutoSize = true;
            this.AgencyLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgencyLabel.ForeColor = System.Drawing.Color.White;
            this.AgencyLabel.Location = new System.Drawing.Point(3, 6);
            this.AgencyLabel.Name = "AgencyLabel";
            this.AgencyLabel.Size = new System.Drawing.Size(253, 33);
            this.AgencyLabel.TabIndex = 0;
            this.AgencyLabel.Text = "AGENCY GOES HERE";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(267, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(113, 42);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(271, 57);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(28, 16);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 172);
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
            this.Controls.Add(this.AppointmentButton);
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
        private System.Windows.Forms.Button AppointmentButton;
        private System.Windows.Forms.Panel AgencyPanel;
        public System.Windows.Forms.Label NameLabel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label AgencyLabel;
        public System.Windows.Forms.Label InfoLabel;
    }
}
