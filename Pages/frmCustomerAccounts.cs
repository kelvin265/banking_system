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
    public partial class frmCustomerAccounts : Form
    {
        public static int accountId;
        database db = new database();
        account account = new account();
        int Id;
        public frmCustomerAccounts()
        {
            InitializeComponent();
        }

        private void frmCustomerAccounts_Load(object sender, EventArgs e)
        {
            Id = frmManageAccounts.userId;
            selectUserAccounts();
            selectUser();
        }

        private void selectUser()
        {
            string query = "select * from user where id = " + Id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                label1.Text = dr.ItemArray.GetValue(2).ToString() + " " + dr.ItemArray.GetValue(3).ToString();
            }
        }

        public void selectUserAccounts()
        {
            string query = "select * from account where userId = " + Id + "";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        int accountId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        account.Id = accountId;
                        account.Status = "Closed";
                        account.changeAccountStatus();
                    }
                }
            }
            selectUserAccounts();
            MessageBox.Show("Account closed successfully", "Close info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        int accountId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        account.Id = accountId;
                        account.Status = "Open";
                        account.changeAccountStatus();
                    }
                }
            }
            selectUserAccounts();
            MessageBox.Show("Account opened successfully", "Open info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        accountId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        frmDeposit frm = new frmDeposit();
                        frm.Show();
                    }
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        accountId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        frmWithdraw frm = new frmWithdraw();
                        frm.Show();
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            selectUserAccounts();
        }
    }
}
