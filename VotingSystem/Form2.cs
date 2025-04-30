using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class loginForm : Form
    {
        SqlConnection conn;
        public loginForm()
        {
            try
            {
                conn = new SqlConnection("Data Source=JENNIFER-PC\\SQLEXPRESS;Initial Catalog=VotingSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;User Instance=False");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            studentIdTb.Text = "STUDENT ID";
            passwordTb.Text = "PASSWORD";
            studentIdTb.ForeColor = Color.Gray;
            passwordTb.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(studentIdTb.Text == "" || studentIdTb.ForeColor == Color.Gray)
            {
                MessageBox.Show("STUDENT ID IS REQUIRED!");
                return;
            }
            else if(passwordTb.Text == "" || passwordTb.ForeColor == Color.Gray)
            {
                MessageBox.Show("PASSWORD IS REQUIRED!");
                return;
            }

            string studentId = studentIdTb.Text;
            string password = passwordTb.Text;

            string query = "SELECT * FROM voter WHERE studentId = '" + studentId + "'And password= '" + password +  "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            if(dataReader.HasRows == true)
            {
                MessageForm mf = new MessageForm("Login Succesfully");
                this.Hide();
            }
            else
            {
                MessageForm mf = new MessageForm("INVALID CREDENTIALS");
            }

            dataReader.Close();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm r = new registerForm();
            r.Show();
        }

        private void studentIdTb_Enter(object sender, EventArgs e)
        {
            if(studentIdTb.Text == "STUDENT ID")
            {
                studentIdTb.Text = "";
                studentIdTb.ForeColor = Color.Black;
            }
        }

        private void studentIdTb_Leave(object sender, EventArgs e)
        {
            if(studentIdTb.Text == "")
            {
                studentIdTb.Text = "STUDENT ID";
                studentIdTb.ForeColor = Color.Gray;
            }
        }

        private void passwordTb_Enter(object sender, EventArgs e)
        {
            if (passwordTb.Text == "PASSWORD")
            {
                passwordTb.Text = "";
                passwordTb.ForeColor = Color.Black;
                passwordTb.UseSystemPasswordChar = true;
            }
        }

        private void passwordTb_Leave(object sender, EventArgs e)
        {
            if (passwordTb.Text.Length == 0)
            {
                passwordTb.UseSystemPasswordChar = false;
                passwordTb.Text = "PASSWORD";
                passwordTb.ForeColor = Color.Gray;

            }
        }

        private void studentIdTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
