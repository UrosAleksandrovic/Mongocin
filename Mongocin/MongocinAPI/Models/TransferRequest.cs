using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongocinAPI.Models
{
    public class TransferRequest:IStatefull
    {
        #region Attributes

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ShopId")]
        public string ShopId { get; set; }

        [BsonElement("StorageId")]
        public string StorageId { get; set; }

        [BsonElement("ProductList")]
        public ProductListElement[] ProductList { get; set; }

       
        [BsonElement("State")]
        public StateEnum State { get; set; }

        #endregion

    }
}