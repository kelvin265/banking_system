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
    
    public partial class frmUpdatePayee : Form
    {
        database db = new database();
        int userId;
        int payeeId;
        public frmUpdatePayee()
        {
            InitializeComponent();
        }

        private void frmUpdatePayee_Load(object sender, EventArgs e)
        {
            userId = frmLogin.customerId;
            payeeId = frmManagePayees.payeeId;
            selectUser();
            selectPayee();
        }
        private void selectUser()
        {
            string query = "select * from user where id = " + userId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtUser.Text = dr.ItemArray.GetValue(2).ToString() + " " + dr.ItemArray.GetValue(3).ToString();

            }
        }
        private void selectPayee()
        {
            string query = "select * from payee where id = " + payeeId + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtFirstname.Text = dr.ItemArray.GetValue(2).ToString();
                txtLastname.Text =   dr.ItemArray.GetValue(3).ToString();
                txtAccountNumber.Text = dr.ItemArray.GetValue(4).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != "" || txtLastname.Text != "")
            {
                payee payee = new payee(payeeId, userId, txtFirstname.Text, txtLastname.Text,txtAccountNumber.Text);
                if (payee.updatePayee())
                {
                    MessageBox.Show("Payee details updated successfully", "Payee info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to update payee details!", "Payee error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
