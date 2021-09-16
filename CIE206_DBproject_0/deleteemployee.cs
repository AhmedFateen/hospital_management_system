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
    public partial class deleteemployee : Form
    {
        public deleteemployee()
        {
            InitializeComponent();

        }

        private void deleteemployeebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllEmployees();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(employeeidtextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }

            if (employeeidtextBox.Text==null)
            {
                MessageBox.Show("Enter Employee ID");
                return;
            }
            else if (!employeeidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("employee ID don't exists"); }

            else
            {
                int ID = Convert.ToInt32(employeeidtextBox.Text);
                int d = Program.controllerObj.DeleteEmployee(ID);
                //MessageBox.Show(d.ToString());
                //int d = controllerObj.UpdateEmployee(0, null, null, Convert.ToBoolean(null), null, null, null, null, null, Convert.ToChar(null), null);
                MessageBox.Show("deleted successfully");

            }
        }
    }
}
