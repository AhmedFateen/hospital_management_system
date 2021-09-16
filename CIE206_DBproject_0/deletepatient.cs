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
    public partial class deletepatient : Form
    {
        public deletepatient()
        {
            InitializeComponent();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletepatientbutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllPatients();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(patientidtextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }
            if (patientidtextBox.Text==null)
            {
                MessageBox.Show("Enter patient ID");
                return;
            }
            else if (!patientidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("case ID don't exists"); }

            else
            {
                int ID = Convert.ToInt32(patientidtextBox.Text);
                int d=Program.controllerObj.DeletePatient(ID);
                MessageBox.Show("deleted successfully");
                //MessageBox.Show(d.ToString());
            }
        }
    }
}
