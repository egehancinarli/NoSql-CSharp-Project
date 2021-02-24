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
    public partial class UserManagementUI : Form
    {
        List<User> allUsers;
        User_Service service;
        private User user;
        public UserManagementUI(User user)
        {

            InitializeComponent();
            this.user = user;
            allUsers = new List<User>();
            service = new User_Service();
        }
        private void UserManagementUI_Load(object sender, EventArgs e)
        {
            FillListView();
            FillComboBox();
        }


        // Determines the filtering type
        private void FilterUsers()
        {
            switch(cmbType.SelectedIndex)
            {
                case 0:
                    FilterById();
                    break;
                case 1:
                    FilterByEmail();
                    break;
                case 2:
                    FilterByFName();
                    break;
                case 3:
                    FilterByLName();
                    break;
                case 4:
                    FilterByTickets(); 
                    break;
                default:
                    FilterByEmail();
                    break;
            }
            if (String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                FillListView();
            }
        }

        //filters by first name
        private void FilterByFName()
        {
            userView.Items.Clear();

            foreach (User u in allUsers)
            {
                if (u.firstName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    AddUserToListView(u);
                }
            }
        }
        //filters by email
        private void FilterByEmail()
        {
            userView.Items.Clear();

            foreach (User u in allUsers)
            {
                if (u.email.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    AddUserToListView(u);
                }
            }
        }

        //Just reducing the duplicate codes
        private void AddUserToListView(User u)
        {
            ListViewItem item = new ListViewItem(
                         new string[] {
                        u.id.ToString(),
                        u.email,
                        u.firstName,
                        u.lastName,
                        u.nrTickets.ToString()
                     });
            userView.Items.Add(item);
        }
        //filters by last name
        private void FilterByLName()
        {
            userView.Items.Clear();

            foreach (User u in allUsers)
            {
                if (u.lastName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    AddUserToListView(u);
                }
            }
        }

        //filters by id
        private void FilterById()
        {
            userView.Items.Clear();

            foreach(User u in allUsers)
            {
                if (u.id.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    AddUserToListView(u);
                }
            }
            
        }


        //filters by ticket numbers

        private void FilterByTickets()
        {
            userView.Items.Clear();

            foreach (User u in allUsers)
            {
                if (u.nrTickets.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    AddUserToListView(u);
                }
            }
        }

        

        private void FillComboBox()
        {
            string[] items = new string[] {"Id","Email","First name","Last name","Number of tickets" };
            cmbType.Items.AddRange(items);
            cmbType.SelectedIndex= 1;//It starts from email by default
        }

        private void FillListView()
        {
            allUsers = service.getAllUsers();
            userView.Clear();
            userView.Columns.Add("Id");
            userView.Columns.Add("Email address");
            userView.Columns.Add("First name");
            userView.Columns.Add("Last name");
            userView.Columns.Add("# tickets");

            foreach(User u in allUsers)
            {
                AddUserToListView(u);
            }
            userView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);                      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserWindow window = new AddUserWindow();
            window.ShowDialog();
            FillListView();
        }

        private void UserManagementUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterUsers();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(user);
            this.Hide();
            dashboard.ShowDialog();            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard(user).Show();
        }

        private void ticketOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketsOverview(user).Show();
        }

        private void configurationItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConfigItemUi(user).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.user.rememberMe)
            {
                new LoginForm(user).Show();
            }
            else
                new LoginForm().Show();
            this.Hide();
        }
    }
}
