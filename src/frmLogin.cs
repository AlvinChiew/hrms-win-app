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
    public partial class frmLogin : Form
    {
        DBUtilities dbUtilities = new DBUtilities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginProgram()
        {
            try
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;

                bool valResult = validateUserLogin(username, password);
                if (valResult)
                {
                    MessageBox.Show("Authorized. Welcome!", "HRMS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mdiMain mainForm = new mdiMain();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username / password.", "HRMS",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validateUserLogin(string username, string password)
        {
            bool result = false;
            try
            {
                DataTable dt = dbUtilities.queryTable("SELECT * FROM dbHrmsProj.dbo.tblUsers " +
                                                      "WHERE UserName='" + username + "' " +
                                                      "AND UserPassword='" + password + "'");
                if (dt == null)
                {
                    return false;
                }

                foreach(DataRow dr in dt.Rows)
                {
                    if (dr["UserName"].ToString().Equals(username, StringComparison.CurrentCultureIgnoreCase) &&
                        dr["UserPassword"].ToString().Equals(password))
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            return result;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginProgram();
        }
    }
}
