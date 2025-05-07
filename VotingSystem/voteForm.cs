using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VotingSystem
{
    public partial class voteForm : Form
    {
        Bitmap image = new Bitmap(@"C:\Users\Jesilo Jan\OneDrive\Desktop\Chrisia Bher\AppsDev\VotingSystem\img\jishua.jpg");
        candidate[] candidates = new candidate[2];
        FlowLayoutPanel[] flowLayoutPanels = new FlowLayoutPanel[2];
        candidate clicked;
        String[] partyList = new String[] { "CHRISIA'S PARTYLIST", "DONAL'S PARTYLIST" };
        String[] name = new String[] { "CHRISIA RAMOS", "JOHN REY DONAL" };

        public voteForm()
        {
            InitializeComponent();
        }

        private void voteForm_Load(object sender, EventArgs e)
        {
            
            candidates = new[] { new candidate(partyList[0], name[0], "PRESIDENT", image), new candidate(partyList[1], name[1], "PRESIDENT", image), new candidate("AI SOMETHING","RYAN SAGARINO","PRESIDENT", image) };

            foreach (candidate c in candidates)
            {
                this.presidentFlow.Controls.Add(c);
                c.Click += new System.EventHandler(this.candidateClick);       
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x2000000;
                return handleParams;
            }
        }

        private void candidateClick(object sender, EventArgs e)
        {
            if (clicked != null)
            {
                clicked.BackColor = Color.Transparent;
                clicked.isVoted = false;
            }

            candidate clickedCandidate = sender as candidate;
            clicked = clickedCandidate;
         
            if (clickedCandidate != null)
            {
                clickedCandidate.isVoted = true;
                clickedCandidate.BackColor = Color.Violet;
            }
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (clicked != null)
            {
                MessageForm m = new MessageForm(clicked.name.Text);
            }
            else
            {
                MessageForm m1 = new MessageForm("PLEASE VOTE");
            }

        }
    }
}
