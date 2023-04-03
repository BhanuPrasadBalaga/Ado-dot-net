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
    public partial class Form1 : Form
    {
        private Font smallFont = new Font("Arial", 12);
        public Form1()
        {
            InitializeComponent();
            label4.Font = smallFont;
            label2.Font = smallFont;
            label3.Font = smallFont;
            label5.Font = smallFont;
            label6.Font = smallFont;
        }
        
        private void btRegister_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;

            
            
            if (firstName == "")
            {
                tbFirstName.BackColor = Color.GreenYellow;
                MessageBox.Show("Please enter your first name", " Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbFirstName.Focus();
            }
            else if (lastName == "")
            {
                tbLastName.BackColor = Color.GreenYellow;
                MessageBox.Show("Please enter your last name", " Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLastName.Focus();
            }
            else if (email == "")
            {
                tbEmail.BackColor = Color.GreenYellow;
                MessageBox.Show("Please enter your email address", " Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbEmail.Focus();
            }
            else if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address");
                
            }
            else if (password == "")
            {
                tbPassword.BackColor = Color.GreenYellow;
                MessageBox.Show("Please enter password"," Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
            }
            else if (password.Length < 8)
            {
                tbPassword.BackColor = Color.GreenYellow;
                MessageBox.Show("Password should have 8 characters length"," Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();   
            }
            else if (password != confirmPassword)
            {
                tbConfirmPassword.BackColor = Color.GreenYellow;
                MessageBox.Show("Passwords do not match:"," Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbConfirmPassword.Focus();
            }
            else
            {
                string connectionString = "server=localhost;user=root;database=bhanudb;port=3306;password=Prasad$289";
                MySqlConnection connection = new MySqlConnection(connectionString);
              
                
                using (MySqlCommand cmd =
                       new MySqlCommand(
                           $"INSERT INTO user(firstName, lastName, email, password, confirmPassword) VALUES('{tbFirstName.Text}','{tbLastName.Text}','{tbEmail.Text}', '{tbPassword.Text}','{tbConfirmPassword.Text}')",
                           connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Thank you for regestering!");
                login_form  f2 = new login_form ();  
                f2.Show();  
                this.Hide();
                //this.Close();
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            tbFirstName.BackColor = Color.White;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            login_form f2 = new login_form();
            f2.Show();
            this.Close();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            tbLastName.BackColor = Color.White;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            tbEmail.BackColor = Color.White;
        }
        
        private void tbConfirmPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tbConfirmPassword.BackColor = Color.White;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
        }


        private void btUnhide_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
            {
                btHide.BringToFront();
                tbPassword.PasswordChar = '\0';
            }
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '\0')
            {
                btUnhide.BringToFront();
                tbPassword.PasswordChar = '*';
            }
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


        private void btViewPwd_Click(object sender, EventArgs e)
        {
            if (tbConfirmPassword.PasswordChar == '*')
            {
                btHidePwd.BringToFront();
                tbConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btHidePwd_Click(object sender, EventArgs e)
        {
            if (tbConfirmPassword.PasswordChar == '\0')
            {
                btViewPwd.BringToFront();
                tbConfirmPassword.PasswordChar = '*';
            }
        }
    }
}