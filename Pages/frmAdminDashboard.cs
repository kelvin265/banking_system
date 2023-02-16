using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system.Pages
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clear();
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            clear();
            lblTitle.Text = "Welcome Admin";
            btnHome.BackColor = Color.WhiteSmoke;
            this.pnlFormLoader.Controls.Clear();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmUsers frm = new frmUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "Manage Users";
            btnUsers.BackColor = Color.WhiteSmoke;
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmManageAccounts frm = new frmManageAccounts() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "Manage User Bank Accounts";
            btnManageAccounts.BackColor = Color.WhiteSmoke;
        }

        void clear()
        {

            btnManageAccounts.BackColor = Color.Transparent;
            btnUsers.BackColor = Color.Transparent;
            btnHome.BackColor = Color.Transparent;
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome Admin";
            btnHome.BackColor = Color.WhiteSmoke;

        }
    }
}
