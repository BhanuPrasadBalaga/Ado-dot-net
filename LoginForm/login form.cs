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
    }
}