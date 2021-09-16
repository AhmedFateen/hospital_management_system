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
    public partial class mainmenu : Form
    {
        public mainmenu(int q)
        {
            InitializeComponent();
            if (q == -1) 
            { 
                this.addpatientbutton.Hide();
                this.AddCase.Hide();
                this.addemployee.Hide();
                this.addroom.Hide();
                this.ViewPatientButton.Show();
                this.ViewCaseButton.Show();
                this.ViewEmployeeButton.Hide();
                this.ViewRoomButton.Show();
                this.update_patient_button.Hide();
                this.update_employee_button.Hide();
                this.update_case_button.Hide();
                this.update_room_button.Hide();
                this.deletepatientbutton.Hide();
                this.deleteemployeebutton.Hide();
                this.deletecasebutton.Hide();
                this.deleteroombutton.Hide();
               
            }
            else if (q == 0)
            {
                this.addpatientbutton.Show();
                this.AddCase.Hide();
                this.addemployee.Hide();
                this.addroom.Show();
                this.ViewPatientButton.Show();
                this.ViewCaseButton.Show();
                this.ViewEmployeeButton.Hide();
                this.ViewRoomButton.Show();
                this.update_patient_button.Show();
                this.update_employee_button.Hide();
                this.update_case_button.Hide();
                this.update_room_button.Show();
                this.deletepatientbutton.Show();
                this.deleteemployeebutton.Hide();
                this.deletecasebutton.Hide();
                this.deleteroombutton.Show();

            }
            else if (q == 1)
            {
                this.addpatientbutton.Hide();
                this.AddCase.Hide();
                this.addemployee.Hide();
                this.addroom.Hide();
                this.ViewPatientButton.Show();
                this.ViewCaseButton.Show();
                this.ViewEmployeeButton.Show();
                this.ViewRoomButton.Show();
                this.update_patient_button.Show();
                this.update_employee_button.Hide();
                this.update_case_button.Show();
                this.update_room_button.Show();
                this.deletepatientbutton.Hide();
                this.deleteemployeebutton.Hide();
                this.deletecasebutton.Hide();
                this.deleteroombutton.Hide();
            }
            else if (q == 2)
            {
                this.addpatientbutton.Show();
                this.AddCase.Show();
                this.addemployee.Hide();
                this.addroom.Show();
                this.ViewPatientButton.Show();
                this.ViewCaseButton.Show();
                this.ViewEmployeeButton.Show();
                this.ViewRoomButton.Show();
                this.update_patient_button.Show();
                this.update_employee_button.Hide();
                this.update_case_button.Show();
                this.update_room_button.Show();
                this.deletepatientbutton.Show();
                this.deleteemployeebutton.Hide();
                this.deletecasebutton.Show();
                this.deleteroombutton.Show();
            }
            else if (q == 3)
            {
                this.addpatientbutton.Show();
                this.AddCase.Show();
                this.addemployee.Show();
                this.addroom.Show();
                this.ViewPatientButton.Show();
                this.ViewCaseButton.Show();
                this.ViewEmployeeButton.Show();
                this.ViewRoomButton.Show();
                this.update_patient_button.Show();
                this.update_employee_button.Show();
                this.update_case_button.Show();
                this.update_room_button.Show();
                this.deletepatientbutton.Show();
                this.deleteemployeebutton.Show();
                this.deletecasebutton.Show();
                this.deleteroombutton.Show();
            }

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            new addpatient().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updatepatientbutton_Click(object sender, EventArgs e)
        {
            new updatepatient().Show();
        }

        private void viewpatientbutton_Click(object sender, EventArgs e)
        {
            new viewpatient().Show();
        }

        //private void deletepatientbutton_Click(object sender, EventArgs e)
        //{
        //    new deletepatient().Show();
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            new addemployee().Show();
        }

        private void AddCase_Click(object sender, EventArgs e)
        {
            new addcase().Show();
        }

        private void addroom_Click(object sender, EventArgs e)
        {
            new addroom().Show();
        }

    
        private void ViewPatientButton_Click_1(object sender, EventArgs e)
        {
            new viewpatient().Show();
        }

        private void ViewEmployeeButton_Click(object sender, EventArgs e)
        {
            new viewemployee().Show();
        }

        private void ViewCaseButton_Click(object sender, EventArgs e)
        {
            new viewcase().Show();
        }

        private void ViewRoomButton_Click(object sender, EventArgs e)
        {
            new viewroom().Show();
        }

        private void update_patient_button_Click(object sender, EventArgs e)
        {
            new updatepatient().Show();
        }

        private void update_employee_button_Click(object sender, EventArgs e)
        {
            new updateemployee().Show();
        }

        private void deletepatientbutton_Click_1(object sender, EventArgs e)
        {
            new deletepatient().Show();

        }

        private void deleteemployeebutton_Click(object sender, EventArgs e)
        {
            new deleteemployee().Show();
        }

        private void deletecasebutton_Click(object sender, EventArgs e)
        {
            new deletecase().Show();
        }

        private void update_case_button_Click(object sender, EventArgs e)
        {
            new updatecase().Show();
        }

        private void update_room_button_Click(object sender, EventArgs e)
        {
            new updateroom().Show();
        }

        private void deleteroombutton_Click(object sender, EventArgs e)
        {
            new deleteroom().Show();
        }

        private void ViewAllPatientsbutton_Click(object sender, EventArgs e)
        {
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
