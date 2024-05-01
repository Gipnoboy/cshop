using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cshop
{
    public class Staff
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Staff(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
