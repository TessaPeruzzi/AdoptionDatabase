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
        int petID = 0; 
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

        public string[] infoDump;

        public AdminPortal()
        {
            InitializeComponent();
        }

        private void displayPetData()
        {


            petDataContainer.DataSource = Info.getPetTable(null);
            
        }

        private void fixColumns()
        {
            
            petDataContainer.DataSource = null;
            petDataContainer.ColumnCount = 0;

        }
        private void submitPetBtnClick(object sender, EventArgs e)
        {
        if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "PET_ID") //Submit Button Actions for PET tab
            {
                if (addRadioBtn.Checked == true && textBox1.Text != "" && textBox2.Text != "" && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox1.SelectedItem != null)
                {
                    string cs = @"Server=localhost; Port=3306; Database=test; Uid=root; Pwd=Adoption1@;";
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

                if (deleteRadioBtn.Checked == true && petID != 0)
                {
                    string cs = @"Server=localhost; Port=3306; Database=test; Uid=root; Pwd=Adoption1@;";
                    MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM PET WHERE (PET_ID = @petKey)", con);
                    cmd.Parameters.AddWithValue("@petKey", petID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayPetData();
                }

                if (updateRadioBtn.Checked == true)
                {
                    string cs = @"Server=localhost; Port=3306; Database=test; Uid=root; Pwd=Adoption1@;";
                    MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE PET SET PET_NAME=@name,AGE=@age,PET_TYPE=@type,ADOPTION_PRICE=@price,GENDER=@sex,PICTURE=@picture,AGENCY_ID=@agency,PETSHOP_ID=@shop,VET_ID=@vet WHERE PET_ID = @id", con);
                    cmd.Parameters.AddWithValue("@id", petID);
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
                if (searchRadioBtn.Checked == true)
                {
                  string cs = @"Server=localhost; Port=3306; Database=test; Uid=root; Pwd=Adoption1@;";
                  MySqlConnection con = new MySqlConnection(cs);
                  con.Open();
                  MySqlCommand cmd = new MySqlCommand("SELECT * FROM PET WHERE CONCAT(`PET_NAME`,`AGE`,`PET_TYPE`) LIKE '%" + textBox10.Text + "%'", con);
                  MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                  DataTable searchTable = new DataTable();
                  adapter.Fill(searchTable);
                  petDataContainer.DataSource = searchTable;
                  con.Close();



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
            displayPetData();
        }
        private void adminHamburgerBtnClick(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }
        private void logOutBtnClick(object sender, EventArgs e)
        {
            this.Hide();
            MainPage userpage = new MainPage();
            userpage.ShowDialog();
            this.Close();
            
                        
        }


        private void getPetRowInfo(object sender, DataGridViewCellMouseEventArgs e)
        {
            petID = Convert.ToInt32(petDataContainer.Rows[e.RowIndex].Cells[0].Value.ToString());
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

        }

        private void agencyBtnClick(object sender, EventArgs e)
        {
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

        private void petBtnClick(object sender, EventArgs e)
        {
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
            petDataContainer.Columns[8].HeaderCell.Value = "PET_ID";
            petDataContainer.Columns[9].HeaderCell.Value = "TIME";
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = false;
            deleteRadioBtn.Visible = false;
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
            label9.Text = "Pet ID:";
            label10.Visible = true;
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
            fixColumns();
            petDataContainer.DataSource = Info.getAppointmentTable(null);
            petDataContainer.Columns[0].HeaderCell.Value = "APPOINTMENT_ID";
            petDataContainer.Columns[1].HeaderCell.Value = "ADOPTER_ID";
            petDataContainer.Columns[2].HeaderCell.Value = "PET_ID";
            petDataContainer.Columns[3].HeaderCell.Value = "VOLUNTEER_ID";
            petDataContainer.Columns[4].HeaderCell.Value = "START_TIME";
            petDataContainer.Columns[5].HeaderCell.Value = "END_TIME";
            addRadioBtn.Visible = false;
            updateRadioBtn.Visible = true;
            deleteRadioBtn.Visible = false;
            label2.Text = "Appt ID:";
            label3.Text = "Start:";
            label4.Text = "End:";
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
            label6.Text = "Adopter ID:";
            label7.Visible = true;
            label7.Text = "Pet ID:";
            label8.Visible = true;
            label8.Text = "Pet ID:";
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

       

    }
}
