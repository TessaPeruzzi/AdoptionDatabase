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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }


        //This determines whether the password that is input is the admin or volunteer password.
        //Since we decided to have one volunteer and one admin password, it doesn't actually check the password against the database
        //it just compares it to the password stored in-code in string form. This is terribly insecure, but security is not a high priority for this application.
        private void logInBtn(object sender, EventArgs e)
        {
            if (passwordText.Text == "adminPass")
            {
                this.Hide();
                AdminPortal adminport = new AdminPortal(true);
               // adminport.deleteRadioBtn.AutoCheck = true;
               // adminport.updateRadioBtn.AutoCheck = true;
                adminport.ShowDialog();
                this.Close();
            }
            else if (passwordText.Text == "volPass")
            {
                this.Hide();
                AdminPortal adminport = new AdminPortal(false);
               // adminport.deleteRadioBtn.AutoCheck = false;
               // adminport.updateRadioBtn.AutoCheck = false;
                adminport.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password not valid", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
