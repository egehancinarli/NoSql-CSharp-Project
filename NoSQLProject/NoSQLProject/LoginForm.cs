using Model;
using Service;
using System;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '●';
        }

        public LoginForm(User user)                         // for remember me
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '●';
            UsernameTxtBox.Text = user.username;
            PasswordTxtBox.Text = user.password;
            RememberMeBox.Checked = true;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            _ = new User();
            User_Service userService = new User_Service();
            if ((UsernameTxtBox.Text.Length < 1) || (PasswordTxtBox.Text.Length < 1))
            {
                MessageBox.Show("Missing credentials!");
            }
            else
            {
                if (userService.IsUsernamePresent(UsernameTxtBox.Text))
                {

                    User user = userService.GetUserByName(UsernameTxtBox.Text);
                    if (PasswordTxtBox.Text.Equals(user.password))
                    {
                        this.Hide();
                        new Dashboard(user).Show();
                        user.rememberMe = RememberMeBox.Checked;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password"); //password doesn't match
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password"); //username does not exist in the db
                }
            }
        }


        private void ForgotPasswordLbl_Click(object sender, EventArgs e)
        {
            ForgottenPasswordForm passwordForm = new ForgottenPasswordForm();
            passwordForm.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
