using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Service;
using Model;
using System.Drawing;

namespace NoSQLProject
{
    /*
     * Written by Cosmin Ilie (645976)
     */
    public partial class TicketsOverview : Form
    {
        private List<Ticket> tickets;
        private Ticket_Service ticketService;
        private User user;
        public TicketsOverview(User user)
        {
            this.user = user;
            InitializeComponent();
            ticketService = new Ticket_Service();
            if (tickets == null)
                tickets = ticketService.GetAllTickets();
        }
        public void LoadListView()
        {
            listViewTickets.Items.Clear();

            foreach (ListViewItem item in GetFullListView().Items)
                listViewTickets.Items.Add((ListViewItem)item.Clone());

            ColorListRows();
            listViewTickets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private ListView GetFullListView()
        {

            ListView tempList = new ListView();
            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Id.ToString());
                item.SubItems.Add(ticket.Subject);
                item.SubItems.Add(ticket.ReportedByUser.username);
                item.SubItems.Add(ticket.IncidentDate.ToString("dd-MMM-yy"));
                item.SubItems.Add(ticket.Type.ToString());
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(ticket.GetStatus());
                tempList.Items.Add(item);
            }
            return tempList;
        }
        private void ColorListRows() //color the status column
        {
            foreach (ListViewItem item in listViewTickets.Items)
            {
                item.UseItemStyleForSubItems = false;
                if (item.SubItems[6].Text.Equals("Open"))
                    item.SubItems[6].BackColor = Color.LightGreen;
                else
                    item.SubItems[6].BackColor = Color.PaleVioletRed;
            }
        }
        private Ticket GetTicketById(int id)
        {

            foreach (Ticket ticket in tickets)
                if (ticket.Id == id)
                    return ticket;

            return null;
        }
        private void TicketsOverview_Load(object sender, EventArgs e)
        {
            LoadListView();
            txtFilter.ForeColor = Color.Gray;

            ShowSearchToolTip();
        }
        private void ShowSearchToolTip()
        {
            ToolTip test = new ToolTip();
            string tooltipText = "Examples:\n(single word) Cosmin\n(AND) Cosmin & Software\n(OR) Cosmin | Egehan";
            test.SetToolTip(picInfo, tooltipText);
            test.Active = true;
            test.ShowAlways = true;
            test.InitialDelay = 0;
        }
        private void RemovePlaceholderText()
        {
            if (txtFilter.Text.Equals("Search list..."))
            {
                txtFilter.Text = "";
                txtFilter.ForeColor = Color.Black;
            }

        }
        private void AddPlaceholderText()
        {
            if (string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                txtFilter.Text = "Search list...";
                txtFilter.ForeColor = Color.Gray;
            }

        }

        private void TicketsOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddTicketForm(user).Show();
        }

        private void listViewTickets_DoubleClick(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                listViewTickets.SelectedItems[0].Checked = !listViewTickets.SelectedItems[0].Checked;
                Ticket ticket = GetTicketById(int.Parse(listViewTickets.SelectedItems[0].Text));
                new TicketInfoForm(ticket,this).ShowDialog();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            //for the checked items, if the status is closed then change it to open, if it is open then change it to close
            if (listViewTickets.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewTickets.CheckedItems)
                {
                    Ticket ticket = GetTicketById(int.Parse(item.SubItems[0].Text));
                    ticket.IsOpen = !ticket.IsOpen;
                    if (!ticket.IsOpen)
                    {
                        User_Service userService = new User_Service();
                        ticket.ReportedByUser.nrTickets--;
                        userService.UpdateUserTickets(ticket.ReportedByUser);
                    }

                    ticketService.UpdateTicket(ticket);
                    LoadListView();
                }
            }
            else
                MessageBox.Show("No tickets selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            RemovePlaceholderText();
        }

        private void txtFilter_Leave(object sender, EventArgs e)
        {
            AddPlaceholderText();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text != "Search list...")
            {
                new SearchTickets(txtFilter, listViewTickets, GetFullListView());
                ColorListRows();
            }
        }

        ////////////////////////////////////
        //Emre Kutuk individual extra assignment

        private bool firstClick = true;
        private void listViewTickets_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer 
            // object. Setting this property immediately sorts the 
            // ListView using the ListViewItemComparer object.
            firstClick = !firstClick;
            this.listViewTickets.ListViewItemSorter = new ListViewItemComparer(e.Column, firstClick);
        }
        ///////////////////////////////////////////////////////////////////

        private void ticketsOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard(user).Show();
        }

        private void usersOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserManagementUI(user).Show();
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
