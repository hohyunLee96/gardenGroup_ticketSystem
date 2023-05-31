using MongoDB.Bson.Serialization.Attributes;

namespace TicketSystemModels
{
    public class Name
    {
        [BsonElement("first")]
        public string First { get; set; }

        [BsonElement("second")]
        public string Second { get; set; }
    }
}
