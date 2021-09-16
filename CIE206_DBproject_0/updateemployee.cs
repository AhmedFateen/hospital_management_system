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

    public partial class updateemployee : Form
    {
        public updateemployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatecasebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllEmployees();
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
            else if (dflag == 0) { MessageBox.Show("employee ID don't exists"); }

            else
            {
                int ID = Convert.ToInt32(viewcasetextBox.Text);
                string atrr_type = attributeComboBox.Text;
                string attr_updated = valueTextBox.Text;
                //int ID = Convert.ToInt32(viewcasetextBox.Text);

                DataTable xx = Program.controllerObj.ViewEmployee(Convert.ToInt32(viewcasetextBox.Text));
                DataRow[] dt = xx.Select("EID= " + viewcasetextBox.Text);
                if (atrr_type == "First Name")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,attr_updated, row["last_name"].ToString(), row["Estatus"].ToString()=="1", row["Eusername"].ToString(), row["Epassword"].ToString(),  row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                    
                }
                else if (atrr_type == "Last Name")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), attr_updated, row["Estatus"].ToString() == "1", row["Eusername"].ToString(), row["Epassword"].ToString(),  row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "status")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID, row["first_name"].ToString(), row["last_name"].ToString(), attr_updated=="1", row["Eusername"].ToString(), row["Epassword"].ToString(), row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "username")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", attr_updated, row["Epassword"].ToString(), row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "password")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", row["Eusername"].ToString(), attr_updated, row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "birthdate")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", row["Eusername"].ToString(), row["Epassword"].ToString(), attr_updated, row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }

                else if (atrr_type == "contact number")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", row["Eusername"].ToString(), row["Epassword"].ToString(), row["birthdate"].ToString(), attr_updated, row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "address")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", row["Eusername"].ToString(), row["Epassword"].ToString(), row["birthdate"].ToString(), row["contact_num"].ToString(), attr_updated, Convert.ToChar(row["gender"].ToString()), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "gender")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", row["Eusername"].ToString(), row["Epassword"].ToString(), row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(attr_updated), row["Etype"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                }
                else if (atrr_type == "employee type")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateEmployee(ID,row["first_name"].ToString(), row["last_name"].ToString(), row["Estatus"].ToString() == "1", row["Eusername"].ToString(), row["Epassword"].ToString(), row["birthdate"].ToString(), row["contact_num"].ToString(), row["Paddress"].ToString(), Convert.ToChar(row["gender"].ToString()), attr_updated);
                    }
                    MessageBox.Show("updated successfully");
                }
                else { MessageBox.Show("invalid attribute"); }

            }
        }
        }
    }

