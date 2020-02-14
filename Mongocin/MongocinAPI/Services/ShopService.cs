using MongocinAPI.App_Start;
using MongocinAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace MongocinAPI.Services
{
    public class ShopService
    {
        private MongoDBContext _dbContext;
        private IMongoCollection<Shop> _shopCollection;

        public ShopService()
        {
            _dbContext = new MongoDBContext();
            _shopCollection = _dbContext.Database.GetCollection<Shop>
                (ConfigurationManager.AppSettings["ShopCollectionName"]);
        }

        public Shop GetShop(string shopId)
        {
            try
            {
                FilterDefinition<Shop> Filer = Builders<Shop>.Filter.Eq("Id", shopId);
                List<Shop> Results = _shopCollection.Find(Filer).ToList();
                if (Results.Count == 0)
                    return null;

                return Results.First();
            }
            catch
            {
                return null;
            }
        }

        public bool InsertShop(Shop Shop) 
        {
            try
            {
                if (_shopCollection == null)
                    return false;
                Shop.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
                Shop prevShop = GetShop(Shop.Id.ToString());
                if (prevShop == null)
                {
                    _shopCollection.InsertOne(Shop);
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteShop(string shopId) 
        {
            try
            {
                if (_shopCollection == null || GetShop(shopId) == null)
                    return false;
                _shopCollection.DeleteOne(Builders<Shop>.Filter.Eq("Id", shopId));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateShop(Shop shop)
        {
            try
            {
                if (_shopCollection == null || GetShop(shop.Id.ToString()) == null)
                    return false;
                UpdateDefinition<Shop> UpdateShop = Builders<Shop>.Update
                    .Set("Address",shop.Address)
                    .Set("Products",shop.Products)
                    .Set("Name",shop.Name)
                    .Set("Receipts",shop.ReceiptList);
                _shopCollection.UpdateOne(Builders<Shop>.Filter.Eq("Id", shop.Id.ToString()), UpdateShop);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Count() => (int)_shopCollection.CountDocuments(shop => true);

        public List<Shop> GetNShops(int numberOfShops) 
        {
            try
            {
                List<Shop> listOfShops = new List<Shop>();
                listOfShops = _shopCollection.Find<Shop>(Builders<Shop>.Filter.Empty).ToList();
                if (listOfShops.Count < numberOfShops || numberOfShops == 0)
                    return listOfShops;
                else
                    return listOfShops.GetRange(0, numberOfShops);
            }
            catch
            {
                return null;
            }
        }
    }
}