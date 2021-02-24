using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQLProject
{
    //Written by Egehan Cinarli  641716
    public partial class AddUserWindow : Form
    {
        User_Service service;
        List<User> allUsers;

        public AddUserWindow()
        {
            InitializeComponent();
            service = new User_Service();
            allUsers = new List<User>();
        }
        //Adds a new user.
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (isUserValid())
            {
                User newUser = new User
                {
                    username = txtUsername.Text,
                    password = txtPassword.Text,
                    lastName = txtlastName.Text,
                    firstName = txtName.Text,
                    email = txtEmailAddress.Text,
                    nrTickets = 0
                };
                try
                {
                    service.AddUser(newUser);
                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK);
                }

                MessageBox.Show($"{newUser.firstName} {newUser.lastName} is added as a new user.","Welcome aboard!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClearFields();
            }

        }
        //Checks if the username is already in the database.
        private bool isUserValid()
        {
            if (service.IsUsernamePresent(txtUsername.Text))
            {
                MessageBox.Show("Username is already taken please pick another one","Invalid username",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else if(String.IsNullOrWhiteSpace(txtUsername.Text)||String.IsNullOrWhiteSpace(txtPassword.Text)||String.IsNullOrWhiteSpace(txtName.Text)||String.IsNullOrWhiteSpace(txtEmailAddress.Text)||String.IsNullOrWhiteSpace(txtlastName.Text))
            {           
                MessageBox.Show("Please fill all the fields properly(all fields must be filled","Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(txtPassword.Text.Length<4 || txtUsername.Text.Length < 4)
            {
                MessageBox.Show("Username and password field must have more than 4 characters","Invalid username/password",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }


        //Cleaning the text fields.
        private void ClearFields()
        {
            txtName.Clear();
            txtlastName.Clear();
            txtEmailAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
