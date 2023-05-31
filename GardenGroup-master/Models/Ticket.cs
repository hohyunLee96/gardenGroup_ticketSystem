using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TicketSystemModels
{
    public class Ticket
    {
        readonly User user = new User();

        [BsonId]
        public ObjectId TicketId { get; set; }

        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("ticketOpenDate")]
        public DateTime TicketOpenDate{ get; set; }

        [BsonElement("ticketCloseDate")]
        public DateTime TicketCloseDate{ get; set; }

        [BsonElement("ticketDescription")]
        public string TicketDescription { get; set; }

        [BsonElement("ticketStatus")]
        public TicketStatus TicketStatus{ get; set; }

        [BsonElement("ticketSubject")]
        public string TicketSubject { get; set; }

        [BsonElement("ticketLocation")]
        public string TicketLocation { get; set; }

        [BsonElement("incidentDuration")]
        public int IncidentDuration { get; set; }

        [BsonElement("ticketPriority")]
        public int TicketPriority { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }

        [BsonElement("deadline")]
        public DateTime Deadline { get; set; }

        [BsonElement("timeOfOccurance")]
        public DateTime TimeOfOccurance { get; set; }

        public Ticket(ObjectId userId,DateTime ticketOpenDate, DateTime ticketCloseDate, string ticketDescription, TicketStatus ticketStatus, string ticketSubject, string ticketLocation, int incidentDuration, int ticketPriority, string department, DateTime deadline, DateTime timeOfOccurance)
        {
            UserId = userId;
            TicketOpenDate = ticketOpenDate;
            TicketCloseDate = ticketCloseDate;
            TicketDescription = ticketDescription;
            TicketStatus = ticketStatus;
            TicketSubject = ticketSubject;
            TicketLocation = ticketLocation;
            IncidentDuration = incidentDuration;
            TicketPriority = ticketPriority;
            Department = department;
            Deadline = deadline;
            TimeOfOccurance = timeOfOccurance;
        }
    }
}
