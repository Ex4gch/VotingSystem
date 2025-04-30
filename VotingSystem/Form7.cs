using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void createPartylistButton_Click(object sender, EventArgs e)
        {
            Form f = new createPartyListForm();
            f.Show();
            this.Hide();
           
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
