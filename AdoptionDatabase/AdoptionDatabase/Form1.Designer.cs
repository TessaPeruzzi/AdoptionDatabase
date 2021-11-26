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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShopButton = new System.Windows.Forms.Button();
            this.VetButton = new System.Windows.Forms.Button();
            this.AgencyButton = new System.Windows.Forms.Button();
            this.PetButton = new System.Windows.Forms.Button();
            this.ButtonWhite = new System.Windows.Forms.Panel();
            this.CardContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btwnComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.ageSelectionBox = new System.Windows.Forms.ComboBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.CheckBoxFemale = new System.Windows.Forms.CheckBox();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.SexCheckBox = new System.Windows.Forms.Label();
            this.PetTypeTitle = new System.Windows.Forms.Label();
            this.CheckBoxContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.hamburgerMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hamburgerLogBtn = new System.Windows.Forms.Button();
            this.TitleBorder.SuspendLayout();
            this.DarkBlueTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ButtonWhite.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.TitleBorder.TabIndex = 0;
            // 
            // DarkBlueTitle
            // 
            this.DarkBlueTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.DarkBlueTitle.Controls.Add(this.panel4);
            this.DarkBlueTitle.Controls.Add(this.hamburgerMenu);
            this.DarkBlueTitle.Controls.Add(this.pictureBox1);
            this.DarkBlueTitle.Controls.Add(this.MainTitle);
            this.DarkBlueTitle.Location = new System.Drawing.Point(15, 12);
            this.DarkBlueTitle.Margin = new System.Windows.Forms.Padding(4);
            this.DarkBlueTitle.Name = "DarkBlueTitle";
            this.DarkBlueTitle.Size = new System.Drawing.Size(1389, 138);
            this.DarkBlueTitle.TabIndex = 1;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.ShopButton);
            this.panel1.Controls.Add(this.VetButton);
            this.panel1.Controls.Add(this.AgencyButton);
            this.panel1.Controls.Add(this.PetButton);
            this.panel1.Location = new System.Drawing.Point(1, 219);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 89);
            this.panel1.TabIndex = 1;
            // 
            // ShopButton
            // 
            this.ShopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.ShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopButton.ForeColor = System.Drawing.Color.White;
            this.ShopButton.Location = new System.Drawing.Point(1065, 10);
            this.ShopButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(339, 68);
            this.ShopButton.TabIndex = 5;
            this.ShopButton.Text = "SHOPS";
            this.ShopButton.UseVisualStyleBackColor = false;
            this.ShopButton.Click += new System.EventHandler(this.shopBtnClick);
            // 
            // VetButton
            // 
            this.VetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.VetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VetButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VetButton.ForeColor = System.Drawing.Color.White;
            this.VetButton.Location = new System.Drawing.Point(716, 10);
            this.VetButton.Margin = new System.Windows.Forms.Padding(4);
            this.VetButton.Name = "VetButton";
            this.VetButton.Size = new System.Drawing.Size(339, 68);
            this.VetButton.TabIndex = 4;
            this.VetButton.Text = "VETS";
            this.VetButton.UseVisualStyleBackColor = false;
            this.VetButton.Click += new System.EventHandler(this.vetBtnClick);
            // 
            // AgencyButton
            // 
            this.AgencyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.AgencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgencyButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgencyButton.ForeColor = System.Drawing.Color.White;
            this.AgencyButton.Location = new System.Drawing.Point(367, 10);
            this.AgencyButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgencyButton.Name = "AgencyButton";
            this.AgencyButton.Size = new System.Drawing.Size(339, 68);
            this.AgencyButton.TabIndex = 3;
            this.AgencyButton.Text = "AGENCIES";
            this.AgencyButton.UseVisualStyleBackColor = false;
            this.AgencyButton.Click += new System.EventHandler(this.agencyBtnClick);
            // 
            // PetButton
            // 
            this.PetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.PetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetButton.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetButton.ForeColor = System.Drawing.Color.White;
            this.PetButton.Location = new System.Drawing.Point(15, 10);
            this.PetButton.Margin = new System.Windows.Forms.Padding(4);
            this.PetButton.Name = "PetButton";
            this.PetButton.Size = new System.Drawing.Size(339, 68);
            this.PetButton.TabIndex = 2;
            this.PetButton.Text = "PETS";
            this.PetButton.UseVisualStyleBackColor = false;
            this.PetButton.Click += new System.EventHandler(this.petBtnClick);
            // 
            // ButtonWhite
            // 
            this.ButtonWhite.BackColor = System.Drawing.Color.White;
            this.ButtonWhite.Controls.Add(this.CardContainer);
            this.ButtonWhite.Controls.Add(this.panel2);
            this.ButtonWhite.Location = new System.Drawing.Point(1, 334);
            this.ButtonWhite.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonWhite.Name = "ButtonWhite";
            this.ButtonWhite.Size = new System.Drawing.Size(1443, 512);
            this.ButtonWhite.TabIndex = 2;
            // 
            // CardContainer
            // 
            this.CardContainer.ColumnCount = 2;
            this.CardContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CardContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CardContainer.Location = new System.Drawing.Point(374, 19);
            this.CardContainer.Name = "CardContainer";
            this.CardContainer.RowCount = 1;
            this.CardContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CardContainer.Size = new System.Drawing.Size(1030, 478);
            this.CardContainer.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.btwnComboBox);
            this.panel2.Controls.Add(this.ageComboBox);
            this.panel2.Controls.Add(this.ageSelectionBox);
            this.panel2.Controls.Add(this.AgeLabel);
            this.panel2.Controls.Add(this.CheckBoxFemale);
            this.panel2.Controls.Add(this.MaleCheckBox);
            this.panel2.Controls.Add(this.SexCheckBox);
            this.panel2.Controls.Add(this.PetTypeTitle);
            this.panel2.Controls.Add(this.CheckBoxContainer);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.FilterLabel);
            this.panel2.Location = new System.Drawing.Point(15, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 480);
            this.panel2.TabIndex = 0;
            // 
            // btwnComboBox
            // 
            this.btwnComboBox.FormattingEnabled = true;
            this.btwnComboBox.Items.AddRange(new object[] {
            "1 m",
            "2 m",
            "3 m",
            "4 m",
            "5 m",
            "6 m",
            "7 m",
            "8 m",
            "9 m",
            "10 m",
            "11 m",
            "1 yr ",
            "2 yr",
            "3 yr",
            "4 yr",
            "5 yr",
            "6 yr",
            "7 yr",
            "8 yr",
            "9 yr",
            "10 yr",
            "11 yr",
            "12 yr",
            "13 yr",
            "14 yr",
            "15 yr",
            "16 yr",
            "17 yr",
            "18 yr",
            "19 yr",
            "20 yr",
            "21 yr",
            "22 yr",
            "23 yr",
            "24 yr",
            "25 yr",
            "26 yr",
            "27 yr",
            "28 yr",
            "29 yr",
            "30 yr",
            "31 yr",
            "32 yr",
            "33 yr",
            "34 yr",
            "35 yr",
            "36 yr",
            "37 yr",
            "38 yr",
            "39 yr",
            "40 yr",
            "41 yr",
            "42 yr",
            "43 yr",
            "44 yr",
            "45 yr",
            "46 yr",
            "47 yr",
            "48 yr",
            "49 yr",
            "50 yr",
            "51 yr ",
            "52 yr",
            "53 yr",
            "54 yr",
            "55 yr",
            "56 yr",
            "57 yr",
            "58 yr",
            "59 yr",
            "60 yr",
            "61 yr",
            "62 yr",
            "63 yr",
            "64 yr",
            "65 yr",
            "66 yr",
            "67 yr",
            "68 yr",
            "69 yr",
            "70 yr",
            "71 yr",
            "72 yr",
            "73 yr",
            "74 yr",
            "75 yr",
            "76 yr",
            "77 yr",
            "78 yr",
            "79 yr",
            "80 yr",
            "81 yr",
            "82 yr",
            "83 yr",
            "84 yr",
            "85 yr",
            "86 yr",
            "87 yr",
            "88 yr",
            "89 yr",
            "90 yr",
            "91 yr",
            "92 yr",
            "93 yr",
            "94 yr",
            "95 yr",
            "96 yr",
            "97 yr",
            "98 yr",
            "99 yr",
            "100 yr"});
            this.btwnComboBox.Location = new System.Drawing.Point(170, 447);
            this.btwnComboBox.Name = "btwnComboBox";
            this.btwnComboBox.Size = new System.Drawing.Size(121, 24);
            this.btwnComboBox.TabIndex = 10;
            this.btwnComboBox.Visible = false;
            // 
            // ageComboBox
            // 
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "1 m",
            "2 m",
            "3 m",
            "4 m",
            "5 m",
            "6 m",
            "7 m",
            "8 m",
            "9 m",
            "10 m",
            "11 m",
            "1 yr ",
            "2 yr",
            "3 yr",
            "4 yr",
            "5 yr",
            "6 yr",
            "7 yr",
            "8 yr",
            "9 yr",
            "10 yr",
            "11 yr",
            "12 yr",
            "13 yr",
            "14 yr",
            "15 yr",
            "16 yr",
            "17 yr",
            "18 yr",
            "19 yr",
            "20 yr",
            "21 yr",
            "22 yr",
            "23 yr",
            "24 yr",
            "25 yr",
            "26 yr",
            "27 yr",
            "28 yr",
            "29 yr",
            "30 yr",
            "31 yr",
            "32 yr",
            "33 yr",
            "34 yr",
            "35 yr",
            "36 yr",
            "37 yr",
            "38 yr",
            "39 yr",
            "40 yr",
            "41 yr",
            "42 yr",
            "43 yr",
            "44 yr",
            "45 yr",
            "46 yr",
            "47 yr",
            "48 yr",
            "49 yr",
            "50 yr",
            "51 yr ",
            "52 yr",
            "53 yr",
            "54 yr",
            "55 yr",
            "56 yr",
            "57 yr",
            "58 yr",
            "59 yr",
            "60 yr",
            "61 yr",
            "62 yr",
            "63 yr",
            "64 yr",
            "65 yr",
            "66 yr",
            "67 yr",
            "68 yr",
            "69 yr",
            "70 yr",
            "71 yr",
            "72 yr",
            "73 yr",
            "74 yr",
            "75 yr",
            "76 yr",
            "77 yr",
            "78 yr",
            "79 yr",
            "80 yr",
            "81 yr",
            "82 yr",
            "83 yr",
            "84 yr",
            "85 yr",
            "86 yr",
            "87 yr",
            "88 yr",
            "89 yr",
            "90 yr",
            "91 yr",
            "92 yr",
            "93 yr",
            "94 yr",
            "95 yr",
            "96 yr",
            "97 yr",
            "98 yr",
            "99 yr",
            "100 yr"});
            this.ageComboBox.Location = new System.Drawing.Point(170, 404);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(121, 24);
            this.ageComboBox.TabIndex = 9;
            // 
            // ageSelectionBox
            // 
            this.ageSelectionBox.FormattingEnabled = true;
            this.ageSelectionBox.Items.AddRange(new object[] {
            "Equal to",
            "Less than",
            "Greater than",
            "Between"});
            this.ageSelectionBox.Location = new System.Drawing.Point(20, 404);
            this.ageSelectionBox.Name = "ageSelectionBox";
            this.ageSelectionBox.Size = new System.Drawing.Size(121, 24);
            this.ageSelectionBox.TabIndex = 8;
            this.ageSelectionBox.SelectedIndexChanged += new System.EventHandler(this.showBtwnBox);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(9, 358);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(38, 22);
            this.AgeLabel.TabIndex = 7;
            this.AgeLabel.Text = "Age";
            // 
            // CheckBoxFemale
            // 
            this.CheckBoxFemale.AutoSize = true;
            this.CheckBoxFemale.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxFemale.Location = new System.Drawing.Point(170, 335);
            this.CheckBoxFemale.Name = "CheckBoxFemale";
            this.CheckBoxFemale.Size = new System.Drawing.Size(64, 20);
            this.CheckBoxFemale.TabIndex = 6;
            this.CheckBoxFemale.Text = "Female";
            this.CheckBoxFemale.UseVisualStyleBackColor = true;
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleCheckBox.Location = new System.Drawing.Point(20, 335);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(52, 20);
            this.MaleCheckBox.TabIndex = 5;
            this.MaleCheckBox.Text = "Male";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // SexCheckBox
            // 
            this.SexCheckBox.AutoSize = true;
            this.SexCheckBox.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexCheckBox.Location = new System.Drawing.Point(9, 306);
            this.SexCheckBox.Name = "SexCheckBox";
            this.SexCheckBox.Size = new System.Drawing.Size(35, 22);
            this.SexCheckBox.TabIndex = 4;
            this.SexCheckBox.Text = "Sex";
            // 
            // PetTypeTitle
            // 
            this.PetTypeTitle.AutoSize = true;
            this.PetTypeTitle.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetTypeTitle.Location = new System.Drawing.Point(9, 63);
            this.PetTypeTitle.Name = "PetTypeTitle";
            this.PetTypeTitle.Size = new System.Drawing.Size(71, 22);
            this.PetTypeTitle.TabIndex = 3;
            this.PetTypeTitle.Text = "Pet Type";
            // 
            // CheckBoxContainer
            // 
            this.CheckBoxContainer.ColumnCount = 2;
            this.CheckBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CheckBoxContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CheckBoxContainer.Location = new System.Drawing.Point(13, 90);
            this.CheckBoxContainer.Name = "CheckBoxContainer";
            this.CheckBoxContainer.RowCount = 6;
            this.CheckBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CheckBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CheckBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CheckBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CheckBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CheckBoxContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CheckBoxContainer.Size = new System.Drawing.Size(303, 213);
            this.CheckBoxContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(83)))));
            this.panel3.Location = new System.Drawing.Point(8, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 1);
            this.panel3.TabIndex = 1;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.Location = new System.Drawing.Point(0, 14);
            this.FilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(93, 43);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter";
            // 
            // hamburgerMenu
            // 
            this.hamburgerMenu.Image = global::AdoptionDatabase.Properties.Resources._768px_Hamburger_icon_white_svg;
            this.hamburgerMenu.Location = new System.Drawing.Point(1274, 12);
            this.hamburgerMenu.Name = "hamburgerMenu";
            this.hamburgerMenu.Size = new System.Drawing.Size(99, 111);
            this.hamburgerMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamburgerMenu.TabIndex = 2;
            this.hamburgerMenu.TabStop = false;
            this.hamburgerMenu.Click += new System.EventHandler(this.hamburgerBtnClick);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.hamburgerLogBtn);
            this.panel4.Location = new System.Drawing.Point(1173, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 55);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // hamburgerLogBtn
            // 
            this.hamburgerLogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburgerLogBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerLogBtn.Location = new System.Drawing.Point(0, 0);
            this.hamburgerLogBtn.Name = "hamburgerLogBtn";
            this.hamburgerLogBtn.Size = new System.Drawing.Size(200, 47);
            this.hamburgerLogBtn.TabIndex = 0;
            this.hamburgerLogBtn.Text = "Worker Login";
            this.hamburgerLogBtn.UseVisualStyleBackColor = true;
            this.hamburgerLogBtn.Click += new System.EventHandler(this.adminlogBtnClick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1421, 846);
            this.Controls.Add(this.ButtonWhite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Michigan\'s Premier Adoption Event";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TitleBorder.ResumeLayout(false);
            this.DarkBlueTitle.ResumeLayout(false);
            this.DarkBlueTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ButtonWhite.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hamburgerMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel CardContainer;
        private System.Windows.Forms.TableLayoutPanel CheckBoxContainer;
        private System.Windows.Forms.Label PetTypeTitle;
        private System.Windows.Forms.Label SexCheckBox;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.CheckBox CheckBoxFemale;
        private System.Windows.Forms.ComboBox ageSelectionBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.ComboBox btwnComboBox;
        private System.Windows.Forms.PictureBox hamburgerMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button hamburgerLogBtn;
    }
}

