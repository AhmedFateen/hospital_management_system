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
    public partial class updateroom : Form
    {

        public updateroom()
        {
            InitializeComponent();

        }

        private void updateroom_Load(object sender, EventArgs e)
        {

        }

        private void updateroombutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllRoom();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(roomidtextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }

            if (roomidtextBox.Text == null || attributeComboBox.Text == null || valueTextBox.Text == null)
            {
                MessageBox.Show("Enter all required data");
            }
            else if (!roomidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("room ID don't exists"); }

            else
            {
                int RID = Convert.ToInt32(roomidtextBox.Text);
                string attr_type = attributeComboBox.Text;
                string attr_value = valueTextBox.Text;
                DataTable xx = Program.controllerObj.ViewRoom(Convert.ToInt32(roomidtextBox.Text));
                DataRow[] dt = xx.Select("RID= " + roomidtextBox.Text);
                if (attr_type == "room type")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateRoom(RID, Convert.ToInt32(row["current_num_of_patients"]), Convert.ToInt32(row["capacity"]), attr_value);
                        
                    }
                    MessageBox.Show("updated successfully");

                }
                else if (attr_type == "capacity")
                {
                    foreach (DataRow row in dt)
                    {
                        int r = Program.controllerObj.UpdateRoom(RID, Convert.ToInt32(row["current_num_of_patients"]), Convert.ToInt32(attr_value),row["r_type"].ToString());

                    }
                    MessageBox.Show("updated successfully");

                }

            }

        }

        private void casestatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
