using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RatingRover.Presentation;

namespace RatingRover
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccount = new CreateAccountForm();
            createAccount.Location = this.Location;
            createAccount.Show();
            this.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Boolean successful = Program.Login(userNameText.Text.Trim(), passwordTextBox.Text.Trim());

            if( successful )
            {
                SearchForm searchForm = new SearchForm();
                searchForm.Location = this.Location;
                searchForm.Show();
                this.Visible = false;
            } else
            {
                MessageBox.Show("Password and username do not match our records");
            }

        }

        private void AnonymousButton_Click(object sender, EventArgs e)
        {
            if (birthYearText.Text.Trim().Length == 4)
            {
                if (birthYearText.Text.Trim().All(char.IsDigit))
                {
                    SearchForm searchForm = new SearchForm();
                    searchForm.Location = this.Location;
                    searchForm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Birthdate must be four digits only");
                }
            }
            else
            {
                MessageBox.Show("Birthdate must be four digits only");
            }
        }

        private void birthYearText_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthYearText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

       
        

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if( userNameText.Focused == true || passwordTextBox.Focused == true)
                {
                    loginButton_Click(this, e);
                } else
                {
                    AnonymousButton_Click(this, e);
                }
            }
        }
    }
}
