using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace LoginForm
{
    public partial class login_form : Form
    {
        private Font averagefont = new Font("Arial", 12);
        public login_form()
        {
            InitializeComponent();
            label1.Font = averagefont;
            label2.Font = averagefont;
            btRegister.Font = averagefont;
            btLogin.Font = averagefont;

            //string connectionString = "server=localhost;user=root;database=bhanudb;port=3306;password=Prasad$289";
            // MySqlConnection connection = new MySqlConnection(connectionString);
            // connection.Open();
            // string selectquery = "select * from user where id =" + int.Parse(tbId.Text);
            // MySqlCommand cmd = new MySqlCommand(selectquery, connection);
            // MySqlDataReader reader1;
            // reader1 = cmd.ExecuteReader();
            // if (reader1.Read()) {
            //     tbFirstName.Text = reader1.GetValue(1).ToString();
            //     tbLastName.Text = reader1.GetValue(2).ToString();
            //     tbEmail.Text = reader1.GetValue(3).ToString();
            //     
            // } else {
            //     MessageBox.Show("NO DATA FOUND");
            // }
            // connection.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbEmail.Text;
            string password = tbPassword.Text;
            
            if (username == "")
            {
                tbEmail.BackColor = Color.Lime;
                MessageBox.Show("Please enter your email", "validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbEmail.Focus();
            }

            else if (!IsValidEmail(tbEmail.Text))
            {
                tbEmail.BackColor = Color.Peru;
                MessageBox.Show("Please enter a valid email address","Validation error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tbEmail.Focus();
            }
            else if (password == "")
            {
                tbPassword.BackColor = Color.Lime;
                MessageBox.Show("Enter a valid password", "validation error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            
            
            // Form1 f1 = new Form1();
            // f1.Show();
            // this.Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }


        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            tbEmail.BackColor = Color.White;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '\0')
            {
                btView.BringToFront();
                tbPassword.PasswordChar = '*';
            }
        }

        private void btView_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                btHide.BringToFront();
                tbPassword.PasswordChar = '\0';
            }
        }
    }
}