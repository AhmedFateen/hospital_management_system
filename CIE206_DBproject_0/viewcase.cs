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
    public partial class viewcase : Form
    {
        public viewcase()
        {
            InitializeComponent();
        }

        private void viewcasebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllCases();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(viewcasetextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }

            if (String.IsNullOrEmpty(viewcasetextBox.Text))
            {
                MessageBox.Show("Enter case ID");
                return;
            }
            else if (!viewcasetextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("case ID don't exists"); }
            else
            {
                
                    DataTable dt = Program.controllerObj.ViewCase(Convert.ToInt32(viewcasetextBox.Text));
                    viewcasedataGridView.DataSource = dt;
                    viewcasedataGridView.Refresh();
                //DataTable dl = controllerObj.ViewLabTest(Convert.ToInt32(viewcasetextBox.Text));

   
            }
        }

        private void ViewAllCasesbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.controllerObj.ViewAllCases();
            viewcasedataGridView.DataSource = dt;
            viewcasedataGridView.Refresh();
        }
    }
}
