using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace VotingSystem
{
    public partial class registerForm : Form
    {
        SqlConnection conn;
        public registerForm()
        {
            /*try
            {
                conn = new SqlConnection("Data Source=;Initial Catalog=VotingSystem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;User Instance=False");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }*/
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
            studentIdTb.Text = "STUDENT ID";
            firstNameTb.Text = "FIRST NAME";
            lastNameTb.Text = "LAST NAME";
            emailTb.Text = "EMAIL";
            passwordTb.Text = "PASSWORD";
            studentIdTb.ForeColor = Color.Gray;
            firstNameTb.ForeColor = Color.Gray;
            lastNameTb.ForeColor = Color.Gray;
            emailTb.ForeColor = Color.Gray;
            passwordTb.ForeColor = Color.Gray;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String firstName, lastName, email, password;
            /*int studentId;

            firstName = firstNameTb.Text;
            lastName = lastNameTb.Text;
            email = emailTb.Text;
            password = passwordTb.Text;
            studentId = int.Parse(studentIdTb.Text);
            SqlCommand cmd = new SqlCommand("insert into voter(firstName, lastName, email, password, studentId) values('"+ firstName +"','" + lastName + "','" + email + "','" + password + "','" + studentId +"');", conn);
            int i = cmd.ExecuteNonQuery();
            if (i != 0) MessageBox.Show("SAVEEE");
            else MessageBox.Show("WALAAA");*/
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
            if (studentIdTb.Text == "")
            {
                studentIdTb.Text = "STUDENT ID";
                studentIdTb.ForeColor = Color.Gray;
            }
        }

        private void firstNameTb_Enter(object sender, EventArgs e)
        {
            if (firstNameTb.Text == "FIRST NAME")
            {
                firstNameTb.Text = "";
                firstNameTb.ForeColor = Color.Black;
            }
        }

        private void firstNameTbTb_Leave(object sender, EventArgs e)
        {
            if (firstNameTb.Text == "")
            {
                firstNameTb.Text = "FIRST NAME";
                firstNameTb.ForeColor = Color.Gray;
            }
        }

        private void lastNameTb_Enter(object sender, EventArgs e)
        {
            if (lastNameTb.Text == "LAST NAME")
            {
                lastNameTb.Text = "";
                lastNameTb.ForeColor = Color.Black;
            }
        }

        private void lastNameTb_Leave(object sender, EventArgs e)
        {
            if (lastNameTb.Text == "")
            {
                lastNameTb.Text = "LAST NAME";
                lastNameTb.ForeColor = Color.Gray;
            }
        }

        private void emailTb_Enter(object sender, EventArgs e)
        {
            if (emailTb.Text == "EMAIL")
            {
                emailTb.Text = "";
                emailTb.ForeColor = Color.Black;
            }
        }

        private void emailTb_Leave(object sender, EventArgs e)
        {
            if (emailTb.Text == "")
            {
                emailTb.Text = "EMAIL";
                emailTb.ForeColor = Color.Gray;
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
                passwordTb.Text = "PASSWORD";
                passwordTb.ForeColor = Color.Gray;
                passwordTb.UseSystemPasswordChar = false;
            }
        }
    }
}
