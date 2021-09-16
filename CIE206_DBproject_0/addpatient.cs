using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIE206_DBproject_0
{
    public partial class addpatient : Form
    {

        public addpatient()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(patientidtextBox.Text) || String.IsNullOrEmpty(firstnametextBox.Text) || String.IsNullOrEmpty(secondnametextBox.Text)|| String.IsNullOrEmpty(usernametextBox.Text) || String.IsNullOrEmpty(passwordtextBox.Text) || String.IsNullOrEmpty(gendercomboBox.Text) || String.IsNullOrEmpty(contactnumtextBox.Text) || String.IsNullOrEmpty(addresstextBox.Text) || String.IsNullOrEmpty(birthdatePicker.Text))
            {

                MessageBox.Show("Enter all required data");
                return;

            }
            else if (!contactnumtextBox.Text.All(Char.IsNumber))
            {
                MessageBox.Show("Enter Contact Number correctly");
                return;
            }
            else if (contactnumtextBox.Text.Length!=11)
            {
                MessageBox.Show("Enter 11-digit contact number");
                return;

            }
            else if (!patientidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should contain digits only");
                return;
            }
            else if (!firstnametextBox.Text.All(Char.IsLetter) || !secondnametextBox.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Enter name correctly");
                return;
            }

            else
            {
                int r= Program.controllerObj.AddPatient(Convert.ToInt32(patientidtextBox.Text), firstnametextBox.Text, secondnametextBox.Text, Convert.ToChar(gendercomboBox.Text), birthdatePicker.Text, usernametextBox.Text, passwordtextBox.Text, contactnumtextBox.Text, addresstextBox.Text);
                if (r > 0)
                    MessageBox.Show("Patient added successfully");
                else
                    MessageBox.Show("Operation Failed");
                return;
            }

        }

        private void addpatient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernametextBox.TextLength>15)
            {
                MessageBox.Show("Username too large");
                usernametextBox.Clear();
                return;
            }
        }
    }
}
