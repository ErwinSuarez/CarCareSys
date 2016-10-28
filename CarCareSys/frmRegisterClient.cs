using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCareSys
{
    
    public partial class frmRegisterClient : Form
    {
        fromMenuMain parent;

        public frmRegisterClient()
        {
            InitializeComponent();
        }

        public frmRegisterClient(fromMenuMain Child)
        {
            InitializeComponent();
            parent = Child;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfirmation frmExit = new frmConfirmation(this);
            Hide();
            frmExit.Show();
        }

        private void lblClientEmail_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Close();            

            if (parent != null)
            {
                parent.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate data
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("This field must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;

            }

            if (chkTC.Checked== false)
            {
                MessageBox.Show("T&C must be accepted","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Assign client ID

            //save data

            //display confirmation message
            MessageBox.Show("Client 678 Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSurname.Text = "";
            chkTC.Checked = false;
            txtSurname.Focus();

        }
    }
}
