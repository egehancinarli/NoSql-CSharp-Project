using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace NoSQLProject
{
    public partial class ArchiveView : Form
    {
        public ArchiveView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ArchiveView_Load(object sender, EventArgs e)
        {
            BindingSource ciBindingSource = new BindingSource();
            BindingSource ticketBindingSource = new BindingSource();

            Archive_Service archiveService = new Archive_Service();

            foreach (var ticket in archiveService.GetAllArchivedTickets())
            {
                ticketBindingSource.Add(ticket);
            }

            foreach (var configItem in archiveService.GetArchivedConfigItems())
            {
                ciBindingSource.Add(configItem);
            }

            dataGridViewCI.DataSource = ciBindingSource;
            dataGridViewTicket.DataSource = ticketBindingSource;
        }
    }
}
