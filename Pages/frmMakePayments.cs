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
    public partial class frmMakePayments : Form
    {
        public static int accountId;
        database db = new database();
        int id;

        public frmMakePayments()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            selectUserAccounts();
        }

        public void selectUserAccounts()
        {
            string query = "select * from account where userId = " + id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(4).ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr.ItemArray.GetValue(5).ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr.ItemArray.GetValue(6).ToString();
                }

            }
        }

        private void frmMakePayments_Load(object sender, EventArgs e)
        {
            id = frmLogin.customerId;
            selectUserAccounts();
        }

        private void btnNewPayee_Click_1(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        accountId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        frmNewPayeePayment frm = new frmNewPayeePayment();
                        frm.Show();
                    }
                }
            }
        }

        private void btnExistingPayee_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        accountId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        frmExistingPayeePayment frm = new frmExistingPayeePayment();
                        frm.Show();
                    }
                }
            }
        }
    }
}
