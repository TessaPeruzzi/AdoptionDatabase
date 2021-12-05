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

        private TextBox[] notPetSource;

        public string[] infoDump;

        public bool isAdmin;

        public AdminPortal()
        {
            InitializeComponent();
        }

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



        private void displayPetData()
        {


            petDataContainer.DataSource = Info.getPetTable(null);

        }

        private void fixColumns()
        {

            petDataContainer.DataSource = null;
            petDataContainer.ColumnCount = 0;

            for(int i = 0; i < 9; i++)
            {

                notPetSource[i].Text = "";

            }
          
        }

    
        private void submitPetBtnClick(object sender, EventArgs e)
        {

            try
            {


                if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "PET_ID") //Submit Button Actions for PET tab
                {
                    if (addRadioBtn.Checked == true && textBox1.Text != "" && textBox2.Text != "" && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox1.SelectedItem != null)
                    {
                        string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                        MySqlConnection con = new MySqlConnection(cs);
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO PET (PETSHOP_ID,AGENCY_ID,VET_ID,PET_NAME,PET_TYPE,PICTURE,GENDER,AGE,VOLUNTEER_ID,ADOPTION_PRICE) VALUES(@shop,@agency,@vet,@name,@type,@picture,@sex,@age,@volunteer,@price)", con);
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@age", comboBox1.SelectedItem);
                        cmd.Parameters.AddWithValue("@type", comboBox3.SelectedItem);
                        cmd.Parameters.AddWithValue("@sex", comboBox2.SelectedItem);
                        cmd.Parameters.AddWithValue("@picture", comboBox7.SelectedItem);
                        cmd.Parameters.AddWithValue("@price", textBox2.Text);
                        cmd.Parameters.AddWithValue("@agency", comboBox4.SelectedItem);
                        cmd.Parameters.AddWithValue("@shop", comboBox5.SelectedItem);
                        cmd.Parameters.AddWithValue("@vet", comboBox6.SelectedItem);
                        cmd.Parameters.AddWithValue("@volunteer", textBox9.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        displayPetData();
                    }

                    if (deleteRadioBtn.Checked == true && activeID != 0)
                    {
                        string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                        MySqlConnection con = new MySqlConnection(cs);
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM PET WHERE (PET_ID = @petKey)", con);
                        cmd.Parameters.AddWithValue("@petKey", activeID);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        displayPetData();
                    }

                    if (updateRadioBtn.Checked == true)
                    {
                        string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                        MySqlConnection con = new MySqlConnection(cs);
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE PET SET PET_NAME=@name,AGE=@age,PET_TYPE=@type,ADOPTION_PRICE=@price,GENDER=@sex,PICTURE=@picture,AGENCY_ID=@agency,PETSHOP_ID=@shop,VET_ID=@vet WHERE PET_ID = @id", con);
                        cmd.Parameters.AddWithValue("@id", activeID);
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@age", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@type", comboBox3.Text);
                        cmd.Parameters.AddWithValue("@sex", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@picture", comboBox7.Text);
                        cmd.Parameters.AddWithValue("@price", textBox2.Text);
                        cmd.Parameters.AddWithValue("@agency", comboBox4.Text);
                        cmd.Parameters.AddWithValue("@shop", comboBox5.Text);
                        cmd.Parameters.AddWithValue("@vet", comboBox6.Text);
                        cmd.Parameters.AddWithValue("@volunteer", textBox9.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        displayPetData();
                    }



                }



            }
            catch(Exception error)
            {
                Debug.WriteLine("The task could not be completed");
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

                    Info.insertIntoDatabase(queryString);


                    petDataContainer.DataSource = Info.getAdopterTable(null);

                }

                else if (updateRadioBtn.Checked)
                {

                    string queryString = "UPDATE ADOPTER SET FIRSTNAME = '" + notPetSource[0].Text + "', LASTNAME = '" + notPetSource[1].Text + "', PHONE = '" + notPetSource[2].Text + "', ADDRESS = '" + notPetSource[3].Text + "', CITY = '" + notPetSource[4].Text + "', STATE = '" + notPetSource[5].Text + "', ZIP = '" + notPetSource[6].Text + "' WHERE ADOPTER_ID = " + activeID.ToString() + ";";

                    Info.insertIntoDatabase(queryString);

                    if (textBox8.Text == "")
                        Info.insertIntoDatabase("DELETE FROM ADOPTION WHERE ADOPTER_ID = " + activeID + ";");
                    else
                        Info.insertIntoDatabase("INSERT INTO ADOPTION VALUES (" + textBox8.Text + ", " + activeID + ", NULL);");

                    

                    petDataContainer.DataSource = Info.getAdopterTable(null);
                }

                else
                {

                    Info.insertIntoDatabase("DELETE FROM ADOPTER WHERE ADOPTER_ID = " + activeID.ToString() + ";");

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

                    string queryString = "INSERT INTO APPOINTMENT (ADOPTER_ID, PET_ID, VOLUNTEER_ID, TIMESLOT_ID) VALUES (";

                    for (int i = 1; i < 5; i++)
                    {
                        if (i != 1)
                            queryString += ", ";

                        queryString += notPetSource[i].Text;
                    }

                    queryString += ");";

                    Debug.WriteLine(queryString);

                    Info.insertIntoDatabase(queryString);


                    petDataContainer.DataSource = Info.getAppointmentTable(null);

                }

                else if (updateRadioBtn.Checked)
                {

                    string queryString = "UPDATE APPOINTMENT SET ADOPTER_ID = " + notPetSource[1].Text + ", PET_ID = " + notPetSource[2].Text + ", VOLUNTEER_ID = " + notPetSource[3].Text + ", TIMESLOT_ID = " + notPetSource[4].Text + " WHERE APPOINTMENT_ID = " + activeID + ";";

                    Info.insertIntoDatabase(queryString);

                    petDataContainer.DataSource = Info.getAppointmentTable(null);
                }

                else
                {

                    Info.insertIntoDatabase("DELETE FROM APPOINTMENT WHERE APPOINTMENT_ID = " + activeID.ToString() + ";");

                    petDataContainer.DataSource = Info.getAppointmentTable(null);
                }
            }


        }

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
        private void adminHamburgerBtnClick(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
        private void logOutBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            this.Hide();
            MainPage userpage = new MainPage();
            userpage.ShowDialog();
            this.Close();
            
                        
        }


        private void getPetRowInfo(object sender, DataGridViewCellMouseEventArgs e)
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

        

        private void agencyBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            fixColumns();
            petDataContainer.DataSource = Info.getAgencyTable(null);

            petDataContainer.Columns[0].HeaderCell.Value = "AGENCY_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "NAME";
            petDataContainer.Columns[2].HeaderCell.Value = "ADDRESS";
            petDataContainer.Columns[3].HeaderCell.Value = "PHONE_NUM";            
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            label3.Text = "Location:";
            label4.Text = "Phone:";
            label5.Text = "Logo:";
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            textBox4.Visible = true;
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
            label2.Text = "Name:";
            label3.Text = "Age:";
            label4.Text = "Sex:";
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
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            label2.Text = "Name:";
            label3.Text = "Location:";
            label4.Text = "Phone:";
            label5.Text = "Logo:";
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            textBox4.Visible = true;
            comboBox3.Visible = false;
            textBox5.Visible = true;
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
            label5.Visible = true;
            label11.Visible = false;
            textBox9.Visible = false;
            
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
            petDataContainer.DataSource = Info.getShopTable(null);
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
            label2.Text = "Name:";
            label3.Text = "Location:";
            label4.Text = "Phone:";
            label5.Text = "Logo:";
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            textBox4.Visible = true;
            comboBox3.Visible = false;
            textBox5.Visible = true;
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
            label5.Visible = true;
            label11.Visible = false;
            textBox9.Visible = false;
            
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
            label2.Text = "F_Name:";
            label3.Text = "L_Name:";
            label4.Text = "Phone:";
            label5.Text = "Address:";
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
            label2.Text = "F_Name:";
            label3.Text = "L_Name:";
            label4.Text = "Is_Admin:";
            label5.Text = "Logo:";
            comboBox1.Visible = false;
            textBox3.Visible = true;
            comboBox2.Visible = false;
            textBox4.Visible = true;
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

            

            

            
        }

        private void apptBtnClick(object sender, EventArgs e)
        {
            textBox8.Enabled = true;

            fixColumns();
            petDataContainer.DataSource = Info.getAppointmentTable(null);
            petDataContainer.Columns[0].HeaderCell.Value = "APPOINTMENT_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "ADOPTER_ID";
            petDataContainer.Columns[2].HeaderCell.Value = "PET_ID";
            petDataContainer.Columns[3].HeaderCell.Value = "VOLUNTEER_ID";
            petDataContainer.Columns[4].HeaderCell.Value = "TIMESLOT_ID";
            petDataContainer.Columns[5].HeaderCell.Value = "START_TIME";
            petDataContainer.Columns[6].HeaderCell.Value = "END_TIME";
            addRadioBtn.Visible = true;
            updateRadioBtn.Visible = true;
            deleteRadioBtn.Visible = true;
            label2.Text = "Appt ID:";
            label3.Text = "Adopter:";
            label4.Text = "Pet ID";
            label5.Text = "Vol ID:";
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
            label6.Text = "Timeslot ID";
            label7.Visible = true;
            label7.Text = "Start Time:";
            label8.Visible = true;
            label8.Text = "End Time";
            label9.Visible = false;
            label10.Visible = false;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = false;
            textBox9.Visible = false;
            label5.Visible = true;
            label11.Visible = false;
            textBox9.Visible = false;

            
        }

        

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
    }
}
