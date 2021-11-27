using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptionDatabase
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
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
    }
}
