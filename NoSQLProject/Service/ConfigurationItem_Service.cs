using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Service
{
    public class ConfigurationItem_Service
    {
        private ConfigurationItem_DAO ConfigurationItemDAO = new DAO.ConfigurationItem_DAO();

        public void AddConfigItem(ConfigurationItem ci)
        {
            ConfigurationItemDAO.AddConfigItem(ci);
        }

        public ConfigurationItem GetConfigItemByID(string id)
        {
           return ConfigurationItemDAO.GetConfigItemByID(id);
        }

        public List<ConfigurationItem> GetAllConfigItems()
        {
            return ConfigurationItemDAO.GetAllConfigItems();
        }

        public void UpdateConfigItem(ConfigurationItem configItem)
        {
            ConfigurationItemDAO.UpdateConfigItem(configItem);
        }

        public List<ConfigurationItem> GetConfigItemsByLocation(string location)
        {
            return ConfigurationItemDAO.GetConfigItemsByLocation(location);
        }

        public List<ConfigurationItem> GetConfigItemsByImportance(TicketPriorityType importance)
        {
            return ConfigurationItemDAO.GetConfigItemsByImportance(importance);
        }
    }
}