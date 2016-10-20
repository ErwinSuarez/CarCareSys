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
    public partial class fromMenuMain : Form
    {     

        public fromMenuMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)                //This will exit the program
        {
            frmConfirmation frmExit = new frmConfirmation();
            Hide();
            frmExit.Show();
        }

        private void registerCrewToolStripMenuItem_Click(object sender, EventArgs e)       //This should register crew members
        {
            frmRegisterClient frmNext = new frmRegisterClient(this);
            Hide();
            frmNext.Show();
        }

        private void registerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterClient frmNext = new frmRegisterClient(this);
            Hide();
            frmNext.Show();
        }
        
        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetails frmUpDate = new frmClientDetails(this);
            Hide();
            frmUpDate.Show();
        }

        private void deregisterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetails frmUpDate = new frmClientDetails(this);
            Hide();
            frmUpDate.Show();
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            System.Windows.Forms.MessageBox.Show("This should pull out the records of all clients listed");
            Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deregisterCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetails frmUpDate = new frmClientDetails(this);
            Hide();
            frmUpDate.Show();
        }
    }
}
