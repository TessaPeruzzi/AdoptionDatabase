using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptionDatabase
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            
            string[][] petArray = new string[10][];
            petArray[0] = new string[] { "Name", "Agency", "paw.png", "Info \nblah\nblah" };
            petArray[1] = new string[] { "Name1", "Agency1", "paw.png", "Info1 \nblah\nblah" };


            PetCardContainer.Items.Add("hi");
            PetCardContainer.Items.Add("hiii");
            PetCardContainer.Items.Add("bye"); 
        }


       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
