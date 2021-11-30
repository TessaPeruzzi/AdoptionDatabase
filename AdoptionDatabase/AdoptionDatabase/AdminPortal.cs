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


            if (addRadioBtn.Checked == true && textBox1.Text != "" && textBox2.Text != "" && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && comboBox4.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                string cs = @"Server=localhost; Port=3306; Database=adoption_db; Uid=root; Pwd=Adoption1@;";
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO PET VALUES(4,@name,@age,@type,@price,@sex,@picture,@agency,@shop,@vet)", con);
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
                MessageBox.Show("Record Inserted Successfully");
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
                MessageBox.Show("Record Deleted Successfully");
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
                MessageBox.Show("Record Updated Successfully");
                petDataContainer.Rows.Clear();
                displayPetData();
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
    }
}
