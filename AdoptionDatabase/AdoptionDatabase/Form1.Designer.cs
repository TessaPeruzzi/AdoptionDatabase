namespace AdoptionDatabase
{
    partial class MainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleBorder = new System.Windows.Forms.Panel();
            this.DarkBlueTitle = new System.Windows.Forms.Panel();
            this.MainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PetButton = new System.Windows.Forms.Button();
            this.AgencyButton = new System.Windows.Forms.Button();
            this.VetButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.ButtonWhite = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CardContainer = new System.Windows.Forms.Panel();
            this.CardScroller = new System.Windows.Forms.VScrollBar();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TitleBorder.SuspendLayout();
            this.DarkBlueTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ButtonWhite.SuspendLayout();
            this.panel2.SuspendLayout();
            this.CardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBorder
            // 
            this.TitleBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.TitleBorder.Controls.Add(this.DarkBlueTitle);
            this.TitleBorder.Location = new System.Drawing.Point(1, 23);
            this.TitleBorder.Name = "TitleBorder";
            this.TitleBorder.Size = new System.Drawing.Size(1082, 134);
            this.TitleBorder.TabIndex = 0;
            this.TitleBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DarkBlueTitle
            // 
            this.DarkBlueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.DarkBlueTitle.Controls.Add(this.pictureBox1);
            this.DarkBlueTitle.Controls.Add(this.MainTitle);
            this.DarkBlueTitle.Location = new System.Drawing.Point(11, 10);
            this.DarkBlueTitle.Name = "DarkBlueTitle";
            this.DarkBlueTitle.Size = new System.Drawing.Size(1042, 112);
            this.DarkBlueTitle.TabIndex = 1;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(132, 1);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(447, 123);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "MICHIGAN\'S PREMIER\r\nADOPTION EVENT\r\n";
            this.MainTitle.UseCompatibleTextRendering = true;
            this.MainTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdoptionDatabase.Properties.Resources.paw;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.ShopButton);
            this.panel1.Controls.Add(this.VetButton);
            this.panel1.Controls.Add(this.AgencyButton);
            this.panel1.Controls.Add(this.PetButton);
            this.panel1.Location = new System.Drawing.Point(1, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 72);
            this.panel1.TabIndex = 1;
            // 
            // PetButton
            // 
            this.PetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.PetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetButton.ForeColor = System.Drawing.Color.White;
            this.PetButton.Location = new System.Drawing.Point(11, 8);
            this.PetButton.Name = "PetButton";
            this.PetButton.Size = new System.Drawing.Size(254, 55);
            this.PetButton.TabIndex = 2;
            this.PetButton.Text = "PETS";
            this.PetButton.UseVisualStyleBackColor = false;
            // 
            // AgencyButton
            // 
            this.AgencyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.AgencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgencyButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgencyButton.ForeColor = System.Drawing.Color.White;
            this.AgencyButton.Location = new System.Drawing.Point(275, 8);
            this.AgencyButton.Name = "AgencyButton";
            this.AgencyButton.Size = new System.Drawing.Size(254, 55);
            this.AgencyButton.TabIndex = 3;
            this.AgencyButton.Text = "AGENCIES";
            this.AgencyButton.UseVisualStyleBackColor = false;
            // 
            // VetButton
            // 
            this.VetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.VetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VetButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetButton.ForeColor = System.Drawing.Color.White;
            this.VetButton.Location = new System.Drawing.Point(537, 8);
            this.VetButton.Name = "VetButton";
            this.VetButton.Size = new System.Drawing.Size(254, 55);
            this.VetButton.TabIndex = 4;
            this.VetButton.Text = "VETS";
            this.VetButton.UseVisualStyleBackColor = false;
            // 
            // ShopButton
            // 
            this.ShopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.ShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopButton.ForeColor = System.Drawing.Color.White;
            this.ShopButton.Location = new System.Drawing.Point(799, 8);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(254, 55);
            this.ShopButton.TabIndex = 5;
            this.ShopButton.Text = "SHOPS";
            this.ShopButton.UseVisualStyleBackColor = false;
            // 
            // ButtonWhite
            // 
            this.ButtonWhite.BackColor = System.Drawing.Color.White;
            this.ButtonWhite.Controls.Add(this.CardContainer);
            this.ButtonWhite.Controls.Add(this.panel2);
            this.ButtonWhite.Location = new System.Drawing.Point(1, 271);
            this.ButtonWhite.Name = "ButtonWhite";
            this.ButtonWhite.Size = new System.Drawing.Size(1082, 416);
            this.ButtonWhite.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FilterLabel);
            this.panel2.Location = new System.Drawing.Point(11, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 390);
            this.panel2.TabIndex = 0;
            // 
            // CardContainer
            // 
            this.CardContainer.Controls.Add(this.CardScroller);
            this.CardContainer.Location = new System.Drawing.Point(275, 15);
            this.CardContainer.Name = "CardContainer";
            this.CardContainer.Size = new System.Drawing.Size(787, 389);
            this.CardContainer.TabIndex = 1;
            // 
            // CardScroller
            // 
            this.CardScroller.Location = new System.Drawing.Point(770, 0);
            this.CardScroller.Name = "CardScroller";
            this.CardScroller.Size = new System.Drawing.Size(17, 389);
            this.CardScroller.TabIndex = 0;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.Location = new System.Drawing.Point(0, 11);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(74, 33);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter";
            this.FilterLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.panel3.Location = new System.Drawing.Point(6, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.ButtonWhite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Michigan\'s Premier Adoption Event";
            this.TitleBorder.ResumeLayout(false);
            this.DarkBlueTitle.ResumeLayout(false);
            this.DarkBlueTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ButtonWhite.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CardContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBorder;
        private System.Windows.Forms.Panel DarkBlueTitle;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button VetButton;
        private System.Windows.Forms.Button AgencyButton;
        private System.Windows.Forms.Button PetButton;
        private System.Windows.Forms.Panel ButtonWhite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CardContainer;
        private System.Windows.Forms.VScrollBar CardScroller;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Panel panel3;
    }
}

