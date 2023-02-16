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
    public partial class frmWithdraw : Form
    {
        database db = new database();
        account account = new account();
        float balance;
        public frmWithdraw()
        {
            InitializeComponent();
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            txtAcountId.Text = frmCustomerAccounts.accountId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                transaction transaction = new transaction(db.codeGenerator("transactions"), int.Parse(txtAcountId.Text), "Withdraw", 0, float.Parse(txtAmount.Text), date);
                if (transaction.newTransaction())
                {
                    account.Id = int.Parse(txtAcountId.Text);
                    balance = account.selectBalance();
                    account.Balance = balance - float.Parse(txtAmount.Text);
                    account.updateBalance();
                    MessageBox.Show("Amount withdrawn successfully", "Withdraw info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to register the user !", "Withdraw error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
