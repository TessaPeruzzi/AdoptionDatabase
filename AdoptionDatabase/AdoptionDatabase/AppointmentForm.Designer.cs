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
            this.adopterFormPanel = new System.Windows.Forms.Panel();
            this.adopterFormButton = new System.Windows.Forms.Button();
            this.timeslotList = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.timeslotPanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(548, 59);
            this.panel1.TabIndex = 0;
            // 
            // appointmentTitle
            // 
            this.appointmentTitle.AutoSize = true;
            this.appointmentTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTitle.Location = new System.Drawing.Point(104, 15);
            this.appointmentTitle.Name = "appointmentTitle";
            this.appointmentTitle.Size = new System.Drawing.Size(331, 33);
            this.appointmentTitle.TabIndex = 0;
            this.appointmentTitle.Text = "Appointments Available";
            // 
            // timeslotPanel
            // 
            this.timeslotPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.timeslotPanel.Controls.Add(this.timeslotList);
            this.timeslotPanel.Location = new System.Drawing.Point(13, 137);
            this.timeslotPanel.Name = "timeslotPanel";
            this.timeslotPanel.Size = new System.Drawing.Size(547, 165);
            this.timeslotPanel.TabIndex = 1;
            // 
            // adopterFormPanel
            // 
            this.adopterFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.adopterFormPanel.Location = new System.Drawing.Point(13, 335);
            this.adopterFormPanel.Name = "adopterFormPanel";
            this.adopterFormPanel.Size = new System.Drawing.Size(547, 161);
            this.adopterFormPanel.TabIndex = 2;
            // 
            // adopterFormButton
            // 
            this.adopterFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.adopterFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adopterFormButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopterFormButton.ForeColor = System.Drawing.Color.White;
            this.adopterFormButton.Location = new System.Drawing.Point(148, 516);
            this.adopterFormButton.Name = "adopterFormButton";
            this.adopterFormButton.Size = new System.Drawing.Size(277, 23);
            this.adopterFormButton.TabIndex = 3;
            this.adopterFormButton.Text = "SUBMIT";
            this.adopterFormButton.UseVisualStyleBackColor = false;
            // 
            // timeslotList
            // 
            this.timeslotList.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.timeslotList.ColumnCount = 3;
            this.timeslotList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.timeslotList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.timeslotList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.timeslotList.Location = new System.Drawing.Point(3, 6);
            this.timeslotList.Name = "timeslotList";
            this.timeslotList.RowCount = 2;
            this.timeslotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeslotList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timeslotList.Size = new System.Drawing.Size(541, 159);
            this.timeslotList.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(13, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 41);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 41);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Appointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.adopterFormButton);
            this.Controls.Add(this.adopterFormPanel);
            this.Controls.Add(this.timeslotPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Appointment_Form";
            this.Text = "Appointment_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.timeslotPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button adopterFormButton;
        private System.Windows.Forms.TableLayoutPanel timeslotList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}