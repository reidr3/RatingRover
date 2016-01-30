namespace RatingRover
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.AnonymousEntryLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.enterBirthYearLabel = new System.Windows.Forms.Label();
            this.birthYearText = new System.Windows.Forms.TextBox();
            this.AnonymousButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.VerticalSeperaterBevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(168, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Rating Rover";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginLabel.Location = new System.Drawing.Point(50, 126);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(60, 25);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // AnonymousEntryLabel
            // 
            this.AnonymousEntryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AnonymousEntryLabel.AutoSize = true;
            this.AnonymousEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AnonymousEntryLabel.Location = new System.Drawing.Point(404, 126);
            this.AnonymousEntryLabel.Name = "AnonymousEntryLabel";
            this.AnonymousEntryLabel.Size = new System.Drawing.Size(170, 25);
            this.AnonymousEntryLabel.TabIndex = 2;
            this.AnonymousEntryLabel.Text = "Anonymous Login";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(50, 191);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(50, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameText
            // 
            this.userNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameText.Location = new System.Drawing.Point(175, 191);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(100, 20);
            this.userNameText.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.Location = new System.Drawing.Point(175, 262);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // enterBirthYearLabel
            // 
            this.enterBirthYearLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enterBirthYearLabel.AutoSize = true;
            this.enterBirthYearLabel.Location = new System.Drawing.Point(416, 198);
            this.enterBirthYearLabel.Name = "enterBirthYearLabel";
            this.enterBirthYearLabel.Size = new System.Drawing.Size(147, 13);
            this.enterBirthYearLabel.TabIndex = 7;
            this.enterBirthYearLabel.Text = "Please enter your year of birth";
            // 
            // birthYearText
            // 
            this.birthYearText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.birthYearText.Location = new System.Drawing.Point(466, 255);
            this.birthYearText.Name = "birthYearText";
            this.birthYearText.Size = new System.Drawing.Size(55, 20);
            this.birthYearText.TabIndex = 8;
            this.birthYearText.TextChanged += new System.EventHandler(this.birthYearText_TextChanged);
            this.birthYearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birthYearText_KeyPress);
            // 
            // AnonymousButton
            // 
            this.AnonymousButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AnonymousButton.Location = new System.Drawing.Point(458, 326);
            this.AnonymousButton.Name = "AnonymousButton";
            this.AnonymousButton.Size = new System.Drawing.Size(75, 23);
            this.AnonymousButton.TabIndex = 5;
            this.AnonymousButton.Text = "Submit";
            this.AnonymousButton.UseVisualStyleBackColor = true;
            this.AnonymousButton.Click += new System.EventHandler(this.AnonymousButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createButton.Location = new System.Drawing.Point(53, 326);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 23);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create Account";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginButton.Location = new System.Drawing.Point(200, 326);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // VerticalSeperaterBevel
            // 
            this.VerticalSeperaterBevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.VerticalSeperaterBevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VerticalSeperaterBevel.Location = new System.Drawing.Point(330, 100);
            this.VerticalSeperaterBevel.Name = "VerticalSeperaterBevel";
            this.VerticalSeperaterBevel.Size = new System.Drawing.Size(2, 250);
            this.VerticalSeperaterBevel.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RatingRover.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VerticalSeperaterBevel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.AnonymousButton);
            this.Controls.Add(this.birthYearText);
            this.Controls.Add(this.enterBirthYearLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.AnonymousEntryLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 435);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label AnonymousEntryLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label enterBirthYearLabel;
        private System.Windows.Forms.TextBox birthYearText;
        private System.Windows.Forms.Button AnonymousButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label VerticalSeperaterBevel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

