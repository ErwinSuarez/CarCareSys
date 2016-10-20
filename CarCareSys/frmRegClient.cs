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
            Close();
            System.Windows.Forms.MessageBox.Show("This should show confirmation message\n and then save the details");
            parent.Show();
        }
    }
}
