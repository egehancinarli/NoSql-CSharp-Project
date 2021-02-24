using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Service
{
    public class Archive_Service
    {
        private Archive_DAO archiveDao = new Archive_DAO();

        public void ArchiveConfigItemDatabase(int archiveOlderThanDays)
        {
            archiveDao.ArchiveDatabase("configitemdb", "CI_ID", archiveOlderThanDays);
        }

        public void ArchiveUserDatabase(int archiveOlderThanDays)
        {
            archiveDao.ArchiveDatabase("users", "user_id", archiveOlderThanDays);
        }

        public void ArchiveTicketDatabase(int archiveOlderThanDays)
        {
            archiveDao.ArchiveDatabase("tickets", "ticket_id", archiveOlderThanDays);
        }

        public List<Ticket> GetAllArchivedTickets()
        {
            return new Archive_DAO().GetAllArchivedTickets();
        }

        public List<ConfigurationItem> GetArchivedConfigItems()
        {
            return new Archive_DAO().GetAllArchivedConfigItems();
        }
    }
}