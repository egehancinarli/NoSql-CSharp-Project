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
    public partial class Archive_View : Form
    {
        public Archive_View()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Archive_View_Load(object sender, EventArgs e)
        {
            Archive_Service archiveService = new Archive_Service();

            BindingSource bindingSourceCI = new BindingSource();
            BindingSource bindingSourceTicket = new BindingSource();


            bindingSourceCI.Clear();
            foreach (var configItem in archiveService.GetArchivedConfigItems())
            {
                bindingSourceCI.Add(configItem);
            }
            foreach (var ticket in archiveService.GetAllArchivedTickets())
            {
                bindingSourceTicket.Add(ticket);
            }

            dataGridViewCIArchive.DataSource = bindingSourceCI;
            dataGridViewTicketArchive.DataSource = bindingSourceTicket;
        }
    }
}