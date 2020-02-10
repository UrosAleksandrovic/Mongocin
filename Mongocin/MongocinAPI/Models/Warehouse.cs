using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongocinAPI.Models.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace MongocinAPI.Models
{
    public class Warehouse : Storehouse
    {
       [BsonIgnore]
        public List<Order> OrdersList { get; set; }

        [BsonElement("Orders")]
        public List<String> Orders { get; set; }
    }
}