namespace VotingSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.createPartylistButton = new System.Windows.Forms.Button();
            this.viewResultButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // createPartylistButton
            // 
            this.createPartylistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createPartylistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.createPartylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPartylistButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.createPartylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPartylistButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPartylistButton.ForeColor = System.Drawing.Color.Black;
            this.createPartylistButton.Location = new System.Drawing.Point(277, 238);
            this.createPartylistButton.Name = "createPartylistButton";
            this.createPartylistButton.Size = new System.Drawing.Size(309, 42);
            this.createPartylistButton.TabIndex = 5;
            this.createPartylistButton.Text = "CREATE PARTYLIST";
            this.createPartylistButton.UseVisualStyleBackColor = false;
            this.createPartylistButton.Click += new System.EventHandler(this.createPartylistButton_Click);
            // 
            // viewResultButton
            // 
            this.viewResultButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewResultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.viewResultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewResultButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.viewResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewResultButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewResultButton.ForeColor = System.Drawing.Color.Black;
            this.viewResultButton.Location = new System.Drawing.Point(277, 299);
            this.viewResultButton.Name = "viewResultButton";
            this.viewResultButton.Size = new System.Drawing.Size(309, 42);
            this.viewResultButton.TabIndex = 6;
            this.viewResultButton.Text = "VIEW RESULT";
            this.viewResultButton.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.ForeColor = System.Drawing.Color.Transparent;
            this.logo.Location = new System.Drawing.Point(345, 25);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(178, 170);
            this.logo.TabIndex = 7;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 497);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.viewResultButton);
            this.Controls.Add(this.createPartylistButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "ADMIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPartylistButton;
        private System.Windows.Forms.Button viewResultButton;
        private System.Windows.Forms.Panel logo;
    }
}