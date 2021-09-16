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
    public partial class viewpatient : Form
    {
        public viewpatient()
        {
            InitializeComponent();

        }

        

        private void viewpatientbutton_Click(object sender, EventArgs e)
        {
            DataTable pp = Program.controllerObj.ViewAllPatients();
            int prowscount = pp.Rows.Count;
            int pflag = 0;

            for (int i = 0; i < prowscount; i++)
            {
                if (Convert.ToInt32(pp.Rows[i][0].ToString()) == Convert.ToInt32(patientidtextBox.Text)) { pflag = 1; break; }
                else { continue; }
            }

            if (String.IsNullOrEmpty(patientidtextBox.Text))
            {
                MessageBox.Show("Enter patient ID");
                return;
            }
            else if (!patientidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (pflag == 0) { MessageBox.Show("patient ID don't exists"); }

            else
            {
                DataTable dt = Program.controllerObj.ViewPatient(Convert.ToInt32(patientidtextBox.Text));
                viewpatientdataGridView.DataSource = dt;
                viewpatientdataGridView.Refresh();

            }
        }

        private void ViewAllPatientsbutton_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.controllerObj.ViewAllPatients();
            viewpatientdataGridView.DataSource = dt;
            viewpatientdataGridView.Refresh();
        }

        private void ViewMedicalRecordbutton_Click(object sender, EventArgs e)
        {
            DataTable pp = Program.controllerObj.ViewAllPatients();
            int prowscount = pp.Rows.Count;
            int pflag = 0;

            for (int i = 0; i < prowscount; i++)
            {
                if (Convert.ToInt32(pp.Rows[i][0].ToString()) == Convert.ToInt32(patientidtextBox.Text)) { pflag = 1; break; }
                else { continue; }
            }

            if (String.IsNullOrEmpty(patientidtextBox.Text) || Convert.ToInt32(patientidtextBox.Text)<0) 
            {
                MessageBox.Show("please enter a valid ID");
            }
            else if (pflag == 0) { MessageBox.Show("doctor ID don't exists");  }

            else
            {
                        DataTable dt = Program.controllerObj.ViewMedicalRecord(Convert.ToInt32(patientidtextBox.Text));
                        viewpatientdataGridView.DataSource = dt;
                        viewpatientdataGridView.Refresh();
                    }
        }
    }
}
