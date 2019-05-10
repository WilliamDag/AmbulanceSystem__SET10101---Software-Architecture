using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KwikMedical_Ambulance_Interface.KwikMedicalServiceReference;

namespace KwikMedical_Ambulance_Interface
{
    public partial class AmbulanceInterface : Form
    {
        bool loggedIn = false;
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public AmbulanceInterface()
        {
            InitializeComponent();
            dictionary.Add("EH", "Western General Hospital");
            dictionary.Add("GA", "Stobhill Hospital");
            dictionary.Add("AB", "Aberdeen Royal Infirmary");
            dictionary.Add("FK", "Forth Valley Royal Hospital");
            dictionary.Add("DG", "Dumfries and Galloway Royal Infirmary");
            /*if(!loggedIn)
            {
                Form loginWindow = new Login();
                loginWindow.Show();
            }*/
            radio_male.Checked = true;
        }

        //Save the patient details to the Patient table
        private void btn_enter_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            if(tb_firstName.Text != "" && tb_lastName.Text != "" && tb_houseNo.Text != "" && tb_streetName.Text != ""
                && tb_city.Text != "" && tb_postcode.Text != "")
            {
                try
                {
                    patient.patientNo = Int32.Parse(tb_patientNo.Text);
                }
                catch
                {
                    MessageBox.Show("NHS Registration Number must be numerical", "Missing Details");
                }
                patient.firstName = tb_firstName.Text;
                patient.lastName = tb_lastName.Text;
                if (radio_male.Checked == true)
                {
                    patient.gender = "Male";
                }
                if (radio_female.Checked == true)
                {
                    patient.gender = "Female";
                }
                patient.dateOfBirth = date_dateOfBirth.Value;
                patient.houseNo = tb_houseNo.Text;
                patient.streetName = tb_streetName.Text;
                patient.city = tb_city.Text;
                patient.postcode = tb_postcode.Text;
                try
                {
                    patient.hospital = dictionary[patient.postcode.Substring(0, 2)];
                }
                catch
                {
                    patient.hospital = "To Be Allocated";
                }

                Service1Client service = new Service1Client();

                if (service.InsertPatient(patient) == 1)
                {
                    MessageBox.Show("Patient details successfully added");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Missing Details");
            }
        }
        
        //Logs the data from the "Call Details" text boxes to the Call table
        private void btn_logCall_Click(object sender, EventArgs e)
        {
            Call call = new Call();
            call.patientNo = Int32.Parse(tb_patientNo.Text);
            call.callDetails = tb_callDetails.Text;
            call.callLength = Int32.Parse(tb_callTime.Text);

            Service1Client service = new Service1Client();

            if (service.AddCall(call) == 1)
            {
                MessageBox.Show("Call details successfully logged");
            }
        }

        private void tb_callDetails_Click(object sender, EventArgs e)
        {
            tb_callDetails.Clear();
        }

        //Toolbar buttons
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form searchDialog = new Search();
            searchDialog.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutDialog = new About();
            aboutDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Clear all textboxes
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_firstName.Clear();
            tb_lastName.Clear();
            tb_patientNo.Clear();
            tb_houseNo.Clear();
            tb_streetName.Clear();
            tb_city.Clear();
            tb_postcode.Clear();
            tb_telephone.Clear();
            tb_callDetails.Clear();
            tb_callTime.Clear();
        }
    }
}
