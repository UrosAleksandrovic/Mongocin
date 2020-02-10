using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongocinAPI.Models
{
    public class Receipt : Bill
    {
        #region Attributes

        [BsonElement("ShopId")]
        private string _shopId;

        #endregion

        #region Properties

        [BsonIgnore]
        public string ShopId
        {
            get { return _shopId; }
            private set { _shopId = value; }
        }

        #endregion








    }
}