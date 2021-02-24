using Model;
using MongoDB.Bson;
using Service;
using System;
using System.Collections;
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
    //Emre Kutuk
    public partial class Dashboard : Form
    {
        Ticket_Service ticket_Service = new Ticket_Service();
        User_Service user_Service = new User_Service();
        List<Ticket> tickets;
        User user;
        bool isGeneral;

        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Initialize();
        }

        private void Initialize()
        {
            this.Text = $"Dashboard | {this.user.firstName} {this.user.lastName}";
            cmbDashboardType.Items.Add("General Dashboard");
            cmbDashboardType.Items.Add("Personal Dashboard");
            cmbDashboardType.SelectedIndex = 0;
            DisplayGeneralPanel();
        }

        private void DisplayPersonalPanel()
        {
            isGeneral = false;
            pnlGeneral.Hide();
            pnlPersonal.Show();
            lblWelcome.Text = $"Welcome {user.firstName} {user.lastName}";
            tickets = ticket_Service.GetAllTickets();
            lblPersonalTicketInfo.Text =
                $"You have {tickets.Where(t => t.ReportedByUser.id.Equals(this.user.id) && t.IsOpen).ToList().Count} open ticket(s).";
            LoadListView();
        }

        private void LoadListView()
        {
            //fills the ticket list for personal open tickets
            listViewTicket.Clear();

            ColumnHeader ticketID = new ColumnHeader();
            ticketID.Text = "ID";
            ColumnHeader ticketSubject = new ColumnHeader();
            ticketSubject.Text = "Subject";
            ColumnHeader ticketUser = new ColumnHeader();
            ticketUser.Text = "User";
            ColumnHeader ticketDate = new ColumnHeader();
            ticketDate.Text = "Date";
            ColumnHeader ticketType = new ColumnHeader();
            ticketType.Text = "Type";
            ColumnHeader ticketPriority = new ColumnHeader();
            ticketPriority.Text = "Priority";

            listViewTicket.Columns.AddRange(new ColumnHeader[]
                {ticketID, ticketSubject, ticketUser, ticketDate, ticketType, ticketPriority});

            foreach (Ticket t in tickets.Where(t => t.ReportedByUser.id.Equals(this.user.id) && t.IsOpen))
            {
                ListViewItem li = new ListViewItem(t.Id.ToString());
                li.SubItems.Add(t.Subject.ToString());
                li.SubItems.Add(t.ReportedByUser.firstName);
                li.SubItems.Add(t.IncidentDate.ToString("dd-MMM-yy"));
                li.SubItems.Add(t.Type.ToString());
                li.SubItems.Add(t.Priority.ToString());

                listViewTicket.Items.Add(li);
            }

            listViewTicket.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void DisplayGeneralPanel()
        {
            isGeneral = true;
            pnlPersonal.Hide();
            pnlGeneral.Show();
            DisplayPriorityTexts();
            DisplayDeadlineText();
            DisplayStatusTex();
        }

        private void DisplayStatusTex()
        {
            //gets the nr of users and nr of tickets
            List<User> allUsers = user_Service.getAllUsers();
            List<Ticket> allTickets = ticket_Service.GetAllTickets();

            //checks if there are more tickets than users and displays the status accordingly
            if (allUsers.Count < allTickets.Where(t => t.IsOpen).ToList().Count)
            {
                lblStatus.Text = $"Status: Busy";
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.Text = $"Status: Normal";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void DisplayDeadlineText()
        {
            List<Ticket> allTickets = ticket_Service.GetAllTickets();

            //gets the nr of tickets that are over their deadline
            int overDeadlineTicketNr = allTickets.Where(t => t.Deadline < DateTime.Now && t.IsOpen).ToList().Count;
            lblUrgentTickets.Text = $"There are {overDeadlineTicketNr} ticket(s) that needs urgent attention!";

            //if there are more than 1 ticket over its deadline, the color becomes red
            if (overDeadlineTicketNr <= 1)
                lblUrgentTickets.ForeColor = Color.Green;
            else
                lblUrgentTickets.ForeColor = Color.Red;
        }

        private void DisplayPriorityTexts()
        {
            List<Ticket> allTickets = ticket_Service.GetAllTickets();

            //gets the nr of open tickets for each priority
            int highPriorityTicketNr =
                allTickets.Where(t => t.Priority == TicketPriorityType.High && t.IsOpen).ToList().Count;
            int normalPriorityTicketNr = allTickets.Where(t => t.Priority == TicketPriorityType.Normal && t.IsOpen)
                .ToList().Count;
            int lowPriorityTicketNr =
                allTickets.Where(t => t.Priority == TicketPriorityType.Low && t.IsOpen).ToList().Count;

            lblHighPriorityTickets.Text = $"Tickets with high priority; {highPriorityTicketNr}";
            lblNormalPriorityTickets.Text = $"Tickets with normal priority; {normalPriorityTicketNr}";
            lblLowPriorityTickets.Text = $"Tickets with low priority; {lowPriorityTicketNr}";
        }

        //Refreshing the dashboard according to chosen panel
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (isGeneral)
                DisplayGeneralPanel();
            else
                DisplayPersonalPanel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        //opens a ticket view when clicked
        private void listViewTicket_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Ticket ticket = GetTicketById(int.Parse(listViewTicket.SelectedItems[0].Text));
            new TicketInfoForm(ticket).ShowDialog();
        }

        private Ticket GetTicketById(int id)
        {
            foreach (Ticket ticket in tickets)
                if (ticket.Id == id)
                    return ticket;

            return null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (this.user.rememberMe)
            {
                new LoginForm(user).Show();
            }
            else
                new LoginForm().Show();
            this.Hide();
        }

        //Emre Kutuk individual extra assignment

        private bool firstClick = true;

        private void listViewTicket_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer 
            // object. Setting this property immediately sorts the 
            // ListView using the ListViewItemComparer object.
            firstClick = !firstClick;
            this.listViewTicket.ListViewItemSorter = new ListViewItemComparer(e.Column, firstClick);
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void configurationItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConfigItemUi(user).Show();
        }

        private void archivedItemsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ArchiveView().Show();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to archive tickets and configuration items older than 10 days?",
                "Archive Database",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Archive_Service archiveService = new Archive_Service();

                archiveService.ArchiveTicketDatabase(10);
                archiveService.ArchiveConfigItemDatabase(10);

                MessageBox.Show("Archive Successful", "Archive Successful");
            }
        }

        private void ticketsOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TicketsOverview(user).Show();
        }

        private void usersOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserManagementUI(user).Show();
        }

        private void cmbDashboardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDashboardType.SelectedIndex == 0)
                DisplayGeneralPanel();
            else if (cmbDashboardType.SelectedIndex == 1)
                DisplayPersonalPanel();

        }
    }
}