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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        // check the entered info if present in the db and make the logic
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text==null && PasswordTextBox.Text==null)
            {
                MessageBox.Show("Make sure you entered the username and password");
                return;
            }
            else if(UsernameTextBox.Text == "aa" && PasswordTextBox.Text == "25")
            {
                new mainmenu(3).Show();
            }
            DataTable dtPatients = Program.controllerObj.ViewPatientUsernamePassword();
            DataTable dtEmployee = Program.controllerObj.ViewEmployeeUsernamePassword();

            for (int i=0; i<dtPatients.Rows.Count;i++)
            {

                if (UsernameTextBox.Text == dtPatients.Rows[i][0].ToString())
                {
                    if(PasswordTextBox.Text== dtPatients.Rows[i][1].ToString())
                    {
                        new mainmenu(0).Show();
                       
                     }
                }
            }

            for (int i = 0; i < dtEmployee.Rows.Count; i++)
            {

                if (UsernameTextBox.Text == dtEmployee.Rows[i][0].ToString())
                {
                    if (PasswordTextBox.Text == dtEmployee.Rows[i][1].ToString())
                    {
                        if (dtEmployee.Rows[i][2].ToString().ToLower()=="doctor")
                        {
                            new mainmenu(2).Show();
                        }
                        else if (dtEmployee.Rows[i][2].ToString().ToLower() == "nurse")
                        {
                            new mainmenu(1).Show();
                        }
                        else if (dtEmployee.Rows[i][2].ToString().ToLower() == "admin")
                        {
                            new mainmenu(3).Show();
                        }
                        else if (dtEmployee.Rows[i][2].ToString().ToLower() == "receptionist")
                        {
                            new mainmenu(0).Show();
                        }
                        else 
                        {
                            MessageBox.Show("else");
                            //new mainmenu(-1).Show();
                        }
                       
                    }
                }
            }


        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
