using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TicketSystemModels
{
    public class Password
    {
        [BsonElement("salt")]
        public string Salt { get; set; }

        [BsonElement("hashedPassword")]
        public string HashedPassword { get; set; }
    }
}
