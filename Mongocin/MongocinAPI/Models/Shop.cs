﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongocinAPI.Models.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongocinAPI.Models
{
    public class Shop : Storehouse
    {
        [BsonElement("Receipts")]
        public List<String> Receipts { get; set; }

        [BsonIgnore]
        public List<Receipt> ReceiptList { get; set; }

    }
}