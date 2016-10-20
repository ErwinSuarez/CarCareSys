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
    public partial class frmConfirmation : Form
    {
        frmRegisterClient parent;
        public frmConfirmation()
        {
            InitializeComponent();
        }

        public frmConfirmation(frmRegisterClient Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
            if (parent != null)
            {
                parent.Show();
            }
        }
    }
}
