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
    public partial class addemployee : Form
    {
        public addemployee()
        {
            InitializeComponent();

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(employeetypecomboBox.Text) || String.IsNullOrEmpty(employeestatuscomboBox.Text) || String.IsNullOrEmpty(employeeidtextBox.Text) || String.IsNullOrEmpty(firstnametextBox.Text) || String.IsNullOrEmpty(secondnametextBox.Text) || String.IsNullOrEmpty(usernametextBox.Text) || String.IsNullOrEmpty(passwordtextBox.Text) || String.IsNullOrEmpty(gendercomboBox.Text) || String.IsNullOrEmpty(contactnumtextBox.Text) || String.IsNullOrEmpty(addresstextBox.Text))
            {
               
                    MessageBox.Show("Enter all required data");
                    return;

            }
            bool result1 = firstnametextBox.Text.All(Char.IsLetter);
            bool result2 = secondnametextBox.Text.All(Char.IsLetter);
            if (!result1 || !result2)
            {

                MessageBox.Show("Enter name correctly");
                return;

            }
            if (!contactnumtextBox.Text.All(Char.IsNumber))
            {
                MessageBox.Show("Enter Contact Number correctly");
                return;
            }
            if (!employeeidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should contain digits only");
                return;
            }
            else
            {
                int r = Program.controllerObj.AddEmployee(Convert.ToInt32(employeeidtextBox.Text), firstnametextBox.Text, secondnametextBox.Text, employeestatuscomboBox.Text=="1", usernametextBox.Text, passwordtextBox.Text,birthdate.Text ,contactnumtextBox.Text, addresstextBox.Text,Convert.ToChar(gendercomboBox.Text),employeetypecomboBox.Text);
                if (r > 0)
                {
                    if (employeetypecomboBox.Text=="doctor")
                    {
                        int dr = Program.controllerObj.AddDoctor(Convert.ToInt32(employeeidtextBox.Text), specializationTextBox.Text);
                    }
                    else if(employeetypecomboBox.Text=="nurse")
                    {
                        int nr = Program.controllerObj.AddNurse(Convert.ToInt32(employeeidtextBox.Text), specializationTextBox.Text);

                    }
                    else { }
                    MessageBox.Show("Employee added successfully");
                }
                else
                    MessageBox.Show("Operation Failed");
                return;

            }

        }

        private void secondnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernametextBox.TextLength > 15)
            {
                MessageBox.Show("Username too large");
                usernametextBox.Clear();
                return;
            }
        }

        private void gendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeidtextBox_TextChanged(object sender, EventArgs e)
        {
            if  (employeetypecomboBox.Text=="doctor" || employeetypecomboBox.Text=="nurse")
            {
                SpecializationLabel.Show();
                specializationTextBox.Show();
            }
        }
    }
}
