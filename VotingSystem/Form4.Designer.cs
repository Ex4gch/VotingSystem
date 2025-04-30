namespace VotingSystem
{
    partial class MessageForm
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
            this.okayButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageTb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okayButton
            // 
            this.okayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.okayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.okayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okayButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.okayButton.Location = new System.Drawing.Point(121, 150);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(107, 41);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OKAY";
            this.okayButton.UseVisualStyleBackColor = false;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(25)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 30);
            this.panel1.TabIndex = 1;
            // 
            // messageTb
            // 
            this.messageTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(25)))), ((int)(((byte)(89)))));
            this.messageTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageTb.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTb.ForeColor = System.Drawing.Color.White;
            this.messageTb.Location = new System.Drawing.Point(12, 30);
            this.messageTb.Multiline = true;
            this.messageTb.Name = "messageTb";
            this.messageTb.ReadOnly = true;
            this.messageTb.Size = new System.Drawing.Size(321, 97);
            this.messageTb.TabIndex = 0;
            this.messageTb.TabStop = false;
            this.messageTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.messageTb.TextChanged += new System.EventHandler(this.messageTb_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(25)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.messageTb);
            this.panel2.Controls.Add(this.okayButton);
            this.panel2.Location = new System.Drawing.Point(17, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 209);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 5);
            this.panel3.TabIndex = 2;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(380, 240);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}