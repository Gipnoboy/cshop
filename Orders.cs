using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cshop
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ItemName { get; set; }
        public string Customer { get; set; }
        public string Date { get; set; }
        public Order(string itemname, string customer, string date)
        {
            ItemName = itemname;
            Customer = customer;
            Date = date;
        }
    }
}
