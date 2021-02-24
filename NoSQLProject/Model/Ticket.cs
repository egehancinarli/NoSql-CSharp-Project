using System;

namespace Model
{
    /*
     * Written by Cosmin Ilie (645976)
     */
    public class Ticket
    {
        public int Id { get; set; }
        public User ReportedByUser { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Subject { get; set; }
        public TicketIncidentType Type { get; set; }
        public TicketPriorityType Priority { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsOpen { get; set; }
        public void SetDeadline(int index)
        {

            switch (index)
            {
                
                case 0: //7 days
                    Deadline = DateTime.Now.AddDays(7);
                    break;
                case 1: //14 days
                    Deadline = DateTime.Now.AddDays(14);
                    break;
                case 2: //28 days
                    Deadline = DateTime.Now.AddDays(28);
                    break;
                case 3: //6 months
                    Deadline = DateTime.Now.AddDays(180);
                    break;
            }
        }
        public string GetStatus()
        {
            if (IsOpen) return "Open";

            return "Closed";
        }
        public bool SetStatus(string status)
        {
            if (status.Equals("Open")) return true;

            return false;
        }

    }
}
