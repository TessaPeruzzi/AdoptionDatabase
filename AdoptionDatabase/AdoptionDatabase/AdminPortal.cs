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

        public AdminPortal()
        {
            InitializeComponent();
        }

        private void displayPetData()
        {
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
                            string id = reader.GetString(0);
                            string name = reader.GetString(1);
                            string age = reader.GetString(2);
                            string type = reader.GetString(3);
                            string price = reader.GetString(4);
                            string sex = reader.GetString(5);
                            string picture = reader.GetString(6);
                            string agency = reader.GetString(7);
                            string shop = reader.GetString(8);
                            string vet = reader.GetString(9);
                            

                            petDataContainer.Rows.Add(id,name, age, sex, type, price, agency, shop, vet, picture);
                        }
                    }
                }

            }
        }

        private void submitPetBtnClick(object sender, EventArgs e)
        {
        if (petDataContainer.Columns[0].HeaderCell.Value.ToString() == "Pet ID") //Submit Button Actions for PET tab
            {
                if (addRadioBtn.Checked == true && textBox1.Text != "" && textBox2.Text != "" && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox1.SelectedItem != null)
                {
                    string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                    MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO PET VALUES(5,@name,@age,@type,@price,@sex,@picture,@agency,@shop,@vet)", con);
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@age", comboBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("@type", comboBox3.SelectedItem);
                    cmd.Parameters.AddWithValue("@sex", comboBox2.SelectedItem);
                    cmd.Parameters.AddWithValue("@picture", comboBox7.SelectedItem);
                    cmd.Parameters.AddWithValue("@price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@agency", comboBox4.SelectedItem);
                    cmd.Parameters.AddWithValue("@shop", comboBox5.SelectedItem);
                    cmd.Parameters.AddWithValue("@vet", comboBox6.SelectedItem);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    petDataContainer.Rows.Clear();
                    displayPetData();
                }

                if (deleteRadioBtn.Checked == true && petID != 0)
                {
                    string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                    MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM PET WHERE (PET_ID = @petKey)", con);
                    cmd.Parameters.AddWithValue("@petKey", petID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    petDataContainer.Rows.Clear();
                    displayPetData();
                }

                if (updateRadioBtn.Checked == true)
                {
                    string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                    MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE PET SET PET_NAME=@name,PET_AGE=@age,PET_TYPE=@type,ADOPTION_PRICE=@price,PET_SEX=@sex,PICTURE=@picture,AGENCY=@agency,SHOP=@shop,VET=@vet WHERE PET_ID = @id", con);
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
                    cmd.ExecuteNonQuery();
                    con.Close();
                    petDataContainer.Rows.Clear();
                    displayPetData();
                }
                if (searchRadioBtn.Checked == true)
                {
                    string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                    MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM PET WHERE CONCAT(`PET_NAME`,`PET_AGE`,`PET_TYPE`) LIKE '%" + textBox10.Text + "%'", con);
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
            petName = petDataContainer.Rows[e.RowIndex].Cells[1].Value.ToString();
            petAge = petDataContainer.Rows[e.RowIndex].Cells[2].Value.ToString();
            petSex = petDataContainer.Rows[e.RowIndex].Cells[3].Value.ToString();
            petType = petDataContainer.Rows[e.RowIndex].Cells[4].Value.ToString();
            petPrice = petDataContainer.Rows[e.RowIndex].Cells[5].Value.ToString();
            petAgency = petDataContainer.Rows[e.RowIndex].Cells[6].Value.ToString();
            petVet = petDataContainer.Rows[e.RowIndex].Cells[7].Value.ToString();
            petShop = petDataContainer.Rows[e.RowIndex].Cells[8].Value.ToString();
            petImage = petDataContainer.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void agencyBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Agency ID";
            petDataContainer.Columns[1].HeaderCell.Value = "Agency Name";
            petDataContainer.Columns[2].HeaderCell.Value = "Agency Location";
            petDataContainer.Columns[3].HeaderCell.Value = "Agency Phone";
            petDataContainer.Columns[4].HeaderCell.Value = "Agency Logo";
            petDataContainer.Columns[5].HeaderCell.Value = "";
            petDataContainer.Columns[6].HeaderCell.Value = "";
            petDataContainer.Columns[7].HeaderCell.Value = "";
            petDataContainer.Columns[8].HeaderCell.Value = "";
            petDataContainer.Columns[9].HeaderCell.Value = "";
            petDataContainer.Columns[10].HeaderCell.Value = "";
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
        }

        private void petBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Pet ID";
            petDataContainer.Columns[1].HeaderCell.Value = "Name";
            petDataContainer.Columns[2].HeaderCell.Value = "Age";
            petDataContainer.Columns[3].HeaderCell.Value = "Sex";
            petDataContainer.Columns[4].HeaderCell.Value = "Type";
            petDataContainer.Columns[5].HeaderCell.Value = "Fee";
            petDataContainer.Columns[6].HeaderCell.Value = "Agency";
            petDataContainer.Columns[7].HeaderCell.Value = "Vet";
            petDataContainer.Columns[8].HeaderCell.Value = "Shop";
            petDataContainer.Columns[9].HeaderCell.Value = "Image";
            petDataContainer.Columns[10].HeaderCell.Value = "Adopted?";
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
        }

        private void vetBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Vet ID";
            petDataContainer.Columns[1].HeaderCell.Value = "Vet Name";
            petDataContainer.Columns[2].HeaderCell.Value = "Vet Location";
            petDataContainer.Columns[3].HeaderCell.Value = "Vet Phone";
            petDataContainer.Columns[4].HeaderCell.Value = "Vet Logo";
            petDataContainer.Columns[5].HeaderCell.Value = "";
            petDataContainer.Columns[6].HeaderCell.Value = "";
            petDataContainer.Columns[7].HeaderCell.Value = "";
            petDataContainer.Columns[8].HeaderCell.Value = "";
            petDataContainer.Columns[9].HeaderCell.Value = "";
            petDataContainer.Columns[10].HeaderCell.Value = "";
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
        }

        private void shopBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Shop ID";
            petDataContainer.Columns[1].HeaderCell.Value = "Shop Name";
            petDataContainer.Columns[2].HeaderCell.Value = "Shop Location";
            petDataContainer.Columns[3].HeaderCell.Value = "Shop Phone";
            petDataContainer.Columns[4].HeaderCell.Value = "Shop Logo";
            petDataContainer.Columns[5].HeaderCell.Value = "";
            petDataContainer.Columns[6].HeaderCell.Value = "";
            petDataContainer.Columns[7].HeaderCell.Value = "";
            petDataContainer.Columns[8].HeaderCell.Value = "";
            petDataContainer.Columns[9].HeaderCell.Value = "";
            petDataContainer.Columns[10].HeaderCell.Value = "";
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
        }

        private void adopterBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Adopter ID";
            petDataContainer.Columns[1].HeaderCell.Value = "F_Name";
            petDataContainer.Columns[2].HeaderCell.Value = "L_Name";
            petDataContainer.Columns[3].HeaderCell.Value = "Phone";
            petDataContainer.Columns[4].HeaderCell.Value = "Address";
            petDataContainer.Columns[5].HeaderCell.Value = "City";
            petDataContainer.Columns[6].HeaderCell.Value = "State";
            petDataContainer.Columns[7].HeaderCell.Value = "Zip";
            petDataContainer.Columns[8].HeaderCell.Value = "Pet ID";
            petDataContainer.Columns[9].HeaderCell.Value = "Adoption Time";
            petDataContainer.Columns[10].HeaderCell.Value = "";
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

        }

        private void volunteerBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Volunteer ID";
            petDataContainer.Columns[1].HeaderCell.Value = "F_Name";
            petDataContainer.Columns[2].HeaderCell.Value = "L_Name";
            petDataContainer.Columns[3].HeaderCell.Value = "Is Admin?";
            petDataContainer.Columns[4].HeaderCell.Value = "";
            petDataContainer.Columns[5].HeaderCell.Value = "";
            petDataContainer.Columns[6].HeaderCell.Value = "";
            petDataContainer.Columns[7].HeaderCell.Value = "";
            petDataContainer.Columns[8].HeaderCell.Value = "";
            petDataContainer.Columns[9].HeaderCell.Value = "";
            petDataContainer.Columns[10].HeaderCell.Value = "";
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

        }

        private void apptBtnClick(object sender, EventArgs e)
        {
            petDataContainer.Columns[0].HeaderCell.Value = "Appointment ID";
            petDataContainer.Columns[1].HeaderCell.Value = "Start Time";
            petDataContainer.Columns[2].HeaderCell.Value = "End Time";
            petDataContainer.Columns[3].HeaderCell.Value = "Volunteer ID";
            petDataContainer.Columns[4].HeaderCell.Value = "Adopter ID";
            petDataContainer.Columns[5].HeaderCell.Value = "Pet ID";
            petDataContainer.Columns[6].HeaderCell.Value = "";
            petDataContainer.Columns[7].HeaderCell.Value = "";
            petDataContainer.Columns[8].HeaderCell.Value = "";
            petDataContainer.Columns[9].HeaderCell.Value = "";
            petDataContainer.Columns[10].HeaderCell.Value = "";
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
        }
    }
}
