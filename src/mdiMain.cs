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
    public partial class mdiMain : Form
    {
        DBUtilities dbUtilities = new DBUtilities();

        public mdiMain()
        {
            InitializeComponent();
        }

        private void mnuShowAllEmployees_Click(object sender, EventArgs e)
        {
            frmShowEmployees showEmployees = new frmShowEmployees();
            showEmployees.MdiParent = this;
            showEmployees.WindowState = FormWindowState.Normal;
            showEmployees.Show(); 
        }

        private void mnuAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee addEmployee = new frmAddEmployee();
            addEmployee.MdiParent = this;
            addEmployee.WindowState = FormWindowState.Normal;
            addEmployee.Show();
        }

        private void mnuAddPosition_Click(object sender, EventArgs e)
        {
            frmAddPosition addPosition = new frmAddPosition();
            addPosition.MdiParent = this;
            addPosition.WindowState = FormWindowState.Normal;
            addPosition.Show();
        }
        //private void loginProgram()
        //{
        //    try
        //    {                
        //        bool loginSuccessful = false;
        //        frmLogin loginForm = new frmLogin();
        //        while (loginForm.ShowDialog() == DialogResult.OK)
        //        {
        //            string username = loginForm.txtUserName.Text;
        //            string password = loginForm.txtPassword.Text;

        //            string id = dbUtilities.dataLookUp("UserID", "tblUsers", "UserName = '" + username +
        //                                                "' AND UserPassword = '" + password + "'");
        //            if (id.Equals(""))
        //            {
        //                MessageBox.Show("Incorrect username / password.", "HRMS",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }                    
        //            else
        //            {
        //                MessageBox.Show("Authorized. Welcome!", "HRMS",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                //mdiMain mainForm = new mdiMain();
        //                //mainForm.Show();
        //                //this.Hide();
        //                loginSuccessful = true;
        //                break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
