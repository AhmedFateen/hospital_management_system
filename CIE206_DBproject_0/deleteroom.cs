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
    public partial class deleteroom : Form
    {

        public deleteroom()
        {
            InitializeComponent();
        }

        private void deleteroombutton_Click(object sender, EventArgs e)
        {
            DataTable dd = Program.controllerObj.ViewAllRoom();
            int drowscount = dd.Rows.Count;
            int dflag = 0;

            for (int i = 0; i < drowscount; i++)
            {
                if (Convert.ToInt32(dd.Rows[i][0].ToString()) == Convert.ToInt32(roomidtextBox.Text)) { dflag = 1; break; }
                else { continue; }
            }

            if (roomidtextBox.Text == null)
            {
                MessageBox.Show("Enter room ID");
                return;
            }
            else if (!roomidtextBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("IDs should only contain digits");
            }
            else if (dflag == 0) { MessageBox.Show("room ID don't exists"); }

            else
            {
                int ID = Convert.ToInt32(roomidtextBox.Text);
                int d = Program.controllerObj.DeleteRoom(ID);
                MessageBox.Show("deleted successfully");
            }
        }
    }
}
