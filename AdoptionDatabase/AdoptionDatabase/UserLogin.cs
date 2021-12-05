using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoptionDatabase.Properties;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AdoptionDatabase
{
    public partial class MainPage : Form
    {
        PetTypeCheckBox[] checkboxes;

        private enum displayType {PETS, VETS, AGENCIES, PETSHOPS}

        private displayType activeType;

        public MainPage()
        {
            InitializeComponent();

            activeType = displayType.PETS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            noHorizontalScrollBar();
            fillTypeCheckBox();
            createPetCards();

            MaleCheckBox.CheckedChanged += checkBoxChanged;
            ageComboBox.Text = "1";
            ageComboBox.SelectionChangeCommitted += checkBoxChanged;
            ageSelectionBox.SelectionChangeCommitted += checkBoxChanged;
            MaleCheckBox.CheckedChanged += checkBoxChanged;
            CheckBoxFemale.CheckedChanged += checkBoxChanged;

        }

        private void noHorizontalScrollBar()
        {
            CardContainer.HorizontalScroll.Maximum = 0;
            CardContainer.AutoScroll = false;
            CardContainer.VerticalScroll.Visible = false;
            CardContainer.AutoScroll = true;
        }

        private void createPetCards()
        {

            if (activeType == displayType.PETS)
            {
                petFilter();

            }

            

            CardContainer.RowStyles.Clear();
           

            //Mark
            while(CardContainer.Controls.Count > 0)
            {
                CardContainer.Controls[0].Dispose();
            }


            if (activeType == displayType.PETS)
            {

                string[] typeOut = new string[12];
                int activeTypeIndex = 0;



                for (int i = 0; i < 12; i++)
                {
                    if (checkboxes[i].checkBox1.Checked)
                    {
                        typeOut[activeTypeIndex] = checkboxes[i].checkBox1.Text;
                    }
                    activeTypeIndex++;
                }

                string petGender;

                if ((MaleCheckBox.Checked && CheckBoxFemale.Checked) || (!MaleCheckBox.Checked && !CheckBoxFemale.Checked))
                {
                    petGender = null;
                }
                else if (MaleCheckBox.Checked)
                {
                    petGender = "M";
                }
                else
                {
                    petGender = "F";
                }

                string ageOperator = "";

                if (ageSelectionBox.Text != "")
                {
                    switch (ageSelectionBox.Text)
                    {
                        case "Equal to":
                            ageOperator = "=";
                            break;
                        case "Greater than":
                            ageOperator = ">";
                            break;
                        default:
                            ageOperator = "<";
                            break;
                    }
                }

                ReturnedDataHolder reader = Info.queryPetsForUser(typeOut, petGender, ageOperator, ageComboBox.Text);




                while (reader.next())
                {
                    string id = reader.GetString(0);
                    string petshop = reader.GetString(1);
                    string agency = reader.GetString(2);
                    string vet = reader.GetString(3);
                    string name = reader.GetString(4);
                    string type = reader.GetString(5);
                    string picture = reader.GetString(6);
                    string gender = reader.GetString(7);
                    string age = reader.GetString(8);
                    string price = reader.GetString(9);




                    PetCard petTile = new PetCard();
                    petTile.NameLabel.Text = name;
                    petTile.InfoLabel.Text = "Age: " + age + "\nType: " + type + "\nAdoption Fee: $" + price + "\nSex: " + gender + "\nShop: " + petshop + "\nVet: " + vet;
                    petTile.AgencyLabel.Text = agency;
                    System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdoptionDatabase.Properties.Resources", typeof(Resources).Assembly);
                    petTile.pictureBox1.Image = (Image)rm.GetObject(picture);
                    CardContainer.Controls.Add(petTile);
                }

            }
            
    
        }

        private void petBtnClick(object sender, EventArgs e)
        {
            petFilter();

            for (int i = 0; i < checkboxes.Length; i++)
            {
                checkboxes[i].checkBox1.Visible = false;
            }

            CardContainer.RowStyles.Clear();



            //Mark
            while (CardContainer.Controls.Count > 0)
            {
                CardContainer.Controls[0].Dispose();
            }



            string[] typeOut = new string[12];
            int activeTypeIndex = 0;



            for (int i = 0; i < 12; i++)
            {
                if (checkboxes[i].checkBox1.Checked)
                {
                    typeOut[activeTypeIndex] = checkboxes[i].checkBox1.Text;
                }
                activeTypeIndex++;
            }

            string petGender;

            if ((MaleCheckBox.Checked && CheckBoxFemale.Checked) || (!MaleCheckBox.Checked && !CheckBoxFemale.Checked))
            {
                petGender = null;
            }
            else if (MaleCheckBox.Checked)
            {
                petGender = "M";
            }
            else
            {
                petGender = "F";
            }

            string ageOperator = "";

            if (ageSelectionBox.Text != "")
            {
                switch (ageSelectionBox.Text)
                {
                    case "Equal to":
                        ageOperator = "=";
                        break;
                    case "Greater than":
                        ageOperator = ">";
                        break;
                    default:
                        ageOperator = "<";
                        break;
                }
            }

            ReturnedDataHolder reader = Info.queryPetsForUser(typeOut, petGender, ageOperator, ageComboBox.Text);




            while (reader.next())
            {
                string id = reader.GetString(0);
                string petshop = reader.GetString(1);
                string agency = reader.GetString(2);
                string vet = reader.GetString(3);
                string name = reader.GetString(4);
                string type = reader.GetString(5);
                string picture = reader.GetString(6);
                string gender = reader.GetString(7);
                string age = reader.GetString(8);
                string price = reader.GetString(9);




                PetCard petTile = new PetCard();
                petTile.NameLabel.Text = name;
                petTile.InfoLabel.Text = "Age: " + age + "\nType: " + type + "\nAdoption Fee: $" + price + "\nSex: " + gender + "\nShop: " + petshop + "\nVet: " + vet;
                petTile.AgencyLabel.Text = agency;
                System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdoptionDatabase.Properties.Resources", typeof(Resources).Assembly);
                petTile.pictureBox1.Image = (Image)rm.GetObject(picture);
                CardContainer.Controls.Add(petTile);
            }
        }

        private void agencyBtnClick(object sender, EventArgs e)
        {
            AgencyCard[] agencyCards = new AgencyCard[20];
            agencyFilter();
            
            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < agencyCards.Length; i++)
            {
                agencyCards[i] = new AgencyCard();
                CardContainer.Controls.Add(agencyCards[i]);
            }
        }

        private void vetBtnClick(object sender, EventArgs e)
        {
            checkboxes[0].checkBox1.Text = "Dogs";
            checkboxes[1].checkBox1.Text = "Cats";
            checkboxes[2].checkBox1.Text = "Exotics";

            for(int i = 3; i < checkboxes.Length; i++)
            {
                checkboxes[i].checkBox1.Visible = false;
            }


            activeType = displayType.VETS;

            string[] whereString = new string[checkboxes.Length];

            for(int i = 0; i < 3; i++)
            {
                whereString[i] = null;

                if(checkboxes[i].checkBox1.Checked)
                {
                    whereString[i] = checkboxes[i].checkBox1.Text;

                }

            }

            if (!Info.hasContents(whereString))
                whereString = null;

            DataTable vetTable = Info.getVetTable(whereString);
            VetCard[] vetTile = new VetCard[vetTable.Rows.Count];
            vetFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < vetTile.Length; i++)
            {
                vetTile[i] = new VetCard();
                vetTile[i].VetLabel.Text = vetTable.Rows[i][1].ToString();
                vetTile[i].addressLabel.Text = vetTable.Rows[i][2].ToString();
                vetTile[i].phoneLabel.Text = vetTable.Rows[i][3].ToString();
                
                System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdoptionDatabase.Properties.Resources", typeof(Resources).Assembly);
                vetTile[i].VetPicture.Image = (Image)rm.GetObject(vetTable.Rows[i][4].ToString());

                CardContainer.Controls.Add(vetTile[i]);
            }
            
        }

        private void shopBtnClick(object sender, EventArgs e)
        {
            ShopCard[] shopCards = new ShopCard[20];
            noFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < shopCards.Length; i++)
            {
                shopCards[i] = new ShopCard();
                CardContainer.Controls.Add(shopCards[i]);
            }
        }

        private void fillTypeCheckBox()
        {
            checkboxes = new PetTypeCheckBox[12];

            for (int i = 0; i < 12; i++)
            {
                checkboxes[i] = new PetTypeCheckBox();
                CheckBoxContainer.Controls.Add(checkboxes[i]);
                checkboxes[i].checkBox1.CheckedChanged += checkBoxChanged;
            }

            checkboxes[0].checkBox1.Text = "Dogs";
            checkboxes[1].checkBox1.Text = "Cats";
            checkboxes[2].checkBox1.Text = "Guinea Pigs";
            checkboxes[3].checkBox1.Text = "Rabbits";
            checkboxes[4].checkBox1.Text = "Hamsters";
            checkboxes[5].checkBox1.Text = "Mice";
            checkboxes[6].checkBox1.Text = "Rats";
            checkboxes[7].checkBox1.Text = "Fish";
            checkboxes[8].checkBox1.Text = "Birds";
            checkboxes[9].checkBox1.Text = "Lizards";
            checkboxes[10].checkBox1.Text = "Frogs";
            checkboxes[11].checkBox1.Text = "Others";

        }

        private void showBtwnBox(object sender, EventArgs e)
        {
          
        }

        private void noFilter()
        {
            PetTypeTitle.Text = "No Filters Available";
            CheckBoxContainer.Visible = false;
            SexCheckBox.Visible = false;
            MaleCheckBox.Visible = false;
            CheckBoxFemale.Visible = false;
            AgeLabel.Visible = false;
            ageSelectionBox.Visible = false;
            ageComboBox.Visible = false;
        }

        private void petFilter()
        {
            PetTypeTitle.Text = "Pet Type";
            CheckBoxContainer.Visible = true;
            SexCheckBox.Visible = true;
            MaleCheckBox.Visible = true;
            CheckBoxFemale.Visible = true;
            AgeLabel.Visible = true;
            ageSelectionBox.Visible = true;
            ageComboBox.Visible = true;
        }

        private void agencyFilter()
        {
            PetTypeTitle.Text = "Pet Type";
            CheckBoxContainer.Visible = true;
            SexCheckBox.Visible = false;
            MaleCheckBox.Visible = false;
            CheckBoxFemale.Visible = false;
            AgeLabel.Visible = false;
            ageSelectionBox.Visible = false;
            ageComboBox.Visible = false;
        }

        private void vetFilter()
        {
            PetTypeTitle.Text = "Pet Specialty";
            CheckBoxContainer.Visible = true;
            SexCheckBox.Visible = false;
            MaleCheckBox.Visible = false;
            CheckBoxFemale.Visible = false;
            AgeLabel.Visible = false;
            ageSelectionBox.Visible = false;
            ageComboBox.Visible = false;
        }

        private void hamburgerBtnClick(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void adminlogBtnClick(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logIn = new LogInForm();
            logIn.ShowDialog();
            this.Close();
        }
        private void checkBoxChanged(object sender, EventArgs e)
        {
            if (activeType == displayType.PETS)
                createPetCards();
            else if (activeType == displayType.VETS)
                vetBtnClick(null, null);
        }

        private void ageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
