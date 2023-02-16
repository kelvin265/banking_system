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
    public partial class frmManagePayees : Form
    {
        database db = new database();
        public static int payeeId;
        public frmManagePayees()
        {
            InitializeComponent();
        }

        private void btnNewPayee_Click(object sender, EventArgs e)
        {
            frmAddPayee frm = new frmAddPayee();
            frm.Show();
        }

        private void frmManagePayees_Load(object sender, EventArgs e)
        {
            viewPayees();
        }

        public void viewPayees()
        {
            string query = "select * from payee where userId='"+frmLogin.customerId+"'";
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
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            viewPayees();
        }

        private void btnUpdatePayee_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value != null)
                    {
                        payeeId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        frmUpdatePayee frm = new frmUpdatePayee();
                        frm.Show();

                    }
                }
            }
        }

        private void btnDeletePayee_Click(object sender, EventArgs e)
        {
            string query;
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i <= count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[4].Value != null)
                    {
                        payeeId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        query = "delete from payee where id=" + payeeId + "";
                        if (db.delete(query))
                        {
                            MessageBox.Show("Payee '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' has been successfully removed ", "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Rows.Clear();
                        }
                    }
                }
                viewPayees();
            }
        }
    }
}
