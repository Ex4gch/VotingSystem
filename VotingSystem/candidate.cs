using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.Properties;

namespace VotingSystem
{
    internal class candidate: Panel
    {
        Label partylist = new Label();
        public Label name = new Label();
        Label position = new Label();
        PictureBox picture = new PictureBox();
        public bool isVoted = false;

        public candidate(string partylist, string name, string position, Image img)
        { 
            this.partylist.Text = partylist;
            this.name.Text = name;
            this.position.Text = position;
            this.picture.Image = img;

            this.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(3, 3);
            this.Margin = new Padding(10);
            this.Size = new System.Drawing.Size(305, 391);
            this.Cursor = System.Windows.Forms.Cursors.Hand;

            //partyList
            this.partylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.partylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.partylist.Font = new System.Drawing.Font("Consolas", 15F);
            this.partylist.ForeColor = System.Drawing.Color.Black;
            this.partylist.Location = new System.Drawing.Point(4, 4);
            this.partylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partylist.Size = new System.Drawing.Size(292, 47);
            this.partylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //name
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.Font = new System.Drawing.Font("Consolas", 15F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(4, 337);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Size = new System.Drawing.Size(292, 47);
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //picture
            this.picture.Location = new System.Drawing.Point(4, 54);
            this.picture.Size = new System.Drawing.Size(292, 280);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.Enabled = false;
            this.picture.TabStop = false;

            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();

            this.Controls.Add(this.partylist);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.name);
        }
    }

}
