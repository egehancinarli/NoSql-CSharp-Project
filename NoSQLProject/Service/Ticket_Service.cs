using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace Service
{
   public class Ticket_Service
    {
        public void AddTicket(Ticket ticket)
        {
            new Ticket_DAO().AddTicket(ticket);
        }
        public List<Ticket> GetAllTickets()
        {
            return new Ticket_DAO().GetAllTickets();
        }
        public void UpdateTicket(Ticket newTicket)
        {
            new Ticket_DAO().UpdateTicket(newTicket);
        }
        public void UpdateTicketUser(Ticket newTicket)
        {
            new Ticket_DAO().UpdateTicketUser(newTicket);
        }
    }
}
