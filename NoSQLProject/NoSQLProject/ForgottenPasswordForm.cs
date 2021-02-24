using Model;
using Service;
using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class ForgottenPasswordForm : Form
    {
        private User selectedUser;
        private int key;
        public ForgottenPasswordForm()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
            NewPasswordBox.PasswordChar = '●';
        }
        private int CreateKey()                                         //creates authentication key
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] byteArray = new byte[4];
            rng.GetBytes(byteArray);
            int value = BitConverter.ToInt32(byteArray, 0);
            return value;
        }
        private User CheckUser()                                //checks if user with username is 
        {                                                       //present in db and returns User object
            _ = new User();
            User_Service userService = new User_Service();
            if (userService.IsUsernamePresent(UsernameTxtBox.Text))
            {
                User user = userService.GetUserByName(UsernameTxtBox.Text);
                return user;
            }
            else
            {
                return null;
            }
        }
        private User CheckEmail()                                 //checks if user with email is
        {                                                         //present in db and returns User object
            _ = new User();
            User_Service userService = new User_Service();
            if (userService.IsEmailPresent(EmailTxtBox.Text))
            {
                User user = userService.GetUserByEmail(EmailTxtBox.Text);
                return user;
            }
            else
            {
                return null;
            }
        }

        private void SendMailToUser(User user, int key)                         //sends mail to user's email
        {
            if (user != null)
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("nosql2020project@gmail.com");
                    mail.To.Add(user.email);
                    mail.Subject = "Password recovery";
                    mail.Body = "<h3> Your authentication key is: </h3><mark>" + key.ToString() + "</mark>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("nosql2020project@gmail.com", "Project123!");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                    }
                }
                MessageBox.Show("An email with the authentication code has been sent to the registered email address!");
                label1.Text = "";
                panel1.Hide();
                panel2.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong!");  //when no username is entered
            }
        }

        private void AuthenticationBtn_Click(object sender, EventArgs e)        //checks if entered code is valid
        {                                                                       //and shows the next panel with info
            if (AuthenticationTxtBox.Text == key.ToString())                    //and changable password
            {
                panel2.Hide();
                panel3.Show();
                ShowIdLbl.Text = selectedUser.id.ToString();
                ShowUsernameLbl.Text = selectedUser.username;
                ShowEmailLbl.Text = selectedUser.email;
                ShowNameLbl.Text = selectedUser.firstName + " " + selectedUser.lastName;
            }
            else
            {
                MessageBox.Show("Invalid authentication code");
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)        //changes password for user in db
        {
            User_Service service = new User_Service();
            if (NewPasswordBox.Text.Length < 4)
            {
                MessageBox.Show("Invalid password! Must contain 4 or more symbols");
            }
            else
            {
                service.UpdateUserPassword(selectedUser, NewPasswordBox.Text);
                this.Close();
                MessageBox.Show("Password changed successfully!");

            }
        }

        private void SendBtnEmail_Click(object sender, EventArgs e)
        {
            selectedUser = CheckEmail();
            try
            {
                key = CreateKey();
                SendMailToUser(selectedUser, key);

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;               //prints errors on bottom of screen (this should not happen)
            }
        }
        private void SendBtnUsername_Click(object sender, EventArgs e)
        {
            selectedUser = CheckUser();
            try
            {
                key = CreateKey();
                SendMailToUser(selectedUser, key);

            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
