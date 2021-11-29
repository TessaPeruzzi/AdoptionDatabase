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

namespace AdoptionDatabase
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            noHorizontalScrollBar();
            fillTypeCheckBox();
            createPetCards();

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
            PetCard[] petCards = new PetCard[20];
            petFilter();

            CardContainer.RowStyles.Clear();

            string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM PET", con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(1);
                            string age = reader.GetString(2);
                            string type = reader.GetString(3);
                            string price = reader.GetString(4);
                            string sex = reader.GetString(5);
                            string picture = reader.GetString(6);
                            string agency = reader.GetString(7);
                            string shop = reader.GetString(8);
                            string vet = reader.GetString(9);

                            PetCard petTile = new PetCard();
                            petTile.NameLabel.Text = name;
                            petTile.InfoLabel.Text = "Age: " + age + "\nType: " + type + "\nAdoption Fee: $" + price + "\nSex: " + sex + "\nShop: " + shop;
                            petTile.AgencyLabel.Text = agency;
                            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("AdoptionDatabase.Properties.Resources", typeof(Resources).Assembly);
                            petTile.pictureBox1.Image = (Image)rm.GetObject(picture);
                            CardContainer.Controls.Add(petTile);
                        }
                    }
                }

            }
        }

        private void petBtnClick(object sender, EventArgs e)
        {
           

            
            PetCard[] petCards = new PetCard[20];
            petFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < petCards.Length; i++)
            {
                petCards[i] = new PetCard();
                CardContainer.Controls.Add(petCards[i]);
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
            VetCard[] vetCards = new VetCard[20];
            vetFilter();

            CardContainer.Controls.Clear();
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < vetCards.Length; i++)
            {
                vetCards[i] = new VetCard();
                CardContainer.Controls.Add(vetCards[i]);
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
            PetTypeCheckBox[] checkboxes = new PetTypeCheckBox[12];

            for (int i = 0; i < 12; i++)
            {
                checkboxes[i] = new PetTypeCheckBox();
                CheckBoxContainer.Controls.Add(checkboxes[i]);
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
            if (ageSelectionBox.Text == "Between")
            {
                btwnComboBox.Visible = true;
            } else
            {
                btwnComboBox.Visible = false;
            }
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

    }


}
