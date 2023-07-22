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
    public partial class frmAddEmployee : Form
    {
        DBUtilities dbUtilities;

        public frmAddEmployee()
        {
            InitializeComponent();
            dbUtilities = new DBUtilities();
            loadPositions();
        }

        private void loadPositions()
        {
            try
            {
                cmbPosition.Items.Clear();
                DataTable positions = dbUtilities.queryTable("SELECT PositionName FROM tblPosition");
                foreach  (DataRow row in positions.Rows)
                {
                    cmbPosition.Items.Add(row["PositionName"].ToString()); 
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblEmployees(FirstName, LastName, MiddleName, PositionID, " +
                           "    BDATE, Gender, HomeAddress, TelNo, MobileNo, EmailAddress)" +
                           "VALUES('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtMiddleName.Text + 
                           "    '," + getPositionID(cmbPosition.Text) + 
                           "    ,'" + Convert.ToDateTime(dtBDate.Text).ToString("yyyy/MM/dd") + 
                           "    ','" + cmbGender.Text + "','" + txtHomeAddress.Text + "','" + txtTelNo.Text + 
                           "    ','" + txtMobNo.Text + "','" + txtEmailAddress.Text + "')";

            DialogResult res = MessageBox.Show("Are you sure you want to add new employee?",
                                                "Save Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                int result = dbUtilities.runSqlCommand(query);
                if (result > 0)
                {
                    MessageBox.Show("New employee added successfully!", "Add Employee",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmShowEmployees.isNewEmployeeAdded = true; // update flag to refresh main list of employees 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add new employee.", "Add Employee",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private int getPositionID(string position)
        {
            try
            {
                int positionID = Convert.ToInt32(dbUtilities.dataLookUp("PositionID", "tblPosition",
                                                                            "PositionName='" + position + "'"));
                return positionID;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return 0;
            }
        }
    }
}
