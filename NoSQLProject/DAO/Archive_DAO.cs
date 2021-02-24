using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class Archive_DAO : Base
    {
        public void ArchiveDatabase(string collectionName, string collectionUniqueID, int daysOldArchive)
        {
            base.ArchiveDatabase(collectionName, collectionUniqueID, daysOldArchive);
        }

        public List<ConfigurationItem> GetAllArchivedConfigItems()
        {
            return new ConfigurationItem_DAO().GetAllArchivedConfigItems();
        }

        public List<Ticket> GetAllArchivedTickets()
        {
            return new Ticket_DAO().GetAllArchivedTickets();
        }
    }
}
