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

                string id = dbUtilities.dataLookUp("UserID", "tblUsers", "UserName = '" + username +
                                                    "' AND UserPassword = '" + password + "'");
                if (!id.Equals(""))
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
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginProgram();
        }
    }
}
