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
    public partial class frmExistingPayeePayment : Form
    {
        int userId;
        int accountId;
        database db = new database();
        public frmExistingPayeePayment()
        {
            InitializeComponent();
        }

        private void frmExistingPayeePayment_Load(object sender, EventArgs e)
        {
            userId = frmLogin.customerId;
            accountId = frmMakePayments.accountId;
            txtAccountId.Text = accountId.ToString();
            selectPayees();
        }

        void selectPayees()
        {
            string query = "select id, (firstname || ' ' || lastname) as fullname from payee where userId=" + userId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbPayee.DisplayMember = "fullname";
                cmbPayee.ValueMember = "id";
                cmbPayee.DataSource = ds.Tables[0];
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                transaction transaction = new transaction(db.codeGenerator("transactions"), accountId, "PayeePayment", int.Parse(cmbPayee.SelectedValue.ToString()), float.Parse(txtAmount.Text), date);
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
                MessageBox.Show("Please fill in amount fields");
            }
        }
    }
}
