using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingRover
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Location = this.Location;
            login.Show();
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Boolean verified = false;
            verified = VerifyData();

            if (verified == true)
            {
                Program.CreateUser(userNameTextBox.Text.Trim(), passwordTextBox.Text.Trim());

                LoginForm login = new LoginForm();
                login.Location = this.Location;
                login.Show();
                this.Close();
            }
        }

        private Boolean VerifyData()
        {
            Boolean verified = false;

            if( FirstNameText.Text.Trim().Length > 0 )
            {
                if( lastNameText.Text.Trim().Length > 0)
                {
                    if( emailText.Text.Trim().Length > 0)
                    {
                        if( confirmEmailText.Text == emailText.Text)
                        {
                            if (userNameTextBox.Text.Trim().Length > 0)
                            {
                                if (Program.OpenUserName(userNameTextBox.Text.Trim()) == true)
                                {
                                    if (passwordTextBox.Text.Length > 0)
                                    {
                                        if (confirmPasswordTextBox.Text == passwordTextBox.Text)
                                        {
                                            if (YOBTextBox.Text.Length > 0)
                                            {
                                                verified = true;
                                            } else
                                            {
                                                MessageBox.Show("Must enter your year of birth as a string of 4 integers\n Example: 1990");
                                            }
                                        } else
                                        {
                                            MessageBox.Show("Passwords do not match");
                                        }
                                    } else
                                    {
                                        MessageBox.Show("Must enter atleast 1 character for the password");
                                    }
                                }  else
                                { 
                                     MessageBox.Show("Username is already taken");
                                }
                            } else
                            {
                                MessageBox.Show("Must enter atleast 1 character for the username");
                            }
                        } else
                        {
                            MessageBox.Show("Emails must match");
                        }
                    } else
                    {
                        MessageBox.Show("Must enter atleast 1 character for the email");
                    }
                } else
                {
                    MessageBox.Show("Must enter atleast 1 character for last name");
                }
            } else
            {
                MessageBox.Show("Muset enter atleast 1 character for first name");
            }

            

            return verified;
        }

        private void CreateAccountForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SubmitButton_Click(this, e);
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
