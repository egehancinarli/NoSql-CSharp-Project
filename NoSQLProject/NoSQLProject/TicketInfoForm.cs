using System.Windows.Forms;
using Model;
using MongoDB.Bson.Serialization.Conventions;

namespace NoSQLProject
{
    /*
     * Written by Cosmin Ilie (645976)
     */
    public partial class TicketInfoForm : Form
    {
        private Ticket ticket;
        private TicketsOverview overview;
        public TicketInfoForm(Ticket ticket)
        {
            InitializeComponent();
            this.ticket = ticket;          

            if (ticket != null)
                DisplayInfo();

            if (ticket.IsOpen)
            {
                btnTransfer.Enabled = true;
            }
            else
            {
                btnTransfer.Enabled = false;
            }
        }
        //For reloading the page.
        public TicketInfoForm(Ticket ticket, TicketsOverview overview): this(ticket){ 
            this.overview = overview;
        }
        private void DisplayInfo()
        {
            lblId.Text = $"ID: {ticket.Id}";
            lblSubject.Text = $"Subject: {ticket.Subject}";
            lblSnitch.Text = $"Reported by: {ticket.ReportedByUser.username}({ticket.ReportedByUser.id})";
            lblDate.Text = $"Date: {ticket.IncidentDate}";
            lblType.Text = $"Type: {ticket.Type}";
            lblPriority.Text = $"Priority: {ticket.Priority}";
            lblDeadline.Text = $"Deadline: {ticket.Deadline.ToString("dd-MMM-yy")}";
            lblStatus.Text = $"Status: {ticket.GetStatus()}";
            lblDescription.Text = $"Description: {ticket.Description}";
        }
        private void btnReturn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }
        private void TicketInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(overview != null)
            overview.LoadListView();
        }

        private void btnTransfer_Click(object sender, System.EventArgs e)
        {
            TransferTicketsUI ticketsUI = new TransferTicketsUI(ticket);
            ticketsUI.ShowDialog();
            this.Close();
        }
    }
}
