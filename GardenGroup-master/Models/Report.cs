using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace TicketSystemModels
{
    public class Report
    {
        [BsonId]
        public ObjectId reportId { get; set; }

        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("reportCreationDate")]
        public DateTime ReportCreationDate { get; set; }

        [BsonElement("incidentDate")]
        public DateTime IncidentDate { get; set; }

        [BsonElement("reportDescription")]
        public string ReportDescription { get; set; }

        [BsonElement("incidentDuration")]
        public int IncidentDuration { get; set; }

        [BsonElement("incidentLocation")]
        public string IncidentLocation { get; set; }

        [BsonElement("department")]
        public string Department { get; set; }

        [BsonElement("subject")]
        public string Subject { get; set; }

        [BsonElement("category")]
        public Enums.category Category { get; set; }

        public Report(ObjectId userId, DateTime reportOfCreationDate, DateTime incidentDate, string incidentDescription, int incidentDuration, string incidentLocation, string department, string subject)
        {
            UserId = userId;
            ReportCreationDate = reportOfCreationDate;
            IncidentDate = incidentDate;
            ReportDescription = incidentDescription;
            IncidentDuration = incidentDuration;
            IncidentLocation = incidentLocation;
            Department = department;
            Subject = subject;
            
        }
    }
}
