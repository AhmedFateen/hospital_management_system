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
    public partial class deletecase : Form
    {
        public deletecase()
        {
            InitializeComponent();

        }

        private void deletecasebutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllCases();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(deletecasetextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }

            if (deletecasetextBox.Text==null)
            {
                MessageBox.Show("Enter Case ID");
                return;
            }
            else if (!deletecasetextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("case ID don't exists"); }

            else
            {
                int ID = Convert.ToInt32(deletecasetextBox.Text);
                int d = Program.controllerObj.DeleteCase(ID);
                MessageBox.Show(d.ToString());
            }

        }

        private void deletecasetextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
