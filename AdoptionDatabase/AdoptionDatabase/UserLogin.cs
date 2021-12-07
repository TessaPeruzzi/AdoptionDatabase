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

        //This array holds references to all the select checkboxes for easy access.
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


        //This method constructs the arguments required to call queryPetsForUser, calls it, and displays the information returned in the linked list
        //to the screen in a series of petcard display objects.
        //The SQL queries made for this display are of the form
        //"SELECT PET.PET_ID, PETSHOP.NAME, AGENCY.NAME, VET.NAME, PET.PET_NAME, PET.PET_TYPE, PET.PICTURE, PET.GENDER, PET.AGE, PET.ADOPTION_PRICE FROM (PET JOIN PETSHOP ON(PET.PETSHOP_ID = PETSHOP.PETSHOP_ID) JOIN VET ON VET.VET_ID = PET.VET_ID JOIN AGENCY ON AGENCY.AGENCY_ID = PET.AGENCY_ID)"
        private void createPetCards()
        {

            if (activeType == displayType.PETS)
            {
                petFilter();

            }

            

            CardContainer.RowStyles.Clear();
           

            
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


        //the xBtnClick methods serve to update the displayed objects and search controls to match the currently selected submenu.
        //They then perform a search by using the appropriate method from Infor to update and display the correct information from the database.
        //These methods are also sometimes called by the event handlers for the checkboxes, since some of the code required to update the gui with
        //the lastest pet information is inside them.
        private void petBtnClick(object sender, EventArgs e)
        {
            for(int i = 0; i < checkboxes.Length; i++)
            {
                checkboxes[i].checkBox1.Visible = true;
            }

            petFilter();

            

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
            DataTable agencyTable = Info.getAgencyTable(null);
            LocationCard[] agencyTile = new LocationCard[agencyTable.Rows.Count];
            noFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < agencyTile.Length; i++)
            {
                agencyTile[i] = new LocationCard();
                agencyTile[i].VetLabel.Text = agencyTable.Rows[i][1].ToString();
                agencyTile[i].addressLabel.Text = agencyTable.Rows[i][2].ToString();
                agencyTile[i].phoneLabel.Text = agencyTable.Rows[i][3].ToString();

                System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdoptionDatabase.Properties.Resources", typeof(Resources).Assembly);
                agencyTile[i].VetPicture.Image = (Image)rm.GetObject(agencyTable.Rows[i][4].ToString());

                CardContainer.Controls.Add(agencyTile[i]);
            }

        }
        private void vetBtnClick(object sender, EventArgs e)
        {
            vetFilter();


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
            LocationCard[] vetTile = new LocationCard[vetTable.Rows.Count];
            vetFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < vetTile.Length; i++)
            {
                vetTile[i] = new LocationCard();
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
            DataTable shopTable = Info.getShopTable(null);
            LocationCard[] shopTile = new LocationCard[shopTable.Rows.Count];
            noFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < shopTile.Length; i++)
            {
                shopTile[i] = new LocationCard();
                shopTile[i].VetLabel.Text = shopTable.Rows[i][1].ToString();
                shopTile[i].addressLabel.Text = shopTable.Rows[i][2].ToString();
                shopTile[i].phoneLabel.Text = shopTable.Rows[i][3].ToString();

                System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdoptionDatabase.Properties.Resources", typeof(Resources).Assembly);
                shopTile[i].VetPicture.Image = (Image)rm.GetObject(shopTable.Rows[i][4].ToString());

                CardContainer.Controls.Add(shopTile[i]);
            }
        }



        //This changes the text on all the checkboxes to match the correct descriptions on the Pet submenu.
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


        //This was autogenerated by visual studio and it does nothing, but I can't delete it.
        private void showBtwnBox(object sender, EventArgs e)
        {
          
        }


        //The filter methods set the appropriate checkboxes visible for each submenu
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

            checkboxes[0].checkBox1.Text = "Dogs";
            checkboxes[1].checkBox1.Text = "Cats";
            checkboxes[2].checkBox1.Text = "Exotics";

            checkboxes[0].checkBox1.Visible = true;
            checkboxes[1].checkBox1.Visible = true;
            checkboxes[2].checkBox1.Visible = true;

            for (int i = 3; i < checkboxes.Length; i++)
            {
                checkboxes[i].checkBox1.Visible = false;
            }
        }


        //This button makes the login button visible.
        private void hamburgerBtnClick(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }



        //Opens a LoginForm object to authenticate users
        private void adminlogBtnClick(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logIn = new LogInForm();
            logIn.ShowDialog();
            this.Close();
        }


        //calls the methods to update the cards for the Pet and Vet screens when the search parameters change.
        private void checkBoxChanged(object sender, EventArgs e)
        {
            if (activeType == displayType.PETS)
                createPetCards();
            else if (activeType == displayType.VETS)
                vetBtnClick(null, null);
        }


        //This was autogenerated by visual studio and it does nothing, but I can't delete it.
        private void ageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
