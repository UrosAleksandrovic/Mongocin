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
        private List<ProductListElement> _productList;

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
            set { _shopId = value; }
        }

        [BsonIgnore]
        public string StorageId
        {
            get { return _storageId; }
            set { _storageId = value; }
        }

        [BsonIgnore]
        public List<ProductListElement> ProductList
        {
            get { return _productList; }
            set { _productList = value; }
        }

        [BsonElement("State")]
        public StateEnum State { get; set; }

        #endregion

    }
}