using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banking_system.Classes;

namespace banking_system.Pages
{
    public partial class frmUpdateUser : Form
    {
        database db = new database();
        int id;
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            id = frmUsers.userId;
            
            selectUser();
        }

        private void selectUser()
        {
            string query = "select * from user where id = " + id + "";
            DataSet ds = db.select(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                txtUsername.Text = dr.ItemArray.GetValue(1).ToString();
                txtFirstname.Text = dr.ItemArray.GetValue(2).ToString();
                txtLastname.Text = dr.ItemArray.GetValue(3).ToString();
                txtPhone.Text = dr.ItemArray.GetValue(4).ToString();
                txtGender.Text = dr.ItemArray.GetValue(5).ToString();
                dateTimePicker1.Value = DateTime.ParseExact(dr.ItemArray.GetValue(6).ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cmbType.Text = dr.ItemArray.GetValue(7).ToString();
                txtPassword.Text = dr.ItemArray.GetValue(8).ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" || txtFirstname.Text != "" || txtLastname.Text != "" || txtPhone.Text != "" || txtGender.Text != "" || txtPassword.Text != "" || cmbType.Text != "")
            {


                string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                user user = new user(id, txtUsername.Text, txtFirstname.Text, txtLastname.Text, txtPhone.Text, txtGender.Text, date, cmbType.Text, txtPassword.Text);
                if (user.updateUser())
                {
                    MessageBox.Show("User updated successfully", "Update info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update user!", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
    }
}
