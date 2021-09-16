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
    public partial class updatecase : Form
    {

        public updatecase()
        {
            InitializeComponent();        }

        private void updatecasebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllCases();
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
            else if (dflag == 0) { MessageBox.Show("case ID don't exists"); }

            else
            {
                //case ID
                //doctor ID
                //patient ID
                //case status
                //diagnosis
                //treatment name
                //lab status
                //lab ID
                //lab name
                //surgery status
                //surgery ID
                //surgery name
                //room ID
                //checkin date
                //checkout date
                int ID = Convert.ToInt32(viewcasetextBox.Text);
                string attr_type = attributeComboBox.Text;
                string attr_value = valueTextBox.Text;
                DataTable xx = Program.controllerObj.ViewCase(Convert.ToInt32(viewcasetextBox.Text));
                DataRow[] dt = xx.Select("case_num= " + viewcasetextBox.Text);
                if (attr_type == "case status")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateCase(ID,row["diagnosis"].ToString(),attr_value=="1", row["casedate"].ToString());
                    }
                    MessageBox.Show("updated successfully");
                    
                }
                else if (attr_type == "diagnosis")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateCase(ID, attr_value, Convert.ToBoolean(row["c_status"].ToString()), row["casedate"].ToString());
                    }
                    MessageBox.Show("updated successfully");

                }
                else if (attr_type == "case date")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateCase(ID, row["diagnosis"].ToString(), Convert.ToBoolean(row["c_status"].ToString()),attr_value.ToString());
                    }
                    MessageBox.Show("updated successfully");
                }

                // tretment

                // labtest

                // surgery

                // assign to room

                else { MessageBox.Show("invalid attribute"); }

            }

        }

    

        private void viewcasetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void casestatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
