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
    public partial class updatepatient : Form
    {
        public updatepatient()
        {
            InitializeComponent();
        }

        private void updatecasebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllPatients();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(viewcasetextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }

            if (String.IsNullOrEmpty(viewcasetextBox.Text) || String.IsNullOrEmpty(attributeComboBox.Text) || String.IsNullOrEmpty(valueTextBox.Text))
            {
                MessageBox.Show("Enter all required data");
            }
            else if (!viewcasetextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("patient ID don't exists"); }

            else
            {
                int ID = Convert.ToInt32(viewcasetextBox.Text);
                string attr_type = attributeComboBox.Text;
                string attr_value=valueTextBox.Text;

                DataTable xx = Program.controllerObj.ViewPatient(Convert.ToInt32(viewcasetextBox.Text));
                DataRow[] dt = xx.Select("PID= " + viewcasetextBox.Text);
                if (attr_type== "First name")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, attr_value, row["last_name"].ToString(), Convert.ToChar(row["gender"].ToString()), row["birthdate"].ToString(), row["Pusername"].ToString(), row["Ppassword"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else if (attr_type== "Last name") 
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID,  row["first_name"].ToString(), attr_value, Convert.ToChar(row["gender"].ToString()), row["birthdate"].ToString(), row["Pusername"].ToString(), row["Ppassword"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else if (attr_type== "username")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, row["first_name"].ToString(),  row["last_name"].ToString(), Convert.ToChar(row["gender"].ToString()), row["birthdate"].ToString(), attr_value, row["Ppassword"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else if(attr_type== "password")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, row["first_name"].ToString(), row["last_name"].ToString(), Convert.ToChar(row["gender"].ToString()), row["birthdate"].ToString(), row["Pusername"].ToString(), attr_value, row["contact_num"].ToString(), row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else if(attr_type== "gender")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, row["first_name"].ToString(), row["last_name"].ToString(), Convert.ToChar(attr_value), row["birthdate"].ToString(), row["Pusername"].ToString(), row["Ppassword"].ToString(),  row["contact_num"].ToString(), row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else if (attr_type == "contact number")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, row["first_name"].ToString(), row["last_name"].ToString(), Convert.ToChar(row["gender"].ToString()), row["birthdate"].ToString(), row["Pusername"].ToString(), row["Ppassword"].ToString(), attr_value, row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (attr_type == "address")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, row["first_name"].ToString(), row["last_name"].ToString(), Convert.ToChar(row["gender"].ToString()), row["birthdate"].ToString(), row["Pusername"].ToString(), row["Ppassword"].ToString(), row["contact_num"].ToString(), attr_value);
                    }
                    MessageBox.Show("updated successfully");

                }
                else if (attr_type == "birthdate")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdatePatient(ID, row["first_name"].ToString(), row["last_name"].ToString(), Convert.ToChar(row["gender"].ToString()), attr_value, row["Pusername"].ToString(), row["Ppassword"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else { MessageBox.Show("invalid attribute"); }


            }
        }
    }
}
