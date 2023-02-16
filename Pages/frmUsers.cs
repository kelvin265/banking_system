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
    public partial class frmUsers : Form
    {
        database db = new database();
        public static int userId = 0;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.Show();
        }

        public void viewUsers()
        {
            string query = "select * from user";
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
                    dataGridView1.Rows[n].Cells[6].Value = dr.ItemArray.GetValue(6).ToString();
                    dataGridView1.Rows[n].Cells[7].Value = dr.ItemArray.GetValue(7).ToString();
                }
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            viewUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value != null)
                    {
                        userId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        frmUpdateUser frm = new frmUpdateUser();
                        frm.Show();

                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query;
            int count = dataGridView1.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i <= count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value != null)
                    {
                        userId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        query = "delete from user where id=" + userId + "";
                        if (db.delete(query))
                        {
                            MessageBox.Show("User '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "' has been successfully removed ", "Delete info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Rows.Clear();
                        }
                    }
                }
                viewUsers();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            viewUsers();
        }
    }
}
