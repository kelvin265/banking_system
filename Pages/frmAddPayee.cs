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
    public partial class frmAddPayee : Form
    {
        database db = new database();
        int id;
        public frmAddPayee()
        {
            InitializeComponent();
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if ( txtFirstname.Text != "" || txtLastname.Text != "" || txtAccountNumber.Text != "")
            {
                payee payee = new payee(db.codeGenerator("payee"),id,txtFirstname.Text,txtLastname.Text,txtAccountNumber.Text);
                if (payee.addPayee())
                {
                    MessageBox.Show("Payee added successfully", "Payee info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to add payee !", "Payee error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void frmAddPayee_Load(object sender, EventArgs e)
        {
            id = frmLogin.customerId;
            selectUser();
        }
        private void selectUser()
        {
            string query = "select * from user where id = " + id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtUser.Text = dr.ItemArray.GetValue(2).ToString() + " " + dr.ItemArray.GetValue(3).ToString();

            }
        }
    }
}
