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
    public partial class PetCard : UserControl
    {
        public PetCard()
        {
            InitializeComponent();
        }

        private void appointmentBtnClick(object sender, EventArgs e)
        {
            Appointment_Form apptForm = new Appointment_Form(NameLabel.Text);
            apptForm.ShowDialog();

        }

    }


}
