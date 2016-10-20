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
    public partial class frmClientDetails : Form
    {
        fromMenuMain parent;

        public frmClientDetails()
        {
            InitializeComponent();
        }

        public frmClientDetails(fromMenuMain Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Close();
            System.Windows.Forms.MessageBox.Show("This should present confirmation message\n and then retreives the Clients details");
            Close();
            parent.Show();
        }
    }
}
