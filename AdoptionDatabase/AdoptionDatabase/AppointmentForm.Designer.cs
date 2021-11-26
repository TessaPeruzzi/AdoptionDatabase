namespace AdoptionDatabase
{
    partial class Appointment_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentTitle = new System.Windows.Forms.Label();
            this.timeslotPanel = new System.Windows.Forms.Panel();
            this.timeSlotList = new System.Windows.Forms.TableLayoutPanel();
            this.adopterFormPanel = new System.Windows.Forms.Panel();
            this.adopterFormButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.timeslotPanel.SuspendLayout();
            this.adopterFormPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.appointmentTitle);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 59);
            this.panel1.TabIndex = 0;
            // 
            // appointmentTitle
            // 
            this.appointmentTitle.AutoSize = true;
            this.appointmentTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTitle.Location = new System.Drawing.Point(156, 11);
            this.appointmentTitle.Name = "appointmentTitle";
            this.appointmentTitle.Size = new System.Drawing.Size(331, 33);
            this.appointmentTitle.TabIndex = 0;
            this.appointmentTitle.Text = "Appointments Available";
            // 
            // timeslotPanel
            // 
            this.timeslotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.timeslotPanel.Controls.Add(this.timeSlotList);
            this.timeslotPanel.Location = new System.Drawing.Point(13, 137);
            this.timeslotPanel.Name = "timeslotPanel";
            this.timeslotPanel.Size = new System.Drawing.Size(616, 205);
            this.timeslotPanel.TabIndex = 1;
            // 
            // timeSlotList
            // 
            this.timeSlotList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.timeSlotList.ColumnCount = 3;
            this.timeSlotList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.timeSlotList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.timeSlotList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeSlotList.Location = new System.Drawing.Point(3, 6);
            this.timeSlotList.Name = "timeSlotList";
            this.timeSlotList.RowCount = 5;
            this.timeSlotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeSlotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeSlotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeSlotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeSlotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeSlotList.Size = new System.Drawing.Size(610, 196);
            this.timeSlotList.TabIndex = 0;
            // 
            // adopterFormPanel
            // 
            this.adopterFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.adopterFormPanel.Controls.Add(this.stateText);
            this.adopterFormPanel.Controls.Add(this.zipText);
            this.adopterFormPanel.Controls.Add(this.cityText);
            this.adopterFormPanel.Controls.Add(this.textBox1);
            this.adopterFormPanel.Controls.Add(this.phoneText);
            this.adopterFormPanel.Controls.Add(this.lastNameText);
            this.adopterFormPanel.Controls.Add(this.firstNameText);
            this.adopterFormPanel.Controls.Add(this.zipLabel);
            this.adopterFormPanel.Controls.Add(this.cityLabel);
            this.adopterFormPanel.Controls.Add(this.addressLabel);
            this.adopterFormPanel.Controls.Add(this.phoneNumLabel);
            this.adopterFormPanel.Controls.Add(this.lastNameLabel);
            this.adopterFormPanel.Controls.Add(this.firstNameLabel);
            this.adopterFormPanel.Location = new System.Drawing.Point(13, 361);
            this.adopterFormPanel.Name = "adopterFormPanel";
            this.adopterFormPanel.Size = new System.Drawing.Size(613, 120);
            this.adopterFormPanel.TabIndex = 2;
            // 
            // adopterFormButton
            // 
            this.adopterFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.adopterFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adopterFormButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterFormButton.ForeColor = System.Drawing.Color.White;
            this.adopterFormButton.Location = new System.Drawing.Point(182, 499);
            this.adopterFormButton.Name = "adopterFormButton";
            this.adopterFormButton.Size = new System.Drawing.Size(277, 40);
            this.adopterFormButton.TabIndex = 3;
            this.adopterFormButton.Text = "SUBMIT";
            this.adopterFormButton.UseVisualStyleBackColor = false;
            this.adopterFormButton.Click += new System.EventHandler(this.closeAppointmentForm);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(13, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 41);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 14);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 19);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 49);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(98, 19);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.ForeColor = System.Drawing.Color.White;
            this.phoneNumLabel.Location = new System.Drawing.Point(7, 81);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(132, 19);
            this.phoneNumLabel.TabIndex = 2;
            this.phoneNumLabel.Text = "Phone Number:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addressLabel.Location = new System.Drawing.Point(310, 14);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(80, 19);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(306, 49);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(92, 19);
            this.cityLabel.TabIndex = 4;
            this.cityLabel.Text = "City/State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.ForeColor = System.Drawing.Color.White;
            this.zipLabel.Location = new System.Drawing.Point(306, 81);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(84, 19);
            this.zipLabel.TabIndex = 5;
            this.zipLabel.Text = "Zip Code:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(161, 14);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(126, 22);
            this.firstNameText.TabIndex = 6;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(161, 49);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(126, 22);
            this.lastNameText.TabIndex = 7;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(161, 80);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(126, 22);
            this.phoneText.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 9;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(412, 48);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(126, 22);
            this.cityText.TabIndex = 10;
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(412, 81);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(126, 22);
            this.zipText.TabIndex = 11;
            // 
            // stateText
            // 
            this.stateText.FormattingEnabled = true;
            this.stateText.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateText.Location = new System.Drawing.Point(554, 49);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(55, 24);
            this.stateText.TabIndex = 12;
            // 
            // Appointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adopterFormButton);
            this.Controls.Add(this.adopterFormPanel);
            this.Controls.Add(this.timeslotPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Appointment_Form";
            this.Text = "Appointment_Form";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.timeslotPanel.ResumeLayout(false);
            this.adopterFormPanel.ResumeLayout(false);
            this.adopterFormPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appointmentTitle;
        private System.Windows.Forms.Panel timeslotPanel;
        private System.Windows.Forms.Panel adopterFormPanel;
        private System.Windows.Forms.TableLayoutPanel timeSlotList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ComboBox stateText;
        public System.Windows.Forms.Button adopterFormButton;
    }
}