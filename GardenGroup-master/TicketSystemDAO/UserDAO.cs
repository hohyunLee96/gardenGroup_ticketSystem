using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using TicketSystemModels;

namespace TicketSystemDAO
{
    public class UserDAO : MongoDB
    {
        protected static IMongoCollection<BsonDocument> userCollection;
        public UserDAO()
        {
            userCollection = db.GetCollection<BsonDocument>("users");
        }

        public void InsertUser(BsonDocument user)
        {
            userCollection.InsertOneAsync(user);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            var documents = userCollection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument b in documents)
            {
                User user = BsonSerializer.Deserialize<User>(b);
                users.Add(user);

            }
            return users;
        }
        public void UpdatePassword(string userName, Password newPassword)
        {
            var collection = db.GetCollection<BsonDocument>("users");                  
            var filter = Builders<BsonDocument>.Filter.Eq("UserName", userName);
            var update = Builders<BsonDocument>.Update.Set("Password", newPassword);

            collection.UpdateOne(filter, update);
         
        }

        public BsonDocument CreateUser(string email, string userName, BsonDocument name, BsonDocument password, UserType userType, string phoneNumber, string location)
        {
            var document = new BsonDocument
            {
                {"Email",email},
                {"UserName",userName},
                {"Name",name},
                {"Password",password},
                {"UserType",userType},
                {"PhoneNumber",phoneNumber},
                {"Location",location}
            };
            return document;
        }

        public BsonString GetUserNameByID(ObjectId userID)
        {
            BsonString name = new BsonString("");
            List<User> users = GetAllUsers();
            foreach (User user in users)
            {
                if (userID == user.UserId)
                {
                    name = BsonSerializer.Deserialize<Name>(user.Name).First;
                }
            }
            return name;
        }
    }
}
