namespace VotingSystem
{
    partial class registerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerForm));
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.studentIdTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.studentIDLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.studentIDLabel.Location = new System.Drawing.Point(200, 136);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(0, 22);
            this.studentIDLabel.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.loginLabel.Location = new System.Drawing.Point(315, 37);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(179, 43);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "REGISTER";
            // 
            // studentIdTb
            // 
            this.studentIdTb.BackColor = System.Drawing.Color.White;
            this.studentIdTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTb.ForeColor = System.Drawing.Color.Black;
            this.studentIdTb.Location = new System.Drawing.Point(271, 133);
            this.studentIdTb.Name = "studentIdTb";
            this.studentIdTb.Size = new System.Drawing.Size(272, 30);
            this.studentIdTb.TabIndex = 2;
            this.studentIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentIdTb.Enter += new System.EventHandler(this.studentIdTb_Enter);
            this.studentIdTb.Leave += new System.EventHandler(this.studentIdTb_Leave);
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.ForeColor = System.Drawing.Color.Black;
            this.passwordTb.Location = new System.Drawing.Point(271, 319);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(272, 30);
            this.passwordTb.TabIndex = 6;
            this.passwordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTb.Enter += new System.EventHandler(this.passwordTb_Enter);
            this.passwordTb.Leave += new System.EventHandler(this.passwordTb_Leave);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(271, 371);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(272, 42);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstNameTb
            // 
            this.firstNameTb.BackColor = System.Drawing.Color.White;
            this.firstNameTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTb.ForeColor = System.Drawing.Color.Black;
            this.firstNameTb.Location = new System.Drawing.Point(271, 178);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(272, 30);
            this.firstNameTb.TabIndex = 3;
            this.firstNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNameTb.Enter += new System.EventHandler(this.firstNameTb_Enter);
            this.firstNameTb.Leave += new System.EventHandler(this.firstNameTbTb_Leave);
            // 
            // lastNameTb
            // 
            this.lastNameTb.BackColor = System.Drawing.Color.White;
            this.lastNameTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTb.ForeColor = System.Drawing.Color.Black;
            this.lastNameTb.Location = new System.Drawing.Point(271, 226);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(272, 30);
            this.lastNameTb.TabIndex = 4;
            this.lastNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lastNameTb.Enter += new System.EventHandler(this.lastNameTb_Enter);
            this.lastNameTb.Leave += new System.EventHandler(this.lastNameTb_Leave);
            // 
            // emailTb
            // 
            this.emailTb.BackColor = System.Drawing.Color.White;
            this.emailTb.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.ForeColor = System.Drawing.Color.Black;
            this.emailTb.Location = new System.Drawing.Point(271, 272);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(272, 30);
            this.emailTb.TabIndex = 5;
            this.emailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTb.Enter += new System.EventHandler(this.emailTb_Enter);
            this.emailTb.Leave += new System.EventHandler(this.emailTb_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(796, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.studentIdTb);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox studentIdTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Button button1;
    }
}