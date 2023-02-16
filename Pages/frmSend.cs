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
    public partial class frmSend : Form
    {
        int userId;
        int accountId;
        database db = new database();
        public frmSend()
        {
            InitializeComponent();
        }

        private void frmSend_Load(object sender, EventArgs e)
        {
            accountId = frmTransferMoney.accountId;
            userId = frmLogin.customerId;
            txtFrom.Text = accountId.ToString();
            selectAccounts();
        }

        void selectAccounts()
        {
            string query = "select id, (' ID: ' || id || ' Type: ' || accountType) as fullname from account where userId=" + userId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cmbTo.DisplayMember = "fullname";
                cmbTo.ValueMember = "id";
                cmbTo.DataSource = ds.Tables[0];

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbTo.SelectedValue.ToString() != txtFrom.Text)
            {
                if (txtAmount.Text != "")
                {
                    string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                    transaction transaction = new transaction(db.codeGenerator("transactions"), accountId, "AccountToAccount", 0, float.Parse(txtAmount.Text), date);
                    if (transaction.newTransaction())
                    {
                        account account = new account();
                        account.Id = accountId;
                        float balance = account.selectBalance();
                        account.Balance = balance - float.Parse(txtAmount.Text);
                        account.updateBalance();

                        account.Id = int.Parse(cmbTo.SelectedValue.ToString());
                        balance = account.selectBalance(); ;
                        account.Balance = balance + float.Parse(txtAmount.Text);
                        account.updateBalance();
                        MessageBox.Show("Money transfered successfully", "Account Transfer info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Failed to transfer money !", "Account Transfer error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in amount fields");
                }
            }
        }
    }
}
