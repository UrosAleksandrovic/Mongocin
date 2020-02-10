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
        private string _id;

        [BsonElement("ShopId")]
        private string _shopId;

        [BsonElement("StorageId")]
        private string _storageId;

        private List<Product> _productList;

        #endregion

        #region Properties

        [BsonIgnore]
        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        [BsonIgnore]
        public string ShopId
        {
            get { return _shopId; }
            private set { _shopId = value; }
        }

        [BsonIgnore]
        public string StorageId
        {
            get { return _storageId; }
            private set { _storageId = value; }
        }

        [BsonIgnore]
        public List<Product> ProductList
        {
            get { return _productList; }
            private set { _productList = value; }
        }

        [BsonElement("State")]
        public StateEnum State { get; set; }

        #endregion

    }
}