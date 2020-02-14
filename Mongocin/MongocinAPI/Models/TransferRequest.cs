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

        [BsonElement("ProductList")]
        private ProductListElement[] _productList;

        #endregion

        #region Properties

        [BsonIgnore]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
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
        public ProductListElement[] ProductList
        {
            get { return _productList; }
            private set { _productList = value; }
        }

        [BsonElement("State")]
        public StateEnum State { get; set; }

        #endregion

    }
}