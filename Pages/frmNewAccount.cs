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
    public partial class frmNewAccount : Form
    {
        database db = new database();
        int id;
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "" && txtInterestRate.Text != "" && cmbType.Text != "" && txtThreshold.Text != "")
            {

                account account = new account(db.codeGenerator("account"),id,cmbType.Text,float.Parse(txtInterestRate.Text),0,"Open",float.Parse(txtThreshold.Text));
                if (account.createAccount())
                {
                    MessageBox.Show("Account created successfully", "Create info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to create account", "Create error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            id = frmManageAccounts.userId;

            selectUser();
        }

        private void selectUser()
        {
            string query = "select * from user where id = " + id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];              
                txtCustomer.Text = dr.ItemArray.GetValue(2).ToString() + " " + dr.ItemArray.GetValue(3).ToString();
            }
        }
    }
}
