using System;

namespace Model
{
    public class ConfigurationItem
    {
        public string ID { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Owner { get; set; } // Should be a User?

        public string Location { get; set; }

        public TicketPriorityType Importance { get; set; }

        public ConfigurationItem(string name, string description, int owner, string location,
            TicketPriorityType importance) : this(
            Guid.NewGuid().ToString(),
            name,
            description,
            owner,
            location,
            importance)
        {
        }

        public ConfigurationItem(string name, int owner, string location, TicketPriorityType importance) : this(
            Guid.NewGuid().ToString(),
            name,
            "No Description Available",
            owner,
            location,
            importance)
        {
        }

        // No Description or Priority
        public ConfigurationItem(string name, int owner, string location) : this(
            Guid.NewGuid().ToString(),
            name,
            "No Description Available",
            owner,
            location,
            TicketPriorityType.Low)
        {
        }

        public ConfigurationItem(string id, string name, string description, int owner, string location,
            TicketPriorityType importance)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Owner = owner;
            this.Location = location;
            this.Importance = importance;
        }
        public override string ToString()
        {
            return string.Format($"ID: {ID}\n" +
                                 $"Name: {Name}\n" +
                                 $"Description: {Description}\n" +
                                 $"Owner: {Owner}\n" +
                                 $"Location: {Location}\n" +
                                 $"Importance: {Importance}\n");
        }
    }
}