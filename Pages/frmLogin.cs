using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banking_system.Classes;


namespace banking_system.Pages
{
    public partial class frmLogin : Form
    {
        int loginFails = 0;
        int inc = 10;
        database con = new database();
        public static int customerId;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Interval = 1000;
            inc += 5;
            if (inc >= 425)
            {
                timerSplash.Stop();
                lbnNotification.Visible = false;
                txtPassword.Enabled = true;
                txtUsername.Enabled = true;
                btnLogin.Enabled = true;
                inc = 10;
                loginFails = 0;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                string result;
                user user = new user();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                result = user.login();

                if(result == "admin")
                {
                    this.Hide();
                    frmAdminDashboard frm = new frmAdminDashboard();
                    frm.Show();
                }
                else if (result == "failed")
                {
                    loginFails += 1;
                    MessageBox.Show("" + loginFails.ToString() + " failed attempt(s) to login into the system", "Wrong Password or Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    customerId = int.Parse(result);
                    this.Hide();
                    frmCustomerDashboard frm = new frmCustomerDashboard();
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty fields", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
