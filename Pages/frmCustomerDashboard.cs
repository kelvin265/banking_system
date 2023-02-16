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
    public partial class frmCustomerDashboard : Form
    {
        public frmCustomerDashboard()
        {
            InitializeComponent();
        }

        private void frmCustomerDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Welcome Customer";
            btnHome.BackColor = Color.WhiteSmoke;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            clear();
            lblTitle.Text = "Welcome Customer";
            btnHome.BackColor = Color.WhiteSmoke;
            this.pnlFormLoader.Controls.Clear();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmCustomerTransactions frm = new frmCustomerTransactions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "View all Transactions";
            btnTransactions.BackColor = Color.WhiteSmoke;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmCustomerBalances frm = new frmCustomerBalances() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "View Account Balances";
            btnBalance.BackColor = Color.WhiteSmoke;
        }

        void clear()
        {

            btnTransactions.BackColor = Color.Transparent;
            btnBalance.BackColor = Color.Transparent;
            btnHome.BackColor = Color.Transparent;
            btnManagePayees.BackColor = Color.Transparent;
            btnMakePayments.BackColor = Color.Transparent;
            btnTransFerMoney.BackColor = Color.Transparent;
        }

        private void btnManagePayees_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmManagePayees frm = new frmManagePayees() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "Manage all Account Payees";
            btnManagePayees.BackColor = Color.WhiteSmoke;
        }

        private void btnMakePayments_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmMakePayments frm = new frmMakePayments() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "Make Payments";
            btnMakePayments.BackColor = Color.WhiteSmoke;
        }

        private void btnTransFerMoney_Click(object sender, EventArgs e)
        {
            clear();
            this.pnlFormLoader.Controls.Clear();
            frmTransferMoney frm = new frmTransferMoney() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(frm);
            frm.Show();

            lblTitle.Text = "Transfer Money to Another Account";
            btnTransFerMoney.BackColor = Color.WhiteSmoke;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            clear();
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
