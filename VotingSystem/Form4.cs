using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VotingSystem
{
    public partial class MessageForm : Form
    {
        string message = "";
        public MessageForm(string message)
        {
            this.message = message;
             
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.Show();

        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            messageTb.Text = message;
            okayButton.Focus();
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void messageTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
