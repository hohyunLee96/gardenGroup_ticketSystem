using TicketSystemModels;
using TicketSystemDAO;
using System.Collections.Generic;
using MongoDB.Bson;
using System;

namespace TicketSystemServices
{
    public class TicketService
    {
        private readonly TicketDAO ticketDao;

        public TicketService() => ticketDao = new TicketDAO();

        public void InsertTicket(Ticket ticket) => ticketDao.InsertTicket(ticket);

        public List<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public Ticket GetByDescription(string description) => ticketDao.GetByDescription(description);

        public void AddClosedTicketToArchiveCollection()
        {
           ticketDao.AddClosedTicketToArchiveCollection();
        }

        public void UpdateTicketStatus(Ticket ticket, TicketStatus newStatus) 
        {
            ticketDao.UpdateTicketStatus(ticket, newStatus);
        }
        public void UpdateTicketEmployee(Ticket ticket, ObjectId employeeId)
        {
            ticketDao.UpdateTicketEmployee(ticket, employeeId);
        }

        public void UpdateTicketInformation(Ticket ticket) => ticketDao.UpdateTicketInformation(ticket);
        

        public void DeleteOneDocumentFromTicketDatabase(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new Exception("Something went wrong, try again");
            }
            ticketDao.DeleteTicketFromDatabase(ticket);
        }
    }
}
