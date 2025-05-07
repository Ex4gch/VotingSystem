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
    public partial class viewPartyListForm : Form
    {
        Point p;
        Color c;
        Panel[] panels = new Panel[3];
        int i = 0;
        public void enter(Panel panel, string name, string section, string info, string position, Image img)
        {
            bioPanel.Visible = false;
            infoPosition.Text = position;
            nameLbl.Text = name;
            sectionLbl.Text = section;
            additionalInfoLbl.Text = info;
            infoPicture.Image = img;

            p = panel.Location;
            panel.Location = new Point(panel.Location.X, panel.Location.Y - 20);
        }

        public void leave(Panel panel)
        {
            panel.Location = p;
            moreInfoPanel.Visible = false;
            bioPanel.Visible = true;
        }

        public viewPartyListForm()
        {
            InitializeComponent();
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

        private void presidentPanel_MouseHover(object sender, EventArgs e)
        {
            moreInfoPanel.Visible = true;
            enter(presidentPanel,"DANIEL ISIDORE KANE MAPANO", "BSIT-2A", "WHAT THE HELL IS THIS SHIT\nDLE RA MAG MATTER ANG GRADE", "PRESIDENT", presidentPicture.Image);
        }

        private void presidentPanel_MouseLeave(object sender, EventArgs e)
        {
            leave(presidentPanel);
        }

        private void viewPartyListForm_Load(object sender, EventArgs e)
        {
            additionalInfoLbl.MaximumSize = new Size(586, 304);

            panels = new Panel[] { firstPanel, secondPanel, thirdPanel };
        }

        private void vicePanel_MouseEnter(object sender, EventArgs e)
        {
            moreInfoPanel.Visible = true;
            enter(vicePanel, "AYN LOREBELLE CAVAN", "BSIT-2A", "I LOVE JADE", "VICE PRESIDENT\nINTERNAL", vicePicture.Image);

        }

        private void vicePanel_MouseLeave(object sender, EventArgs e)
        {
            leave(vicePanel);
        }

        private void viceExPanel_MouseEnter(object sender, EventArgs e)
        {
            moreInfoPanel.Visible = true;
            enter(viceExPanel,"MARY JASMIN OMPAD", "BSIT-2A", "I LOVE JOHN CARLO", "VICE PRESIDENT\nEXTERNAL", viceExPicture.Image);

        }

        private void viceExPanel_MouseLeave(object sender, EventArgs e)
        {
            leave(viceExPanel);
        }

        private void caresPanel_MouseEnter(object sender, EventArgs e)
        {
            moreInfoPanel.Visible = true;
            enter(treasurerPanel,"JOSHUA INOC", "BSIT-2A", "LOVELYN****", "CARES\nREPRESENTATIVE", treasurerPicture.Image);

        }

        private void caresPanel_MouseLeave(object sender, EventArgs e)
        {
            leave(treasurerPanel);
        }

        private void secretaryPanel_MouseEnter(object sender, EventArgs e)
        {
            moreInfoPanel.Visible = true;
            enter(secretaryPanel, "JOHN CARLO BORGUETTA", "BSIT-2A", "I LOVE JASMIN", "SECRETARY", secretaryPicture.Image);
        }

        private void secretaryPanel_MouseLeave(object sender, EventArgs e)
        {
            leave(secretaryPanel);
        }
        private void nextnextButton_MouseEnter(object sender, EventArgs e)
        {
            c = nextnextButton.ForeColor;
            p = nextnextButton.Location;
            nextnextButton.ForeColor = Color.LightGoldenrodYellow;
            nextnextButton.Location = new Point(nextnextButton.Location.X + 4, nextnextButton.Location.Y);
        }

        private void nextnextButton_MouseLeave(object sender, EventArgs e)
        {
            nextnextButton.ForeColor = c;
            nextnextButton.Location = p;
        }

        private void previousButton_MouseEnter(object sender, EventArgs e)
        {
            c = previousButton.ForeColor;
            p = previousButton.Location;
            previousButton.ForeColor = Color.LightGoldenrodYellow;
            previousButton.Location = new Point(previousButton.Location.X - 4, previousButton.Location.Y);
        }

        private void previousButton_MouseLeave(object sender, EventArgs e)
        {
            previousButton.ForeColor = c;
            previousButton.Location = p;
        }
        private void nextnextButton_Click(object sender, EventArgs e)
        {
            panels[i].Visible = false;
            i++;
            if (i == 3) i = 0;
            panels[i].Visible = true;

            this.Invalidate();
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            panels[i].Visible = false;
            i--;
            if (i < 0) i = 2;
            panels[i].Visible = true;

            this.Invalidate();
        }
    }
}
