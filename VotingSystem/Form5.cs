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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void viewPartylistButton_Click(object sender, EventArgs e)
        {
            viewPartyListForm vp = new viewPartyListForm();
            this.Hide();
            vp.Show();  
        }
    }
}
