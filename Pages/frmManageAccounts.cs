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
    public partial class frmManageAccounts : Form
    {
        database db = new database();
        public static int userId;
        public frmManageAccounts()
        {
            InitializeComponent();
        }

        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            viewUsers();
        }

        public void viewUsers()
        {
            string query = "select * from user where type='customer'";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(0).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(1).ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr.ItemArray.GetValue(4).ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr.ItemArray.GetValue(5).ToString();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            viewUsers();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        userId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());

                        frmNewAccount frm = new frmNewAccount();
                        frm.Show();
                    }
                }
            }
        }

        private void btnViewAccounts_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[6].Value != null)
                    {
                        userId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());

                        frmCustomerAccounts frm = new frmCustomerAccounts();
                        frm.Show();
                    }
                }
            }
        }
    }
}
