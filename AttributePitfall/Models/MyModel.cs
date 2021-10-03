using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AttributePitfall.Models
{
    public class MyModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
