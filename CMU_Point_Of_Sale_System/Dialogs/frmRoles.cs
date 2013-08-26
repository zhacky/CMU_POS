using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMU_Point_Of_Sale_System.Dialogs
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testPOSDataSet);

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testPOSDataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.testPOSDataSet.roles);

        }
    }
}
