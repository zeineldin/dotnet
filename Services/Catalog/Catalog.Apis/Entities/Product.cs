using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Catalog.Apis.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // 24 chars
        public string Id { get; set; } // key

        [BsonElement("Name")]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
