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
    public partial class addroom : Form
    {
        Controller controllerObj;
        public addroom()
        {
            InitializeComponent();
           
        }

        private void capacitytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addroombutton_Click(object sender, EventArgs e)
        {
            //DataTable qq = Program.controllerObj.ViewAllRoom();
            ////DataRow[] dq = qq.Select();
            //int rowscount = qq.Rows.Count;
            //int flag = 0;

            //for (int i = 0; i < rowscount; i++)
            //{
            //    if (Convert.ToInt32(qq.Rows[i][0].ToString()) == Convert.ToInt32(roomidtextBox.Text)) { flag = 1; break; }
            //    else { continue; }

            //}
            bool isNumeric = int.TryParse(capacitytextBox.Text, out _);


            if (String.IsNullOrEmpty(roomtypecomboBox.Text) || String.IsNullOrEmpty(roomidtextBox.Text) || String.IsNullOrEmpty(capacitytextBox.Text))
            {
                MessageBox.Show("Enter all required data");
                return;
            }
            else if (!isNumeric || Convert.ToInt32(capacitytextBox.Text) < 0) // if not numeric, the second part is ignored
            {
                MessageBox.Show("Invalid Capacity Value");
                return;

            }
            //bool isNum = int.TryParse(patientnumtextBox.Text, out _);
            //if (!isNum || Convert.ToInt32(patientnumtextBox.Text) < 0) // if not numeric, the second part is ignored
            //{
            //    MessageBox.Show("Invalid number of patients");
            //    return;

            //}
            else if (!roomidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should contain only digits");
                return;
            }
            //else if(flag == 0) { MessageBox.Show()}
            else
            {
                //DataRow[] dt = xx.Select("PID= " + viewcasetextBox.Text);

                int xx = controllerObj.num_patient_room(Convert.ToInt32(roomidtextBox.Text));
                //MessageBox.Show(xx.ToString());
                //DataRow[] yy = xx.Select();
                //int available_seats = Convert.ToInt32(capacitytextBox.Text) - Convert.ToInt32(yy);                   // read value from a data table
                //int w = 0;                                                                                               //DataRow ww = available_seats["count(case_num)"];

                //foreach (DataRow row in yy)
                //{

                //    int q =Convert.ToInt32(row["Number_patient_room"]);
                //    w = q;
                //}
                //xx.Rows(1).Item(1);
                //    "Datatablename".Rows(“rownumber”).Item(“columnName / columnNumber”)

                //Convert.ToInt32(patientnumtextBox.Text)
                //int  available_seats = Convert.ToInt32(capacitytextBox.Text) - xx;
                int r = Program.controllerObj.AddRoom(Convert.ToInt32(roomidtextBox.Text), xx, Convert.ToInt32(capacitytextBox.Text), roomtypecomboBox.Text);

                if (r > 0)
                {
                    MessageBox.Show("Room added successfully");
                    viewroom.ActiveForm.Close();
                }
                else
                { MessageBox.Show("Operation Failed");
                    return; }
            

                
                //else { MessageBox.Show("enter avalid ID"); }


            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void patientnumtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gevernedbytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addroom_Load(object sender, EventArgs e)
        {

        }
    }
}
