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
    public partial class frmCustomerTransactions : Form
    {
        database db = new database();
        public static int userId;
        public frmCustomerTransactions()
        {
            InitializeComponent();
        }

        private void frmCustomerTransactions_Load(object sender, EventArgs e)
        {
            userId = frmLogin.customerId;
            viewTransactions();
        }

        public void viewTransactions()
        {
            string query = "select t.* from transactions t, account a where a.userId="+userId+ "and  a.id = t.accountId";
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
                    dataGridView1.Rows[n].Cells[3].Value = dr.ItemArray.GetValue(3).ToString() == "0" ? "None" : dr.ItemArray.GetValue(3).ToString();
                    dataGridView1.Rows[n].Cells[4].Value = dr.ItemArray.GetValue(4).ToString();
                    dataGridView1.Rows[n].Cells[5].Value = dr.ItemArray.GetValue(5).ToString();
                }
            }
        }
    }
}
