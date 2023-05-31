using MongoDB.Driver;

namespace TicketSystemDAO
{
    public class MongoDB
    {
        protected static IMongoDatabase db;
        protected MongoDB()
        {
            var client = new MongoClient("mongodb+srv://DominikKaniecki:12345@cluster0.qxlqtbh.mongodb.net/test");
            db = client.GetDatabase("DB_GardenGroup_IT2A_GR4");
        }
    }
}
