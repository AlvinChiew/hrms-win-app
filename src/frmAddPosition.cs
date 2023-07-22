using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrms_win_app
{
    public partial class frmAddPosition : Form
    {
        DBUtilities dbUtilities;

        public frmAddPosition()
        {
            InitializeComponent();
            dbUtilities = new DBUtilities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPositionName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter position name.", "Add Position",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO tblPosition(PositionName) " +
                               "VALUES('" + txtPositionName.Text + "')";
                int result = dbUtilities.runSqlCommand(query);
                if (result > 0)
                {
                    MessageBox.Show("New Position name added successfully!", "Add Position",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add new Position name.", "Add Position",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }


    }
}
