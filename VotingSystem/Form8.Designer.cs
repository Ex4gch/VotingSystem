namespace VotingSystem
{
    partial class viewPartyListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewPartyListForm));
            this.partylistTitlePanel = new System.Windows.Forms.Panel();
            this.partylistTitleLbl = new System.Windows.Forms.Label();
            this.presidentPanel = new System.Windows.Forms.Panel();
            this.presidentPicture = new System.Windows.Forms.PictureBox();
            this.presidentLbl = new System.Windows.Forms.Label();
            this.moreInfoPanel = new System.Windows.Forms.Panel();
            this.additionalInfoLbl = new System.Windows.Forms.Label();
            this.sectionLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.infoPicture = new System.Windows.Forms.PictureBox();
            this.infoPosition = new System.Windows.Forms.Label();
            this.vicePanel = new System.Windows.Forms.Panel();
            this.vicePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caresPanel = new System.Windows.Forms.Panel();
            this.caresPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viceExPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.viceExPicture = new System.Windows.Forms.PictureBox();
            this.secretaryPanel = new System.Windows.Forms.Panel();
            this.secretaryPicture = new System.Windows.Forms.PictureBox();
            this.secretaryLbl = new System.Windows.Forms.Label();
            this.partylistTitlePanel.SuspendLayout();
            this.presidentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidentPicture)).BeginInit();
            this.moreInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture)).BeginInit();
            this.vicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vicePicture)).BeginInit();
            this.caresPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caresPicture)).BeginInit();
            this.viceExPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viceExPicture)).BeginInit();
            this.secretaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secretaryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // partylistTitlePanel
            // 
            this.partylistTitlePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partylistTitlePanel.BackColor = System.Drawing.Color.Transparent;
            this.partylistTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partylistTitlePanel.Controls.Add(this.partylistTitleLbl);
            this.partylistTitlePanel.Location = new System.Drawing.Point(341, 56);
            this.partylistTitlePanel.Name = "partylistTitlePanel";
            this.partylistTitlePanel.Size = new System.Drawing.Size(690, 56);
            this.partylistTitlePanel.TabIndex = 0;
            // 
            // partylistTitleLbl
            // 
            this.partylistTitleLbl.AutoSize = true;
            this.partylistTitleLbl.Font = new System.Drawing.Font("Consolas", 36F);
            this.partylistTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.partylistTitleLbl.Location = new System.Drawing.Point(175, -4);
            this.partylistTitleLbl.Name = "partylistTitleLbl";
            this.partylistTitleLbl.Size = new System.Drawing.Size(336, 56);
            this.partylistTitleLbl.TabIndex = 0;
            this.partylistTitleLbl.Text = "TITLE NI SYA";
            // 
            // presidentPanel
            // 
            this.presidentPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.presidentPanel.BackColor = System.Drawing.Color.Transparent;
            this.presidentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.presidentPanel.Controls.Add(this.presidentPicture);
            this.presidentPanel.Controls.Add(this.presidentLbl);
            this.presidentPanel.Location = new System.Drawing.Point(1075, 463);
            this.presidentPanel.Name = "presidentPanel";
            this.presidentPanel.Size = new System.Drawing.Size(235, 247);
            this.presidentPanel.TabIndex = 1;
            this.presidentPanel.MouseEnter += new System.EventHandler(this.presidentPanel_MouseHover);
            this.presidentPanel.MouseLeave += new System.EventHandler(this.presidentPanel_MouseLeave);
            // 
            // presidentPicture
            // 
            this.presidentPicture.Enabled = false;
            this.presidentPicture.Image = ((System.Drawing.Image)(resources.GetObject("presidentPicture.Image")));
            this.presidentPicture.Location = new System.Drawing.Point(5, 6);
            this.presidentPicture.Name = "presidentPicture";
            this.presidentPicture.Size = new System.Drawing.Size(219, 185);
            this.presidentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.presidentPicture.TabIndex = 0;
            this.presidentPicture.TabStop = false;
            // 
            // presidentLbl
            // 
            this.presidentLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.presidentLbl.Enabled = false;
            this.presidentLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.presidentLbl.Font = new System.Drawing.Font("Consolas", 15F);
            this.presidentLbl.ForeColor = System.Drawing.Color.Gray;
            this.presidentLbl.Location = new System.Drawing.Point(5, 198);
            this.presidentLbl.Name = "presidentLbl";
            this.presidentLbl.Size = new System.Drawing.Size(219, 38);
            this.presidentLbl.TabIndex = 1;
            this.presidentLbl.Text = "PRESIDENT";
            this.presidentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moreInfoPanel
            // 
            this.moreInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moreInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.moreInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moreInfoPanel.Controls.Add(this.additionalInfoLbl);
            this.moreInfoPanel.Controls.Add(this.sectionLbl);
            this.moreInfoPanel.Controls.Add(this.nameLbl);
            this.moreInfoPanel.Controls.Add(this.infoPicture);
            this.moreInfoPanel.Controls.Add(this.infoPosition);
            this.moreInfoPanel.Enabled = false;
            this.moreInfoPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moreInfoPanel.Location = new System.Drawing.Point(81, 142);
            this.moreInfoPanel.Name = "moreInfoPanel";
            this.moreInfoPanel.Size = new System.Drawing.Size(1204, 259);
            this.moreInfoPanel.TabIndex = 2;
            this.moreInfoPanel.Visible = false;
            // 
            // additionalInfoLbl
            // 
            this.additionalInfoLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.additionalInfoLbl.Enabled = false;
            this.additionalInfoLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additionalInfoLbl.Font = new System.Drawing.Font("Consolas", 15F);
            this.additionalInfoLbl.ForeColor = System.Drawing.Color.Black;
            this.additionalInfoLbl.Location = new System.Drawing.Point(605, 16);
            this.additionalInfoLbl.Name = "additionalInfoLbl";
            this.additionalInfoLbl.Size = new System.Drawing.Size(586, 230);
            this.additionalInfoLbl.TabIndex = 6;
            this.additionalInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionLbl
            // 
            this.sectionLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.sectionLbl.Enabled = false;
            this.sectionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionLbl.Font = new System.Drawing.Font("Consolas", 15F);
            this.sectionLbl.ForeColor = System.Drawing.Color.Black;
            this.sectionLbl.Location = new System.Drawing.Point(278, 208);
            this.sectionLbl.Name = "sectionLbl";
            this.sectionLbl.Size = new System.Drawing.Size(319, 38);
            this.sectionLbl.TabIndex = 5;
            this.sectionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.nameLbl.Enabled = false;
            this.nameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLbl.Font = new System.Drawing.Font("Consolas", 15F);
            this.nameLbl.ForeColor = System.Drawing.Color.Black;
            this.nameLbl.Location = new System.Drawing.Point(278, 164);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(319, 38);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPicture
            // 
            this.infoPicture.Location = new System.Drawing.Point(8, 16);
            this.infoPicture.Name = "infoPicture";
            this.infoPicture.Size = new System.Drawing.Size(262, 230);
            this.infoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPicture.TabIndex = 3;
            this.infoPicture.TabStop = false;
            // 
            // infoPosition
            // 
            this.infoPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.infoPosition.Enabled = false;
            this.infoPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoPosition.Font = new System.Drawing.Font("Consolas", 15F);
            this.infoPosition.ForeColor = System.Drawing.Color.Black;
            this.infoPosition.Location = new System.Drawing.Point(278, 16);
            this.infoPosition.Name = "infoPosition";
            this.infoPosition.Size = new System.Drawing.Size(319, 143);
            this.infoPosition.TabIndex = 2;
            this.infoPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vicePanel
            // 
            this.vicePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vicePanel.BackColor = System.Drawing.Color.Transparent;
            this.vicePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vicePanel.Controls.Add(this.vicePicture);
            this.vicePanel.Controls.Add(this.label1);
            this.vicePanel.Location = new System.Drawing.Point(313, 463);
            this.vicePanel.Name = "vicePanel";
            this.vicePanel.Size = new System.Drawing.Size(235, 247);
            this.vicePanel.TabIndex = 3;
            this.vicePanel.MouseEnter += new System.EventHandler(this.vicePanel_MouseEnter);
            this.vicePanel.MouseLeave += new System.EventHandler(this.vicePanel_MouseLeave);
            // 
            // vicePicture
            // 
            this.vicePicture.Enabled = false;
            this.vicePicture.Image = ((System.Drawing.Image)(resources.GetObject("vicePicture.Image")));
            this.vicePicture.Location = new System.Drawing.Point(5, 6);
            this.vicePicture.Name = "vicePicture";
            this.vicePicture.Size = new System.Drawing.Size(219, 185);
            this.vicePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vicePicture.TabIndex = 0;
            this.vicePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.label1.Enabled = false;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(5, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "VICE PRESIDENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caresPanel
            // 
            this.caresPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caresPanel.BackColor = System.Drawing.Color.Transparent;
            this.caresPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.caresPanel.Controls.Add(this.caresPicture);
            this.caresPanel.Controls.Add(this.label2);
            this.caresPanel.Location = new System.Drawing.Point(567, 463);
            this.caresPanel.Name = "caresPanel";
            this.caresPanel.Size = new System.Drawing.Size(235, 247);
            this.caresPanel.TabIndex = 5;
            this.caresPanel.MouseEnter += new System.EventHandler(this.caresPanel_MouseEnter);
            this.caresPanel.MouseLeave += new System.EventHandler(this.caresPanel_MouseLeave);
            // 
            // caresPicture
            // 
            this.caresPicture.Enabled = false;
            this.caresPicture.Image = ((System.Drawing.Image)(resources.GetObject("caresPicture.Image")));
            this.caresPicture.Location = new System.Drawing.Point(5, 6);
            this.caresPicture.Name = "caresPicture";
            this.caresPicture.Size = new System.Drawing.Size(219, 185);
            this.caresPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caresPicture.TabIndex = 0;
            this.caresPicture.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.label2.Enabled = false;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "CARES REP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viceExPanel
            // 
            this.viceExPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viceExPanel.BackColor = System.Drawing.Color.Transparent;
            this.viceExPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viceExPanel.Controls.Add(this.label3);
            this.viceExPanel.Controls.Add(this.viceExPicture);
            this.viceExPanel.Location = new System.Drawing.Point(821, 463);
            this.viceExPanel.Name = "viceExPanel";
            this.viceExPanel.Size = new System.Drawing.Size(235, 247);
            this.viceExPanel.TabIndex = 4;
            this.viceExPanel.MouseEnter += new System.EventHandler(this.viceExPanel_MouseEnter);
            this.viceExPanel.MouseLeave += new System.EventHandler(this.viceExPanel_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.label3.Enabled = false;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Consolas", 15F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(5, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "VICE PRESIDENT - EX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viceExPicture
            // 
            this.viceExPicture.Enabled = false;
            this.viceExPicture.Image = ((System.Drawing.Image)(resources.GetObject("viceExPicture.Image")));
            this.viceExPicture.Location = new System.Drawing.Point(5, 6);
            this.viceExPicture.Name = "viceExPicture";
            this.viceExPicture.Size = new System.Drawing.Size(219, 185);
            this.viceExPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viceExPicture.TabIndex = 0;
            this.viceExPicture.TabStop = false;
            // 
            // secretaryPanel
            // 
            this.secretaryPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.secretaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.secretaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secretaryPanel.Controls.Add(this.secretaryPicture);
            this.secretaryPanel.Controls.Add(this.secretaryLbl);
            this.secretaryPanel.Location = new System.Drawing.Point(59, 463);
            this.secretaryPanel.Name = "secretaryPanel";
            this.secretaryPanel.Size = new System.Drawing.Size(235, 247);
            this.secretaryPanel.TabIndex = 6;
            this.secretaryPanel.MouseEnter += new System.EventHandler(this.secretaryPanel_MouseEnter);
            this.secretaryPanel.MouseLeave += new System.EventHandler(this.secretaryPanel_MouseLeave);
            // 
            // secretaryPicture
            // 
            this.secretaryPicture.Enabled = false;
            this.secretaryPicture.Image = ((System.Drawing.Image)(resources.GetObject("secretaryPicture.Image")));
            this.secretaryPicture.Location = new System.Drawing.Point(5, 6);
            this.secretaryPicture.Name = "secretaryPicture";
            this.secretaryPicture.Size = new System.Drawing.Size(219, 185);
            this.secretaryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secretaryPicture.TabIndex = 0;
            this.secretaryPicture.TabStop = false;
            // 
            // secretaryLbl
            // 
            this.secretaryLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(182)))), ((int)(((byte)(75)))));
            this.secretaryLbl.Enabled = false;
            this.secretaryLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secretaryLbl.Font = new System.Drawing.Font("Consolas", 15F);
            this.secretaryLbl.ForeColor = System.Drawing.Color.Gray;
            this.secretaryLbl.Location = new System.Drawing.Point(5, 198);
            this.secretaryLbl.Name = "secretaryLbl";
            this.secretaryLbl.Size = new System.Drawing.Size(219, 38);
            this.secretaryLbl.TabIndex = 1;
            this.secretaryLbl.Text = "SECRETARY";
            this.secretaryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewPartyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1358, 749);
            this.Controls.Add(this.secretaryPanel);
            this.Controls.Add(this.moreInfoPanel);
            this.Controls.Add(this.presidentPanel);
            this.Controls.Add(this.partylistTitlePanel);
            this.Controls.Add(this.viceExPanel);
            this.Controls.Add(this.caresPanel);
            this.Controls.Add(this.vicePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewPartyListForm";
            this.Text = "PARTY LISTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.viewPartyListForm_Load);
            this.partylistTitlePanel.ResumeLayout(false);
            this.partylistTitlePanel.PerformLayout();
            this.presidentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presidentPicture)).EndInit();
            this.moreInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPicture)).EndInit();
            this.vicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vicePicture)).EndInit();
            this.caresPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caresPicture)).EndInit();
            this.viceExPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viceExPicture)).EndInit();
            this.secretaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secretaryPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel partylistTitlePanel;
        private System.Windows.Forms.Label partylistTitleLbl;
        private System.Windows.Forms.Panel presidentPanel;
        private System.Windows.Forms.PictureBox presidentPicture;
        private System.Windows.Forms.Label presidentLbl;
        private System.Windows.Forms.Panel moreInfoPanel;
        private System.Windows.Forms.PictureBox infoPicture;
        private System.Windows.Forms.Label infoPosition;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label sectionLbl;
        private System.Windows.Forms.Label additionalInfoLbl;
        private System.Windows.Forms.Panel vicePanel;
        private System.Windows.Forms.PictureBox vicePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel caresPanel;
        private System.Windows.Forms.PictureBox caresPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel viceExPanel;
        private System.Windows.Forms.PictureBox viceExPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel secretaryPanel;
        private System.Windows.Forms.PictureBox secretaryPicture;
        private System.Windows.Forms.Label secretaryLbl;
    }
}