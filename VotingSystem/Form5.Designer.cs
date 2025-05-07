namespace VotingSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.viewPartylistButton = new System.Windows.Forms.Button();
            this.castVoteButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // viewPartylistButton
            // 
            this.viewPartylistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewPartylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.viewPartylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPartylistButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.viewPartylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPartylistButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPartylistButton.ForeColor = System.Drawing.Color.Black;
            this.viewPartylistButton.Location = new System.Drawing.Point(369, 293);
            this.viewPartylistButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewPartylistButton.Name = "viewPartylistButton";
            this.viewPartylistButton.Size = new System.Drawing.Size(412, 52);
            this.viewPartylistButton.TabIndex = 5;
            this.viewPartylistButton.Text = "VIEW PARTYLIST";
            this.viewPartylistButton.UseVisualStyleBackColor = false;
            this.viewPartylistButton.Click += new System.EventHandler(this.viewPartylistButton_Click);
            // 
            // castVoteButton
            // 
            this.castVoteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.castVoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.castVoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.castVoteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.castVoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.castVoteButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castVoteButton.ForeColor = System.Drawing.Color.Black;
            this.castVoteButton.Location = new System.Drawing.Point(369, 368);
            this.castVoteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.castVoteButton.Name = "castVoteButton";
            this.castVoteButton.Size = new System.Drawing.Size(412, 52);
            this.castVoteButton.TabIndex = 6;
            this.castVoteButton.Text = "CAST VOTE";
            this.castVoteButton.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.ForeColor = System.Drawing.Color.Transparent;
            this.logo.Location = new System.Drawing.Point(460, 31);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(237, 209);
            this.logo.TabIndex = 7;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 612);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.castVoteButton);
            this.Controls.Add(this.viewPartylistButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeForm";
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewPartylistButton;
        private System.Windows.Forms.Button castVoteButton;
        private System.Windows.Forms.Panel logo;
    }
}