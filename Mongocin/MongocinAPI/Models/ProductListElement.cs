using MongoDB.Bson.Serialization.Attributes;

namespace MongocinAPI.Models
{
    public class ProductListElement
    {
        [BsonElement("ProductId")]
        public string ProductId { get; set; }

        [BsonElement("ProductQuantity")]
        public int ProductQuantity { get; set; }
    }
}