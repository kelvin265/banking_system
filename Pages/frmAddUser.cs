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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            database db = new database();
            if (txtUsername.Text != "" || txtFirstname.Text != "" || txtLastname.Text != "" || txtPhone.Text != "" || txtGender.Text != "" || txtPassword.Text != "" || cmbType.Text != "")
            {
                string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                user user = new user(db.codeGenerator("user"), txtUsername.Text, txtFirstname.Text, txtLastname.Text, txtPhone.Text, txtGender.Text,date, cmbType.Text, txtPassword.Text);
                if (user.addUser())
                {
                    MessageBox.Show("User registered successfully as a customer", "Register info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Failed to register the user !", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
