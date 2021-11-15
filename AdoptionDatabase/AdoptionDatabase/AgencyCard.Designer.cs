namespace AdoptionDatabase
{
    partial class AgencyCard
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
            this.AgencyPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AgencyName = new System.Windows.Forms.Label();
            this.AgnecyInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgencyPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgencyPicture
            // 
            this.AgencyPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgencyPicture.Location = new System.Drawing.Point(12, 76);
            this.AgencyPicture.Name = "AgencyPicture";
            this.AgencyPicture.Size = new System.Drawing.Size(223, 201);
            this.AgencyPicture.TabIndex = 0;
            this.AgencyPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.AgencyName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 55);
            this.panel1.TabIndex = 1;
            // 
            // AgencyName
            // 
            this.AgencyName.AutoSize = true;
            this.AgencyName.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgencyName.ForeColor = System.Drawing.Color.White;
            this.AgencyName.Location = new System.Drawing.Point(3, 11);
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.Size = new System.Drawing.Size(183, 33);
            this.AgencyName.TabIndex = 0;
            this.AgencyName.Text = "AGENCY NAME";
            // 
            // AgnecyInfo
            // 
            this.AgnecyInfo.AutoSize = true;
            this.AgnecyInfo.Location = new System.Drawing.Point(243, 77);
            this.AgnecyInfo.Name = "AgnecyInfo";
            this.AgnecyInfo.Size = new System.Drawing.Size(28, 16);
            this.AgnecyInfo.TabIndex = 2;
            this.AgnecyInfo.Text = "Info";
            // 
            // AgencyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.AgnecyInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AgencyPicture);
            this.Name = "AgencyCard";
            this.Size = new System.Drawing.Size(472, 290);
            ((System.ComponentModel.ISupportInitialize)(this.AgencyPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AgencyPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AgencyName;
        private System.Windows.Forms.Label AgnecyInfo;
    }
}
