using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TicketSystemModels
{
    public class User
    {
        [BsonId]
        public ObjectId UserId { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("UserName")]
        public string UserName { get; set; }

        [BsonElement("Name")]
        public BsonDocument Name { get; set; }

        [BsonElement("Password")]
        public BsonDocument Password { get; set; }

        [BsonElement("UserType")]
        public UserType UserType { get; set; }

        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("Location")]
        public string Location { get; set; }

        [BsonElement("UserReports")]
        public Array[] UserReports { get; set; }

        public User(string email,string userName,BsonDocument name, BsonDocument password, int userType,string phoneNumber,string location,Array[] userReports)
        {
            Email = email;
            UserName = userName;
            Name = name;
            Password = password;        
            UserType = (UserType)userType;
            PhoneNumber = phoneNumber;
            Location = location;
            UserReports = userReports;
            Location = location;
            PhoneNumber = phoneNumber;
        }
        public User()
        {

        }
    }
}
