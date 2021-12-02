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
    public partial class Appointment_Form : Form
    {
        public Appointment_Form(string petname)
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            Label[] startTimes = new Label[20];
            Label[] endTimes = new Label[20];
            CheckBox[] appointmentCheckBoxes = new CheckBox[20];

            for (int i = 0; i <20; i++)
            {
                timeSlotList.Controls.Add(startTimes[0]);
                timeSlotList.Controls.Add(endTimes[0]);
                timeSlotList.Controls.Add(appointmentCheckBoxes[0]);
            }
        }

        private void closeAppointmentForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
