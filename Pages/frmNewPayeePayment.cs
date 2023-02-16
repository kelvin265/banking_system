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
    public partial class frmNewPayeePayment : Form
    {
        int userId;
        int accountId;
        int payeeId;
        database db = new database();
        public frmNewPayeePayment()
        {
            InitializeComponent();
        }

        private void frmNewPayeePayment_Load(object sender, EventArgs e)
        {
            userId = frmLogin.customerId;
            accountId = frmMakePayments.accountId;
            txtAccountId.Text = accountId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != "" || txtLastname.Text != "" || txtAccountNumber.Text != "" || txtAmount.Text != "")
            {
                payeeId = db.codeGenerator("payee");
                payee payee = new payee(payeeId, userId, txtFirstname.Text, txtLastname.Text, txtAccountNumber.Text);
                if (payee.addPayee())
                {

                    MessageBox.Show("Payee added successfully", "Payee info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                    transaction transaction = new transaction(db.codeGenerator("transactions"), accountId, "PayeePayment", payeeId, float.Parse(txtAmount.Text), date);
                    if (transaction.newTransaction())
                    {
                        account account = new account();
                        account.Id = accountId;
                        float balance = account.selectBalance();
                        account.Balance = balance - float.Parse(txtAmount.Text);
                        account.updateBalance();
                        MessageBox.Show("Payment made successfully", "Payee Payment info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to complete payment !", "Payee Payment error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add payee !", "Payee error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
