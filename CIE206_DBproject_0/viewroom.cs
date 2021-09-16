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
    public partial class viewroom : Form
    {
        public viewroom()
        {
            InitializeComponent();
        }

        private void viewroombutton_Click(object sender, EventArgs e)
        {
            DataTable qq = Program.controllerObj.ViewAllRoom();

            int rowscount = qq.Rows.Count;
            int flag = 0;

            for (int i = 0; i < rowscount; i++)
            {
                if (Convert.ToInt32(qq.Rows[i][0].ToString()) == Convert.ToInt32(viewroomtextBox.Text)) { flag = 1; break; }
                else { continue; }
            }

                if (viewroomtextBox.Text == null)
            {
                MessageBox.Show("Enter room ID");
                return;
            }
            else if (!viewroomtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (String.IsNullOrEmpty(viewroomtextBox.Text))
            {
                MessageBox.Show("Enter all required data");
                return;
            }
                else if (flag == 0) { MessageBox.Show("room ID don't exists"); }
            //if (flag == 1)
            //{

            //}
            else
            {
                int ee = Program.controllerObj.num_patient_room(Convert.ToInt32(viewroomtextBox.Text));
                DataRow[] ww = qq.Select("RID= " + viewroomtextBox.Text);
                foreach (DataRow row in ww)
                {
                    int aa = Program.controllerObj.UpdateRoom(Convert.ToInt32(viewroomtextBox.Text), ee, Convert.ToInt32(row["capacity"]), row["r_type"].ToString());

                }

                DataTable dt = Program.controllerObj.ViewRoom(Convert.ToInt32(viewroomtextBox.Text));
                viewroomdataGridView.DataSource = dt;
                viewroomdataGridView.Refresh();

            }

        }

        private void ViewAllRoombutton_Click(object sender, EventArgs e)
        {
            //DataTable qq = Program.controllerObj.ViewAllRoom();

            //MessageBox.Show("flag=1 inside else");
            //int ee = Program.controllerObj.num_patient_room(Convert.ToInt32(viewroomtextBox.Text));
            //DataRow[] ww = qq.Select("RID= " + viewroomtextBox.Text);
            //foreach (DataRow row in ww)
            //{
            //    int aa = Program.controllerObj.UpdateRoom(Convert.ToInt32(viewroomtextBox.Text), ee, Convert.ToInt32(row["capacity"]), row["r_type"].ToString());

            //}

            DataTable dt = Program.controllerObj.ViewAllRoom();
            viewroomdataGridView.DataSource = dt;
            viewroomdataGridView.Refresh();
            //for(int i = 0;i<5;i++)
            //{
            //    MessageBox.Show(dt.Rows[i][0].ToString());
            //}

        }
    }
}
