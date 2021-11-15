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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            noHorizontalScrollBar();
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
            
            CardContainer.RowStyles.Clear();

            for (int i = 0; i < petCards.Length; i++) { 
                petCards[i] = new PetCard();
                CardContainer.Controls.Add(petCards[i]);
            }
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
