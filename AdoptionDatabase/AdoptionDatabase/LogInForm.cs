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
