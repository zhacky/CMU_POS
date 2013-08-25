using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CMU_Point_Of_Sale_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void stockMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogs.AboutBoxMain about = new Dialogs.AboutBoxMain();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?","Logout Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2 ) )
            {
                Close();
            }
            
        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
