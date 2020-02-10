using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using System.Configuration;
using MongocinAPI.App_Start;
using MongoDB.Driver;
using MongocinAPI.Models;
using MongocinAPI.Models.Abstract;

namespace MongocinAPI.Controllers
{
    public class WarehouseController : Controller
    {
        private MongoDBContext _mongoDBContext;
        private IMongoCollection<Warehouse> _warehouseCollection;

        public WarehouseController()
        {
            _mongoDBContext = new MongoDBContext();
            _warehouseCollection = _mongoDBContext.Database.GetCollection<Warehouse>("warehouse");
            
        }
        [HttpGet]
        // GET: Warehouse
        public ActionResult Index()
        {
            var response = new JsonResult();
            List<Warehouse> _shops = _warehouseCollection.AsQueryable<Warehouse>().ToList();
            response.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            response.Data = _shops;
            return response;
        }
        [HttpGet]
        // GET: Warehouse/Details/5
        public ActionResult Details(int id)
        {
            var _product = _warehouseCollection.AsQueryable<Warehouse>().SingleOrDefault();
            return View(_product);
        }

       

        // POST: Warehouse/Create
        [HttpPost]
        public ActionResult Create(Warehouse warehouse)
        {
            try
            {

                // TODO: Add insert logic here
                _warehouseCollection.InsertOne(warehouse);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }

        // GET: Warehouse/Edit/5
       

        // POST: Warehouse/Edit/5
        [HttpPost]
        public ActionResult Edit(Warehouse warehouse)
        {
            try
            {
                // TODO: Add update logic here
                var _filter = Builders<Warehouse>.Filter.Eq("_id", ObjectId.Parse(warehouse.Id));
                var _update = Builders<Warehouse>.Update
                    .Set("Name", warehouse.Name)
                    .Set("Address", warehouse.Address)
                    .Set("Products", warehouse.Products)
                    .Set("Receipts", warehouse.Orders);
                var _result = _warehouseCollection.UpdateOne(_filter, _update);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }

        // GET: Warehouse/Delete/5
        

        // POST: Warehouse/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                var _filter = Builders<Warehouse>.Filter.Eq("_id", ObjectId.Parse(id));

                _warehouseCollection.DeleteOne(_filter);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }
    }
}
