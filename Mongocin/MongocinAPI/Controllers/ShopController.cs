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


    public class ShopController : Controller
    {
        private MongoDBContext _mongoDBContext;
        private IMongoCollection<Shop> _shopCollection;

        public ShopController()
        {
            _mongoDBContext = new MongoDBContext();
            _shopCollection = _mongoDBContext.Database.GetCollection<Shop>("shop");
        }
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            var response = new JsonResult();
            List<Shop> _shops = _shopCollection.AsQueryable<Shop>().ToList();
            response.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            response.Data = _shops;
            return response;
        }

        // GET: Product/Details/5
        [HttpGet]
        public ActionResult Details(string id)
        {

            var _product = _shopCollection.AsQueryable<Shop>().SingleOrDefault();
            return View(_product);
        }



        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Shop shop)
        {
            try
            {
              
                // TODO: Add insert logic here
                _shopCollection.InsertOne(shop);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }



        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Shop shop)
        {
            try
            {
                // TODO: Add update logic here
                var _filter = Builders<Shop>.Filter.Eq("_id", ObjectId.Parse(shop.Id));
                var _update = Builders<Shop>.Update
                    .Set("Name", shop.Name)
                    .Set("Address", shop.Address)
                    .Set("Products", shop.Products)
                    .Set("Receipts", shop.Receipts);
                var _result = _shopCollection.UpdateOne(_filter, _update);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }



        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                var _filter = Builders<Shop>.Filter.Eq("_id", ObjectId.Parse(id));

                _shopCollection.DeleteOne(_filter);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }
    }
}
