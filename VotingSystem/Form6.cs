using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Tracing;


namespace VotingSystem
{
    public partial class createPartyListForm : Form
    {
        Color c;
        Point p;
        int i = 0;
        Panel[] panels = new Panel[13];

        public void IsEnter(TextBox c, String s)
        {
            if(c.Text == s)
            {
                c.Text = "";
                c.ForeColor = Color.Black;
            }
        }

        public void IsLeave(TextBox c, String s)
        {
            if(c.Text.Length == 0)
            {
                c.Text = s;
                c.ForeColor = Color.Gray;
            }
        }

        public void additionalIsLeave(System.Windows.Forms.Label label, RichTextBox textbox)
        {
            if (textbox.Text.Length == 0) label.Text = "ADDITIONAL INFORMATION";
        }

        public void photoIsLeave(System.Windows.Forms.Label label, PictureBox pictureBox)
        {
            if(pictureBox == null) label.Text = "ADD PHOTO";
        }

        public void pickPhoto(PictureBox pictureBox, System.Windows.Forms.Label label)
        {
            openFileDialog1.Title = "Select an image";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)| *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                pictureBox.Image = new Bitmap(openFileDialog1.FileName);
                label.Text = "";
            }
            else
            {
                
            }
        }
        public createPartyListForm()
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

        private void backButton_MouseHover(object sender, EventArgs e)
        {
            c = backButton.ForeColor;
            p = backButton.Location;
            backButton.ForeColor = Color.LightGoldenrodYellow;
            backButton.Location = new Point(backButton.Location.X - 2, backButton.Location.Y);
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            backButton.ForeColor = c;
            backButton.Location = p;
        }

        private void createPartyListForm_Load(object sender, EventArgs e)
        {
            candidatesPanel.Hide();
            partyListNameTB.Text = "PARTY LIST NAME";
            presidentNameTb.Text = "NAME";
            presidentSectionTb.Text = "YEAR & SECTION";
            viceNameTb.Text = "NAME";
            viceSectionTb.Text = "YEAR & SECTION";
            viceExNameTb.Text = "NAME";
            viceExSectionTb.Text = "YEAR & SECTION";
            secretaryNameTb.Text = "NAME";
            secretarySectionTb.Text = "YEAR & SECTION";
            presidentNameTb.ForeColor = Color.Gray;
            partyListNameTB.ForeColor = Color.Gray;
            presidentSectionTb.ForeColor = Color.Gray;
            viceNameTb.ForeColor = Color.Gray;
            viceSectionTb.ForeColor = Color.Gray;
            viceExNameTb.ForeColor = Color.Gray;
            viceExSectionTb.ForeColor = Color.Gray;

        }

        #region PartyList Name
        private void partyListNameTB_Enter(object sender, EventArgs e)
        {
            if (partyListNameTB.Text == "PARTY LIST NAME")
            {
                partyListNameTB.Text = "";
                partyListNameTB.ForeColor = Color.Black;
            }
        }

        private void partyListNameTB_Leave(object sender, EventArgs e)
        {
            if (partyListNameTB.Text.Length == 0)
            {
                partyListNameTB.Text = "PARTY LIST NAME";
                partyListNameTB.ForeColor = Color.Gray;
            }
        }

        private void informationTb_Enter(object sender, EventArgs e)
        {
            informationLbl.Text = "";
        }

        private void informationTb_Leave(object sender, EventArgs e)
        {
            if(informationTb.Text == "")
            {
                informationLbl.Text = "INFORMATION";
            }
        }

        #endregion

        private void nextButton_Click(object sender, EventArgs e)
        {
            panels = new Panel[] { presidentPanel, vicePresidentPanel, viceExPanel, secretaryPanel, treasurerPanel, auditorPanel, pioPanel,
                                    firstyearPanel, secondyearPanel, thirdyearPanel, fourthyearPanel, caresPanel, academicPanel };

            foreach(Panel p in panels)
            {
                p.Visible = false;
            }

            panels[0].Visible = true;
            informationPanel.Hide();
            candidatesPanel.Show();
        }


#region President Panel
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pickPhoto(presidentPicture, presidentAddPhotolbl);
        }

        private void presidentAddPhotolbl_Leave(object sender, EventArgs e)
        {
            photoIsLeave(presidentAddPhotolbl, presidentPicture);
        }

        private void presidentNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(presidentNameTb, "NAME");
        }

        private void presidentNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(presidentNameTb, "NAME");
        }

        private void sectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(presidentSectionTb, "YEAR & SECTION");
        }

        private void sectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(presidentSectionTb, "YEAR & SECTION");
        }

        private void additionalTb_Enter(object sender, EventArgs e)
        {
            presidentInfoLbl.Text = "";
        }

        private void additionalTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(presidentInfoLbl, presidentAdditionalTb);
        }

        #endregion
#region VicePresident Panel
        private void vicePicture_Click(object sender, EventArgs e)
        {
            pickPhoto(vicePicture, vicePictureLbl);
        }

        private void vicePictureLbl_Leave(object sender, EventArgs e)
        {
            photoIsLeave(vicePictureLbl, vicePicture);
        }

        private void viceNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(viceNameTb, "NAME");
        }

        private void viceNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(viceNameTb, "NAME");
        }

        private void viceSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(viceSectionTb, "YEAR & SECTION");
        }

        private void viceSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(viceSectionTb, "YEAR & SECTION");
        }

        private void viceInfoTb_Enter(object sender, EventArgs e)
        {
            viceInfoLbl.Text = "";
        }

        private void viceInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(viceInfoLbl, viceInfoTb);
        }

        #endregion
#region ViceExPresident Panel
        private void viceExPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(viceExPicture, viceExPictureLbl);
        }

        private void viceExPictureLbl_Leave(object sender, EventArgs e)
        {
            photoIsLeave(viceExPictureLbl, viceExPicture);
        }

        private void viceExNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(viceExNameTb, "NAME");
        }

        private void viceEXNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(viceExNameTb, "NAME");
        }

        private void viceExSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(viceExSectionTb, "YEAR & SECTION");
        }

        private void viceExSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(viceExSectionTb, "YEAR & SECTION");
        }

        private void viceExInfoTb_Enter(object sender, EventArgs e)
        {
            viceExInfoLbl.Text = "";
        }

        private void viceExInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(viceExInfoLbl, viceExInfoTb);
        }

        #endregion
#region Secretary Panel
        private void secretaryPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(secretaryPicture, secretaryPictureLbl);
        }

        private void secretaryPictureLbl_Leave(object sender, EventArgs e)
        {
            photoIsLeave(secretaryPictureLbl, secretaryPicture);
        }

        private void secretaryNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(secretaryNameTb, "NAME");
        }

        private void secretaryNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(secretaryNameTb, "NAME");
        }

        private void secretarySectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(secretarySectionTb, "YEAR & SECTION");
        }

        private void secretarySectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(secretarySectionTb, "YEAR & SECTION");
        }

        private void secretaryInfoTb_Enter(object sender, EventArgs e)
        {
            secretaryInfoLbl.Text = "";
        }

        private void secretaryInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(secretaryInfoLbl, secretaryInfoTb);
        }

        #endregion
#region Treasurer Panel
        private void treasurerPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(treasurerPicture, treasurerPictureLbl);
        }

        private void treasurerNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(treasurerNameTb, "NAME");
        }

        private void treasurerNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(treasurerNameTb, "NAME");
        }

        private void treasurerSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(treasurerSectionTb, "YEAR & SECTION");
        }

        private void treasurerSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(treasurerSectionTb, "YEAR & SECTION");
        }

        private void treasurerInfoTb_Enter(object sender, EventArgs e)
        {
            treasurerInfoLbl.Text = "";
        }

        private void treasurerInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(treasurerInfoLbl, treasurerInfoTb);
        }

        #endregion
#region Auditor Panel
        private void auditorPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(auditorPicture, auditorPictureLbl);
        }

        private void auditorNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(auditorNameTb, "NAME");
        }

        private void auditorNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(auditorNameTb, "NAME");
        }

        private void auditorSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(auditorSectionTb, "YEAR & SECTION");
        }

        private void auditorSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(auditorSectionTb, "YEAR & SECTION");
        }

        private void auditorInfoTb_Enter(object sender, EventArgs e)
        {
            auditorInfoLbl.Text = "";
        }

        private void auditorInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(auditorInfoLbl, auditorInfoTb);
        }

        #endregion
#region PIO Panel
        private void pioPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(pioPicture, pioPictureLbl);
        }

        private void pioNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(pioNameTb, "NAME");
        }

        private void pioNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(pioNameTb, "NAME");
        }

        private void pioSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(pioSectionTb, "YEAR & SECTION");
        }

        private void pioSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(pioSectionTb, "YEAR & SECTION");
        }

        private void pioInfoTb_Enter(object sender, EventArgs e)
        {
            pioInfoLbl.Text = "";
        }

        private void pioInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(pioInfoLbl, pioInfoTb);
        }

        #endregion
#region First Year Panel
        private void firstyearPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(firstyearPicture, firstyearPictureLbl);
        }

        private void firstyearNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(firstyearNameTb, "NAME");
        }

        private void firstyearNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(firstyearNameTb, "NAME");
        }

        private void firstyearSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(firstyearSectionTb, "YEAR & SECTION");
        }

        private void firstyearSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(firstyearSectionTb, "YEAR & SECTION");
        }

        private void firstyearInfoTb_Enter(object sender, EventArgs e)
        {
            firstyearInfoLbl.Text = "";
        }

        private void firstyearInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(firstyearInfoLbl, firstyearInfoTb);
        }

        #endregion
#region Second Year Panel
        private void secondyearPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(secondyearPicture, secondyearPictureLbl);
        }

        private void secondyearNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(secondyearNameTb, "NAME");
        }

        private void secondyearNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(secondyearNameTb, "NAME");
        }

        private void secondyearSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(secondyearSectionTb, "YEAR & SECTION");
        }

        private void secondyearSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(secondyearSectionTb, "YEAR & SECTION");
        }

        private void secondyearInfoTb_Enter(object sender, EventArgs e)
        {
            secondyearInfoLbl.Text = "";
        }

        private void secondyearInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(secondyearInfoLbl, secondyearInfoTb);
        }

        #endregion
#region Third Year Panel
        private void thirdyearPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(thirdyearPicture, thirdyearPictureLbl);
        }

        private void thirdyearNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(thirdyearNameTb, "NAME");
        }

        private void thirdyearNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(thirdyearNameTb, "NAME");
        }

        private void thirdyearSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(thirdyearSectionTb, "YEAR & SECTION");
        }

        private void thirdyearSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(thirdyearSectionTb, "YEAR & SECTION");
        }

        private void thirdyearInfoTb_Enter(object sender, EventArgs e)
        {
            thirdyearInfoLbl.Text = "";
        }

        private void thirdyearInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(thirdyearInfoLbl, thirdyearInfoTb);
        }

        #endregion
#region Fourth Year Panel
        private void fourthyearPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(fourthyearPicture, fourthyearPictureLbl);
        }

        private void fourthyearNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(fourthyearNameTb, "NAME");
        }

        private void fourthyearNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(fourthyearNameTb, "NAME");
        }

        private void fourthyearSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(fourthyearSectionTb, "YEAR & SECTION");
        }

        private void fourthyearSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(fourthyearSectionTb, "YEAR & SECTION");
        }

        private void fourthyearInfoTb_Enter(object sender, EventArgs e)
        {
            fourthyearInfoLbl.Text = "";
        }

        private void fourthyearInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(fourthyearInfoLbl, fourthyearInfoTb);
        }

        #endregion
#region Cares Panel
        private void caresPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(caresPicture, caresPictureLbl);
        }

        private void caresNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(caresNameTb, "NAME");
        }

        private void caresNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(caresNameTb, "NAME");
        }

        private void caresSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(caresSectionTb, "YEAR & SECTION");
        }

        private void caresSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(caresSectionTb, "YEAR & SECTION");
        }

        private void caresInfoTb_Enter(object sender, EventArgs e)
        {
            caresInfoLbl.Text = "";
        }

        private void caresInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(caresInfoLbl, caresInfoTb);
        }

        #endregion
#region Academice Panel
        private void academicPicture_Click(object sender, EventArgs e)
        {
            pickPhoto(academicPicture, academicPictureLbl);
        }

        private void academicNameTb_Enter(object sender, EventArgs e)
        {
            IsEnter(academicNameTb, "NAME");
        }

        private void academicNameTb_Leave(object sender, EventArgs e)
        {
            IsLeave(academicNameTb, "NAME");
        }

        private void academicSectionTb_Enter(object sender, EventArgs e)
        {
            IsEnter(academicSectionTb, "YEAR & SECTION");
        }

        private void academicSectionTb_Leave(object sender, EventArgs e)
        {
            IsLeave(academicSectionTb, "YEAR & SECTION");
        }

        private void academicInfoTb_Enter(object sender, EventArgs e)
        {
            academicInfoLbl.Text = "";
        }

        private void academicInfoTb_Leave(object sender, EventArgs e)
        {
            additionalIsLeave(academicInfoLbl, academicInfoTb);
        }

        #endregion

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
            if (i == 13) i = 0;
            panels[i].Visible = true;

            this.Invalidate();
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            panels[i].Visible = false;
            i--;
            if (i < 0) i = 12;
            panels[i].Visible = true;

            this.Invalidate();
        }

    }
}
