using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using TicketSystemModels;

namespace TicketSystemDAO
{
    public class ReportDAO : MongoDB
    {
        protected static IMongoCollection<Report> reportCollection = db.GetCollection<Report>("reports");

        public void InsertReport(Report report)
        {
            reportCollection.InsertOne(report);
        }

        public List<Report> GetAllReports() // Getting everything as BsonDocument
        {
            var collection = db.GetCollection<BsonDocument>("reports");
            var documents = collection.Find(new BsonDocument()).ToList();
            List<Report> reports = new List<Report>();

            foreach(BsonDocument doc in documents)
            {
                Report report = BsonSerializer.Deserialize<Report>(doc);
                reports.Add(report);
            }
            return reports;
        }
        public void deleteReport(Report report) 
        {
            var deleteFilter = Builders<BsonDocument>.Filter.Eq("_id", report.reportId);
            db.GetCollection<BsonDocument>("reports").DeleteOne(deleteFilter);
        }
    }
}
