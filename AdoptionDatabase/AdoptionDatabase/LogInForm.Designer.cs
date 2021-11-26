namespace AdoptionDatabase
{
    partial class LogInForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.adminLoginBtn = new System.Windows.Forms.Button();
            this.TitleBorder.SuspendLayout();
            this.DarkBlueTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBorder
            // 
            this.TitleBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.TitleBorder.Controls.Add(this.DarkBlueTitle);
            this.TitleBorder.Location = new System.Drawing.Point(1, 28);
            this.TitleBorder.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBorder.Name = "TitleBorder";
            this.TitleBorder.Size = new System.Drawing.Size(1443, 165);
            this.TitleBorder.TabIndex = 1;
            // 
            // DarkBlueTitle
            // 
            this.DarkBlueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.DarkBlueTitle.Controls.Add(this.pictureBox1);
            this.DarkBlueTitle.Controls.Add(this.MainTitle);
            this.DarkBlueTitle.Location = new System.Drawing.Point(15, 12);
            this.DarkBlueTitle.Margin = new System.Windows.Forms.Padding(4);
            this.DarkBlueTitle.Name = "DarkBlueTitle";
            this.DarkBlueTitle.Size = new System.Drawing.Size(1389, 138);
            this.DarkBlueTitle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdoptionDatabase.Properties.Resources.paw;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(176, 1);
            this.MainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(559, 153);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "MICHIGAN\'S PREMIER\r\nADOPTION EVENT\r\n";
            this.MainTitle.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 613);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(351, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 444);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.adminLoginBtn);
            this.panel3.Controls.Add(this.passwordText);
            this.panel3.Controls.Add(this.passwordLabel);
            this.panel3.Controls.Add(this.usernameLabel);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 438);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AdoptionDatabase.Properties.Resources.outlook_g17d530a5b_1920;
            this.pictureBox2.Location = new System.Drawing.Point(102, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(98, 250);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 23);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(98, 310);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(244, 310);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(284, 22);
            this.passwordText.TabIndex = 4;
            // 
            // adminLoginBtn
            // 
            this.adminLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.adminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminLoginBtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBtn.ForeColor = System.Drawing.Color.White;
            this.adminLoginBtn.Location = new System.Drawing.Point(102, 361);
            this.adminLoginBtn.Name = "adminLoginBtn";
            this.adminLoginBtn.Size = new System.Drawing.Size(426, 42);
            this.adminLoginBtn.TabIndex = 5;
            this.adminLoginBtn.Text = "LOGIN";
            this.adminLoginBtn.UseVisualStyleBackColor = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1421, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBorder);
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.TitleBorder.ResumeLayout(false);
            this.DarkBlueTitle.ResumeLayout(false);
            this.DarkBlueTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBorder;
        private System.Windows.Forms.Panel DarkBlueTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button adminLoginBtn;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}