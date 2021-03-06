using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdoptionDatabase
{
    public partial class AdminPortal : Form
    {
        int activeID = 0;
        string petName = "";
        String petAge = "";
        String petPrice = "";
        String petType = "";
        String petSex = "";
        String petAgency = "";
        String petVet = "";
        String petShop = "";
        String petImage = "";
        String petVolunteer = "";


        //This array is used so that the methods in this class can reference all user input boxes easily by iterating over the appropriate
        //section of the array. Without it, each SQL query would have to be manually constructed using references to all of the textboxes.
        private TextBox[] notPetSource;

        public string[] infoDump;

        //Lets the form know whether it is in admin or not
        private bool isAdmin;

        public AdminPortal()
        {
            InitializeComponent();
        }


        //This alternate constructor is called by the login form, and serves to let the admin portal know whether it is in volunteer or admin mode.
        public AdminPortal(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;

            if (!isAdmin)
            {
                label1.Text = "Volunteer Portal";
                deleteRadioBtn.Enabled = false;
            }



        }


        //This method calls Info.getPetTable to update the display table with all current records in PET.
        private void displayPetData()
        {


            petDataContainer.DataSource = Info.getPetTable(null);

        }


        //This method clears out the display table so that a new type of record can be entered.
        //It is called by all of the xButtonClick methods
        private void fixColumns()
        {

            petDataContainer.DataSource = null;
            petDataContainer.ColumnCount = 0;

            for(int i = 0; i < 9; i++)
            {

                notPetSource[i].Text = "";

            }
          
        }

    

        //This method is where most of the action in the admin portal happens.
        //This button executes all inserts, deletes, and updates that the admin portal can make.
        //First, the active submenu is determined.
        //Then, the action type is determined (insert, delete, update)
        //The required strings for the Info class method are constructed from the information in the notPetSource array, or the active pet data if dealing with the pet class.
        //Then, the appropriate method in the Info class is called.
        private void submitBtnClick(object sender, EventArgs e)
        {

           


                if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "PET_ID") //Submit Button Actions for PET tab
                {
                    if (addRadioBtn.Checked == true && textBox1.Text != "" && textBox2.Text != "" && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox1.SelectedItem != null)
                    {
                        
                    string insertString = "INSERT INTO PET (PETSHOP_ID,AGENCY_ID,VET_ID,PET_NAME,PET_TYPE,PICTURE,GENDER,AGE,VOLUNTEER_ID,ADOPTION_PRICE) VALUES(" + comboBox5.SelectedItem + "," + comboBox4.SelectedItem + "," + comboBox6.SelectedItem + ",'" + textBox1.Text + "','" + comboBox3.SelectedItem + "','" + comboBox7.SelectedItem + "','" + comboBox2.SelectedItem + "'," + comboBox1.SelectedItem + "," + textBox9.Text + "," + textBox2.Text + ");";

                    Info.modifyDatabase(insertString);    

                    displayPetData();
                    }

                    if (deleteRadioBtn.Checked == true && activeID != 0)
                    {

                        string deleteString = "DELETE FROM PET WHERE (PET_ID = " + activeID + ");";

                        Info.modifyDatabase(deleteString);

                        displayPetData();
                    }

                    if (updateRadioBtn.Checked == true)
                    {
                     

                        string updateString = "UPDATE PET SET PET_NAME='" +textBox1.Text+ "',AGE="+ comboBox1.Text + ",PET_TYPE='"+ comboBox3.Text + "',ADOPTION_PRICE="+textBox2.Text+",GENDER='"+ comboBox2.Text + "',PICTURE='"+ comboBox7.Text + "',AGENCY_ID='"+ comboBox4.Text + "',PETSHOP_ID='"+ comboBox5.Text + "',VET_ID='" + comboBox6.Text + "' WHERE PET_ID = " + activeID;

                        Info.modifyDatabase(updateString);

                        displayPetData();
                    }
                    

                }



            

        if(petDataContainer.Columns[0].HeaderCell.Value.ToString() == "ADOPTER_ID")
        {
                if(addRadioBtn.Checked)
                {
                    for(int i = 0; i < 7; i++)
                    {
                        if (notPetSource[i].Text == "")
                            return;
                    }

                    string queryString = "INSERT INTO ADOPTER (FIRSTNAME, LASTNAME, PHONE, ADDRESS, CITY, STATE, ZIP) VALUES (";

                    for(int i = 0; i < 7; i++)
                    {
                        if (i != 0)
                            queryString += ", ";

                        queryString += "'" + notPetSource[i].Text + "'";
                    }

                    queryString += ");";

                    Debug.WriteLine(queryString);

                    Info.modifyDatabase(queryString);


                    petDataContainer.DataSource = Info.getAdopterTable(null);

                }

                else if (updateRadioBtn.Checked)
                {

                    string queryString = "UPDATE ADOPTER SET FIRSTNAME = '" + notPetSource[0].Text + "', LASTNAME = '" + notPetSource[1].Text + "', PHONE = '" + notPetSource[2].Text + "', ADDRESS = '" + notPetSource[3].Text + "', CITY = '" + notPetSource[4].Text + "', STATE = '" + notPetSource[5].Text + "', ZIP = '" + notPetSource[6].Text + "' WHERE ADOPTER_ID = " + activeID.ToString() + ";";

                    Info.modifyDatabase(queryString);

                    if (textBox8.Text == "")
                        Info.modifyDatabase("DELETE FROM ADOPTION WHERE ADOPTER_ID = " + activeID + ";");
                    else
                        Info.modifyDatabase("INSERT INTO ADOPTION VALUES (" + textBox8.Text + ", " + activeID + ", NULL);");

                    

                    petDataContainer.DataSource = Info.getAdopterTable(null);
                }

                else
                {

                    Info.modifyDatabase("DELETE FROM ADOPTER WHERE ADOPTER_ID = " + activeID.ToString() + ";");

                    petDataContainer.DataSource = Info.getAdopterTable(null);
                }




        }

        if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "APPOINTMENT_ID")
            {
                if (addRadioBtn.Checked)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        if (notPetSource[i].Text == "")
                            return;
                    }

                    string queryString = "INSERT INTO APPOINTMENT (ADOPTER_ID, PET_ID, VOLUNTEER_ID, TIMESLOT_ID) VALUES (" + Info.getIndex("ADOPTER", notPetSource[1].Text) + ", " + Info.getIndex("PET", notPetSource[2].Text) + ", " + Info.getIndex("VOLUNTEER", notPetSource[3].Text) + ", " + notPetSource[4].Text + ");";

                    

                    Debug.WriteLine(queryString);

                    Info.modifyDatabase(queryString);


                    petDataContainer.DataSource = Info.getAppointmentTable(null);

                }

                else if (updateRadioBtn.Checked)
                {

                    string queryString = "UPDATE APPOINTMENT SET ADOPTER_ID = " + Info.getIndex("ADOPTER", notPetSource[1].Text) + ", PET_ID = " + Info.getIndex("PET", notPetSource[2].Text) + ", VOLUNTEER_ID = " + Info.getIndex("VOLUNTEER", notPetSource[3].Text) + ", TIMESLOT_ID = " + notPetSource[4].Text + " WHERE APPOINTMENT_ID = " + activeID + ";";

                    Info.modifyDatabase(queryString);

                    petDataContainer.DataSource = Info.getAppointmentTable(null);
                }

                else if(deleteRadioBtn.Checked)
                {

                    Info.modifyDatabase("DELETE FROM APPOINTMENT WHERE APPOINTMENT_ID = " + activeID.ToString() + ";");

                    petDataContainer.DataSource = Info.getAppointmentTable(null);
                }
            }


        }

        //This method updates the display text boxes with all active pet data.
        private void updatePet(object sender, EventArgs e)
        {
  
                textBox1.Text = petName;
                comboBox1.Text = petAge;
                comboBox2.Text = petSex;
                comboBox3.Text = petType;
                textBox2.Text = petPrice;
                comboBox4.Text = petAgency;
                comboBox5.Text = petVet;
                comboBox6.Text = petShop;
                comboBox7.Text = petImage;
                textBox9.Text = petVolunteer;
        }


        //this method creates the array of textboxes used in assembling the SQL queries the admin portal makes.
        private void loadForm(object sender, EventArgs e)
        {
            notPetSource = new TextBox[9];

            notPetSource[0] = textBox1;
            notPetSource[1] = textBox3;
            notPetSource[2] = textBox4;
            notPetSource[3] = textBox5;
            notPetSource[4] = textBox2;
            notPetSource[5] = textBox6;
            notPetSource[6] = textBox7;
            notPetSource[7] = textBox8;
            notPetSource[8] = textBox9;

           

            displayPetData();
        }


        //Makes the logoiut button visible
        private void adminHamburgerBtnClick(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }


        //Switches back to the User portal
        private void logOutBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            this.Hide();
            MainPage userpage = new MainPage();
            userpage.ShowDialog();
            this.Close();
            
                        
        }



        //This updates all of the user input boxes with the relevant information when a row button in the display table is clicked.
        private void getRowInfo(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.WriteLine("Filling stuff");

            if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "PET_ID")
            {
                activeID = Convert.ToInt32(petDataContainer.Rows[e.RowIndex].Cells[0].Value.ToString());
                petName = petDataContainer.Rows[e.RowIndex].Cells[4].Value.ToString();
                petAge = petDataContainer.Rows[e.RowIndex].Cells[8].Value.ToString();
                petSex = petDataContainer.Rows[e.RowIndex].Cells[7].Value.ToString();
                petType = petDataContainer.Rows[e.RowIndex].Cells[5].Value.ToString();
                petPrice = petDataContainer.Rows[e.RowIndex].Cells[9].Value.ToString();
                petAgency = petDataContainer.Rows[e.RowIndex].Cells[2].Value.ToString();
                petVet = petDataContainer.Rows[e.RowIndex].Cells[3].Value.ToString();
                petShop = petDataContainer.Rows[e.RowIndex].Cells[1].Value.ToString();
                petImage = petDataContainer.Rows[e.RowIndex].Cells[6].Value.ToString();
                petVolunteer = petDataContainer.Rows[e.RowIndex].Cells[10].Value.ToString();

                textBox1.Text = petName;
                comboBox1.Text = petAge;
                comboBox2.Text = petSex;
                comboBox3.Text = petType;
                textBox2.Text = petPrice;
                comboBox4.Text = petAgency;
                comboBox5.Text = petVet;
                comboBox6.Text = petShop;
                comboBox7.Text = petImage;
                textBox9.Text = petVolunteer;

            }

            
            
            else
            {
                activeID = activeID = Convert.ToInt32(petDataContainer.Rows[e.RowIndex].Cells[0].Value.ToString());
                int start;

                if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "APPOINTMENT_ID")
                {
                    for (int i = 0; (i < petDataContainer.ColumnCount) && (i < petDataContainer.ColumnCount); i++)
                    {
                        notPetSource[i].Text = petDataContainer.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }
                else
                {
                    for (int i = 1; (i < petDataContainer.ColumnCount) && (i < notPetSource.Length); i++)
                    {
                        notPetSource[i-1].Text = petDataContainer.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }

                if(petDataContainer.Columns[0].HeaderCell.Value.ToString() == "ADOPTER_ID")
                {
                    textBox8.Text = petDataContainer.Rows[e.RowIndex].Cells[10].Value.ToString();
                }



            }


        }

        
        //The xBtnClick methods serve as handlers for the buttons that move between the submenus.
        //They change label texts and make user input boxes visible and invisible as appropriate to the new selected submenu.
        //They then call the appropriate getXTable method in info to display the entire table.
        private void agencyBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            fixColumns();
            petDataContainer.DataSource = Info.getAgencyTable(null);

            petDataContainer.Columns[0].HeaderCell.Value = "AGENCY_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "NAME";
            petDataContainer.Columns[2].HeaderCell.Value = "ADDRESS";
            petDataContainer.Columns[3].HeaderCell.Value = "PHONE_NUM";
            petDataContainer.Columns[4].HeaderCell.Value = "LOGO";
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = false;
            label11.Visible = false;
            textBox9.Visible = false;
            button1.Visible = false;

            
        }
        private void petBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;

            fixColumns();

            petDataContainer.DataSource = Info.getPetTable(null);

            petDataContainer.Columns[0].HeaderCell.Value = "PET_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "PETSHOP_ID";
            petDataContainer.Columns[2].HeaderCell.Value = "AGENCY_ID";
            petDataContainer.Columns[3].HeaderCell.Value = "VET_ID";
            petDataContainer.Columns[4].HeaderCell.Value = "PET_NAME";
            petDataContainer.Columns[5].HeaderCell.Value = "PET_TYPE";
            petDataContainer.Columns[6].HeaderCell.Value = "PICTURE";
            petDataContainer.Columns[7].HeaderCell.Value = "GENDER";
            petDataContainer.Columns[8].HeaderCell.Value = "AGE";
            petDataContainer.Columns[9].HeaderCell.Value = "ADOPTION_PRICE";
            petDataContainer.Columns[10].HeaderCell.Value = "ADOPTED?";
            addRadioBtn.Visible = true;
            updateRadioBtn.Visible = true;
            deleteRadioBtn.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Name:";
            label2.Visible = true;
            label3.Text = "Age:";
            label3.Visible = true;
            label4.Text = "Sex:";
            label4.Visible = true;
            label5.Text = "Type";
            comboBox1.Visible = true;
            textBox3.Visible = false;
            comboBox2.Visible = true;
            textBox4.Visible = false;
            comboBox3.Visible = true;
            textBox5.Visible = false;
            textBox2.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = true;
            label11.Visible = true;
            textBox9.Visible = true;
            button1.Visible = true;


        }
        private void vetBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            fixColumns();
            petDataContainer.DataSource = Info.getVetTable(null);
            petDataContainer.Columns[0].HeaderCell.Value = "VET_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "NAME";
            petDataContainer.Columns[2].HeaderCell.Value = "ADDRESS";
            petDataContainer.Columns[3].HeaderCell.Value = "PHONE";
            petDataContainer.Columns[4].HeaderCell.Value = "LOGO";
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            textBox3.Visible = false;
            comboBox2.Visible = false;
            textBox4.Visible = false;
            comboBox3.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = false;
            label11.Visible = false;
            textBox9.Visible = false;
            button1.Visible = false;
        }
        private void shopBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            fixColumns();

            petDataContainer.DataSource = Info.getShopTable(null);

            petDataContainer.Columns[0].HeaderCell.Value = "PETSHOP_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "NAME";
            petDataContainer.Columns[2].HeaderCell.Value = "ADDRESS";
            petDataContainer.Columns[3].HeaderCell.Value = "PHONE";
            petDataContainer.Columns[4].HeaderCell.Value = "LOGO";
            petDataContainer.DataSource = Info.getShopTable(null);
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            textBox3.Visible = false;
            comboBox2.Visible = false;
            textBox4.Visible = false;
            comboBox3.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = false;
            label11.Visible = false;
            textBox9.Visible = false;
            button1.Visible = false;
        }
        private void adopterBtnClick(object sender, EventArgs e)
        {
            fixColumns();
            petDataContainer.DataSource = Info.getAdopterTable(null);

            petDataContainer.Columns[0].HeaderCell.Value = "ADOPTER_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "FIRSTNAME";
            petDataContainer.Columns[2].HeaderCell.Value = "LASTNAME";
            petDataContainer.Columns[3].HeaderCell.Value = "PHONE";
            petDataContainer.Columns[4].HeaderCell.Value = "ADDRESS";
            petDataContainer.Columns[5].HeaderCell.Value = "CITY";
            petDataContainer.Columns[6].HeaderCell.Value = "STATE";
            petDataContainer.Columns[7].HeaderCell.Value = "ZIP";
            petDataContainer.Columns[8].HeaderCell.Value = "APPT_PET_ID";
            petDataContainer.Columns[9].HeaderCell.Value = "TIME";
            petDataContainer.Columns[10].HeaderCell.Value = "ADP_PET_ID";
            addRadioBtn.Visible = true;
            updateRadioBtn.Visible = true;
            deleteRadioBtn.Visible = true;
            textBox1.Visible = true;
            label2.Text = "F_Name:";
            label2.Visible = true;
            label3.Text = "L_Name:";
            label3.Visible = true;
            label4.Text = "Phone:";
            label4.Visible = true;
            label5.Text = "Address:";
            label5.Visible = true;
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            textBox4.Visible = true;
            comboBox3.Visible = false;
            textBox5.Visible = true;
            textBox2.Visible = true;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            label6.Visible = true;
            label6.Text = "City:";
            label7.Visible = true;
            label7.Text = "State:";
            label8.Visible = true;
            label8.Text = "Zip:";
            label9.Visible = true;
            label9.Text = "Adp_Pet ID:";
            label10.Visible = false;
            label10.Text = "Time:";
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            label5.Visible = true;
            label11.Visible = false;
            textBox9.Visible = false;
            button1.Visible = true;




        }
        private void volunteerBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            fixColumns();
            petDataContainer.DataSource = Info.getVolunteerTable(null);
            petDataContainer.Columns[0].HeaderCell.Value = "VOLUNTEER_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "FIRSTNAME";
            petDataContainer.Columns[2].HeaderCell.Value = "LASTNAME";
            petDataContainer.Columns[3].HeaderCell.Value = "IS_ADMIN";
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = false;
            textBox3.Visible = false;
            comboBox2.Visible = false;
            textBox4.Visible = false;
            comboBox3.Visible = false;
            textBox5.Visible = false;
            textBox2.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = false;
            label11.Visible = false;
            textBox9.Visible = false;
            button1.Visible = false;





        }
        private void apptBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;

            fixColumns();
            petDataContainer.DataSource = Info.getAppointmentTable(null);
            petDataContainer.Columns[0].HeaderCell.Value = "APPOINTMENT_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "ADOPTER NAME";
            petDataContainer.Columns[2].HeaderCell.Value = "PETNAME";
            petDataContainer.Columns[3].HeaderCell.Value = "VOLUNTEER NAME";
            petDataContainer.Columns[4].HeaderCell.Value = "TIMESLOT_ID";
            petDataContainer.Columns[5].HeaderCell.Value = "START_TIME";
            petDataContainer.Columns[6].HeaderCell.Value = "END_TIME";
            addRadioBtn.Visible = true;
            updateRadioBtn.Visible = true;
            deleteRadioBtn.Visible = true;
            textBox1.Visible = true;
            label2.Text = "Appt ID:";
            label2.Visible = true;
            label3.Text = "Adopter:";
            label3.Visible = true;
            label4.Text = "Petname:";
            label4.Visible = true;
            label5.Text = "Volunteer:";
            label5.Visible = true;
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            textBox4.Visible = true;
            comboBox3.Visible = false;
            textBox5.Visible = true;
            textBox2.Visible = true;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            label6.Visible = true;
            label6.Text = "Timeslot ID:";
            label7.Visible = true;
            label7.Text = "Start Time:";
            label8.Visible = true;
            label8.Text = "End Time:";
            label9.Visible = false;
            label10.Visible = false;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = true;
            label11.Visible = false;
            textBox9.Visible = false;
            button1.Visible = true;

        }

        


        //These six methods don't do anything but since visual studio autogenerated them it won't let me get rid of them.
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void petDataContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }






        //This method determines which submenu is active. It then calls the appropriate searchX method in the Info class and displays the data
        //on the display table.
        private void searchAdmin(object sender, EventArgs e)
        {
            if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "PET_ID")
            {
                petDataContainer.DataSource = Info.searchPet(null, searchBox);
            }
            else if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "AGENCY_ID")
            {
                petDataContainer.DataSource = Info.searchAgency(null, searchBox);
            }
            else if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "VET_ID")
            {
                petDataContainer.DataSource = Info.searchVet(null, searchBox);
            }
            else if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "PETSHOP_ID")
            {
                petDataContainer.DataSource = Info.searchShop(null, searchBox);
            }
            else if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "ADOPTER_ID")
            {
                petDataContainer.DataSource = Info.searchAdopter(null, searchBox);
            }
            else if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "VOLUNTEER_ID")
            {
                petDataContainer.DataSource = Info.searchVolunteer(null, searchBox);
            }
            else if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "APPOINTMENT_ID")
            {
                petDataContainer.DataSource = Info.searchAppointment(null, searchBox);
            }

        }
    }
}
