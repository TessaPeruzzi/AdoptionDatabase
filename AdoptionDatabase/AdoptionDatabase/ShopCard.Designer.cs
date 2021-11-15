namespace AdoptionDatabase
{
    partial class ShopCard
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
            this.ShopPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShopLabel = new System.Windows.Forms.Label();
            this.ShopInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShopPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopPicture
            // 
            this.ShopPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShopPicture.Location = new System.Drawing.Point(12, 76);
            this.ShopPicture.Name = "ShopPicture";
            this.ShopPicture.Size = new System.Drawing.Size(223, 201);
            this.ShopPicture.TabIndex = 0;
            this.ShopPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.ShopLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 55);
            this.panel1.TabIndex = 1;
            // 
            // ShopLabel
            // 
            this.ShopLabel.AutoSize = true;
            this.ShopLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopLabel.ForeColor = System.Drawing.Color.White;
            this.ShopLabel.Location = new System.Drawing.Point(3, 11);
            this.ShopLabel.Name = "ShopLabel";
            this.ShopLabel.Size = new System.Drawing.Size(152, 33);
            this.ShopLabel.TabIndex = 2;
            this.ShopLabel.Text = "SHOP NAME";
            // 
            // ShopInfo
            // 
            this.ShopInfo.AutoSize = true;
            this.ShopInfo.Location = new System.Drawing.Point(243, 77);
            this.ShopInfo.Name = "ShopInfo";
            this.ShopInfo.Size = new System.Drawing.Size(44, 16);
            this.ShopInfo.TabIndex = 2;
            this.ShopInfo.Text = "label1";
            // 
            // ShopCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.ShopInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShopPicture);
            this.Name = "ShopCard";
            this.Size = new System.Drawing.Size(472, 290);
            ((System.ComponentModel.ISupportInitialize)(this.ShopPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ShopPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ShopLabel;
        private System.Windows.Forms.Label ShopInfo;
    }
}
