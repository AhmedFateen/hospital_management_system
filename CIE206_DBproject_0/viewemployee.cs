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
    public partial class viewemployee : Form
    {
        public viewemployee()
        {
            InitializeComponent();

        }

        private void viewemployeedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewemployeebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllEmployees();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(viewemployeetextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }
            if (String.IsNullOrEmpty(viewemployeetextBox.Text))
            {
                MessageBox.Show("Enter employee ID");
                return;
            }
            else if (!viewemployeetextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("employee ID don't exists");}

            else
            {
                DataTable dt = Program.controllerObj.ViewEmployee(Convert.ToInt32(viewemployeetextBox.Text));
                viewemployeedataGridView.DataSource = dt;
                viewemployeedataGridView.Refresh();

            }
        }

        private void ViewAllEmployeesbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.controllerObj.ViewAllEmployees();
            viewemployeedataGridView.DataSource = dt;
            viewemployeedataGridView.Refresh();
        }
    }
    }

