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
    public partial class addcase : Form
    {
        public addcase()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (treatmentCheckBox.Checked)
            {
                label12.Show();
                treatmentnametextBox.Show();
            }
            else
            {
                label12.Hide();
                treatmentnametextBox.Hide();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CheckinDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (labTestCheckBox.Checked)
            {
                label6.Show();
                label5.Show();
                label7.Show();
                labtestcomboBox.Show();
                labtestidtextBox.Show();
                labtestnametextBox.Show();
            }
            else
            {
                label6.Hide();
                label5.Hide();
                label7.Hide();
                labtestcomboBox.Hide();
                labtestidtextBox.Hide();
                labtestnametextBox.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (surgeryCheckBox.Checked)
            {
                label11.Show();
                label10.Show();
                label8.Show();
                surgeryidtextBox.Show();
                surgerynametextBox.Show();
                surgerystatuscomboBox.Show();
            }
            else
            {
                label11.Hide();
                label10.Hide();
                label8.Hide();
                surgeryidtextBox.Hide();
                surgerynametextBox.Hide();
                surgerystatuscomboBox.Hide();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (assignedCheckbox.Checked)
            {
                label14.Show();
                label13.Show();
                label15.Show();
                roomidtextBox.Show();
                CheckinDatePicker.Show();
                CheckoutDatePicker.Show();
            }
            else
            {
                label14.Hide();
                label13.Hide();
                label15.Hide();
                roomidtextBox.Hide();
                CheckinDatePicker.Hide();
                CheckoutDatePicker.Hide();
            }
        }

        private void addcasebutton_Click(object sender, EventArgs e)
        {
            int cr = 0;
            int sr = 0;
            int lr = 0;
            int tr = 0;
            int ar = 0;

            DataTable dd = Program.controllerObj.ViewAllEmployees();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(adddoctoridtextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }
            /////
            DataTable pp = Program.controllerObj.ViewAllPatients();
            int prowscount = pp.Rows.Count;
            int pflag = 0;

            for (int i = 0; i < prowscount; i++)
            {
                if (Convert.ToInt32(pp.Rows[i][0].ToString()) == Convert.ToInt32(addpatientidtextBox.Text)) { pflag = 1; break; }
                else { continue; }
            }
            ////////////////////
            if (String.IsNullOrEmpty(adddoctoridtextBox.Text) || String.IsNullOrEmpty(addpatientidtextBox.Text) || String.IsNullOrEmpty(addcaseidtextBox.Text) || String.IsNullOrEmpty(casestatuscomboBox.Text) || String.IsNullOrEmpty(diagnosistextBox.Text))
            {
                MessageBox.Show("Enter all required data");
                return;
            }
            else if (!adddoctoridtextBox.Text.All(Char.IsDigit) || !addpatientidtextBox.Text.All(Char.IsDigit) || !addcaseidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should contain digits only");
                return;
            }
            else if (pflag==0) { MessageBox.Show("patient ID don't exists");  }
            else if (dflag==0) { MessageBox.Show("doctor ID don't exists");  }
            else
            {
              cr = Program.controllerObj.AddCase(Convert.ToInt32(addcaseidtextBox.Text), diagnosistextBox.Text, casestatuscomboBox.Text == "completed", CaseDatePicker.Text);
            }
             if (treatmentCheckBox.Checked)
            {
                if (String.IsNullOrEmpty(treatmentnametextBox.Text))
                {
                    MessageBox.Show("Enter treatment name or uncheck the treatment box");

                }
                else
                {
                   tr =Program.controllerObj.AddTreatment(treatmentnametextBox.Text, Convert.ToInt32(addcaseidtextBox.Text));
                }
            }
            else if (labTestCheckBox.Checked)
            {
                if (String.IsNullOrEmpty(labtestcomboBox.Text) || String.IsNullOrEmpty(labtestidtextBox.Text) || String.IsNullOrEmpty(labtestnametextBox.Text))
                {
                    MessageBox.Show("Enter all lab test details or uncheck the box");

                }
                else
                {
                     lr = Program.controllerObj.AddLabTest(Convert.ToInt32(labtestidtextBox.Text),labtestnametextBox.Text, labtestcomboBox.Text=="completed",Convert.ToInt32(addcaseidtextBox.Text));
                }
            }
            else if (surgeryCheckBox.Checked)
            {
                if (String.IsNullOrEmpty(surgerystatuscomboBox.Text) || String.IsNullOrEmpty(surgeryidtextBox.Text) || String.IsNullOrEmpty(surgerynametextBox.Text))
                {
                    MessageBox.Show("Enter all surgery details or uncheck the box");

                }
                else
                {
                     sr = Program.controllerObj.AddSurgery(Convert.ToInt32(surgeryidtextBox.Text), surgerynametextBox.Text, surgerystatuscomboBox.Text == "completed", Convert.ToInt32(addcaseidtextBox.Text));
                }

            }
            else if (assignedCheckbox.Checked)
            {
                DataTable qq = Program.controllerObj.ViewAllRoom();
                int rowscount = qq.Rows.Count;
                int flag = 0;

                for (int i = 0; i < rowscount; i++)
                {
                    if (Convert.ToInt32(qq.Rows[i][0].ToString()) == Convert.ToInt32(roomidtextBox.Text)) { flag = 1; break; }
                    else { continue; }
                }

                //
                if (String.IsNullOrEmpty(roomidtextBox.Text) || String.IsNullOrEmpty(CheckinDatePicker.Text) || String.IsNullOrEmpty(CheckoutDatePicker.Text))
                {
                    MessageBox.Show("Enter all room assignment details or uncheck the box");

                }
                else if (flag == 0) { MessageBox.Show("room ID don't exists"); }
                else
                {
                     ar = Program.controllerObj.AddAssign(Convert.ToInt32(addcaseidtextBox.Text), Convert.ToInt32(roomidtextBox.Text), CheckinDatePicker.Text, CheckoutDatePicker.Text);

                    int ee = Program.controllerObj.num_patient_room(Convert.ToInt32(roomidtextBox.Text));
                    DataRow[] ww = qq.Select("RID= " + roomidtextBox.Text);
                    foreach (DataRow row in ww)
                    {
                        int aa = Program.controllerObj.UpdateRoom(Convert.ToInt32(roomidtextBox.Text), ee, Convert.ToInt32(row["capacity"]), row["r_type"].ToString());

                    }
                }
            }
            if (cr > 0 )
                MessageBox.Show("Case added successfully");
            else
                MessageBox.Show("Operation Failed");
            return;
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
