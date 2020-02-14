using MongocinAPI.App_Start;
using MongocinAPI.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace MongocinAPI.Services
{
    public class WarehouseService
    {
        private MongoDBContext _dbContext;
        private IMongoCollection<Warehouse> _warehouseCollection;

        public WarehouseService()
        {
            _dbContext = new MongoDBContext();
            _warehouseCollection = _dbContext.Database.GetCollection<Warehouse>
                (ConfigurationManager.AppSettings["WarehouseCollectionName"]);
        }

        public Warehouse GetWarehouse(string warehouseId)
        {
            try
            {
                FilterDefinition<Warehouse> Filer = Builders<Warehouse>.Filter.Eq("Id", warehouseId);
                List<Warehouse> Results = _warehouseCollection.Find(Filer).ToList();
                if (Results.Count == 0)
                    return null;

                return Results.First();
            }
            catch
            {
                return null;
            }
        }

        public bool InsertWarehouse(Warehouse Warehouse)
        {
            try
            {
                if (_warehouseCollection == null)
                    return false;
                Warehouse.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
                Warehouse prevWarehouse = GetWarehouse(Warehouse.Id.ToString());
                if (prevWarehouse == null)
                {
                    _warehouseCollection.InsertOne(Warehouse);
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteWarehouse(string warehouseId)
        {
            try
            {
                if (_warehouseCollection == null || GetWarehouse(warehouseId) == null)
                    return false;
                _warehouseCollection.DeleteOne(Builders<Warehouse>.Filter.Eq("Id", warehouseId));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateWarehouse(Warehouse warehouse)
        {
            try
            {
                if (_warehouseCollection == null || GetWarehouse(warehouse.Id.ToString()) == null)
                    return false;
                UpdateDefinition<Warehouse> UpdateWarehouse = Builders<Warehouse>.Update
                    .Set("Address", warehouse.Address)
                    .Set("Products", warehouse.Products)
                    .Set("Name",warehouse.Name)
                    .Set("Orders",warehouse.Orders);
                _warehouseCollection.UpdateOne(Builders<Warehouse>.Filter.Eq("Id", warehouse.Id.ToString()), UpdateWarehouse);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int Count() => (int)_warehouseCollection.CountDocuments(warehouse => true);

        public List<Warehouse> GetNWarehouses(int numberOfWarehouses)
        {
            try
            {
                List<Warehouse> listOfWarehouses = new List<Warehouse>();
                listOfWarehouses = _warehouseCollection.Find<Warehouse>(Builders<Warehouse>.Filter.Empty).ToList();
                if (listOfWarehouses.Count < numberOfWarehouses || numberOfWarehouses == 0)
                    return listOfWarehouses;
                else
                    return listOfWarehouses.GetRange(0, numberOfWarehouses);
            }
            catch
            {
                return null;
            }
        }
    }
}