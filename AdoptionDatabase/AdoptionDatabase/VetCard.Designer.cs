namespace AdoptionDatabase
{
    partial class VetCard
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
            this.VetPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VetLabel = new System.Windows.Forms.Label();
            this.VetInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VetPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VetPicture
            // 
            this.VetPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VetPicture.Location = new System.Drawing.Point(12, 76);
            this.VetPicture.Name = "VetPicture";
            this.VetPicture.Size = new System.Drawing.Size(223, 201);
            this.VetPicture.TabIndex = 0;
            this.VetPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.VetLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 55);
            this.panel1.TabIndex = 1;
            // 
            // VetLabel
            // 
            this.VetLabel.AutoSize = true;
            this.VetLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetLabel.ForeColor = System.Drawing.Color.White;
            this.VetLabel.Location = new System.Drawing.Point(3, 11);
            this.VetLabel.Name = "VetLabel";
            this.VetLabel.Size = new System.Drawing.Size(131, 33);
            this.VetLabel.TabIndex = 2;
            this.VetLabel.Text = "VET NAME";
            // 
            // VetInfo
            // 
            this.VetInfo.AutoSize = true;
            this.VetInfo.Location = new System.Drawing.Point(243, 77);
            this.VetInfo.Name = "VetInfo";
            this.VetInfo.Size = new System.Drawing.Size(28, 16);
            this.VetInfo.TabIndex = 2;
            this.VetInfo.Text = "Info";
            // 
            // VetCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.VetInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VetPicture);
            this.Name = "VetCard";
            this.Size = new System.Drawing.Size(472, 290);
            ((System.ComponentModel.ISupportInitialize)(this.VetPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VetPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VetLabel;
        private System.Windows.Forms.Label VetInfo;
    }
}
