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
    public partial class frmCustomerBalances : Form
    {
        database db = new database();
        public static int userId;
        public frmCustomerBalances()
        {
            InitializeComponent();
        }

        private void frmCustomerBalances_Load(object sender, EventArgs e)
        {
            userId = frmLogin.customerId;
            viewAccounts();
        }
        public void viewAccounts()
        {
            string query = "select * from account where userId=" + userId;
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr.ItemArray.GetValue(2).ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr.ItemArray.GetValue(3).ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr.ItemArray.GetValue(4).ToString();
                 
                }
            }
        }
    }
}
