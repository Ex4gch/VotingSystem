namespace VotingSystem
{
    partial class voteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(voteForm));
            this.positionLbl = new System.Windows.Forms.Label();
            this.presidentFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.centerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionLbl
            // 
            this.positionLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionLbl.BackColor = System.Drawing.Color.Transparent;
            this.positionLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.positionLbl.Font = new System.Drawing.Font("Consolas", 36F);
            this.positionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.positionLbl.Location = new System.Drawing.Point(296, -7);
            this.positionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(1059, 79);
            this.positionLbl.TabIndex = 0;
            this.positionLbl.Text = "PRESIDENT";
            this.positionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presidentFlow
            // 
            this.presidentFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.presidentFlow.AutoSize = true;
            this.presidentFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.presidentFlow.BackColor = System.Drawing.Color.Transparent;
            this.presidentFlow.Location = new System.Drawing.Point(800, 3);
            this.presidentFlow.Name = "presidentFlow";
            this.presidentFlow.Size = new System.Drawing.Size(0, 596);
            this.presidentFlow.TabIndex = 3;
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.centerPanel.AutoSize = true;
            this.centerPanel.BackColor = System.Drawing.Color.Transparent;
            this.centerPanel.ColumnCount = 1;
            this.centerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerPanel.Controls.Add(this.presidentFlow, 0, 0);
            this.centerPanel.Location = new System.Drawing.Point(21, 105);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.RowCount = 1;
            this.centerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.centerPanel.Size = new System.Drawing.Size(1600, 602);
            this.centerPanel.TabIndex = 4;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.Black;
            this.nextButton.Location = new System.Drawing.Point(617, 776);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(408, 89);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // voteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1643, 897);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.positionLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "voteForm";
            this.Text = "VOTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.voteForm_Load);
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.FlowLayoutPanel presidentFlow;
        private System.Windows.Forms.TableLayoutPanel centerPanel;
        private System.Windows.Forms.Button nextButton;
    }
}