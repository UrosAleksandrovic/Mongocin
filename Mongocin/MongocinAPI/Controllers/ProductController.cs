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

namespace MongocinAPI.Controllers
{
   
    
    public class ProductController : Controller
    {
        private MongoDBContext _mongoDBContext;
        private IMongoCollection<ProductModel> _productCollection;

        public ProductController() 
        {
            _mongoDBContext = new MongoDBContext();
            _productCollection = _mongoDBContext.Database.GetCollection<ProductModel>("product");
        }
        // GET: Product
        [HttpGet]
        public List<ProductModel> Get()
        {
            List<ProductModel> _products = _productCollection.AsQueryable<ProductModel>().ToList();
            return _products;
        }

        // GET: Product/Details/5
        
        public ActionResult GetOne(string id)
        {
            var _productId = new ObjectId(id);
            var _product = _productCollection.AsQueryable<ProductModel>().SingleOrDefault(x => x.Id == _productId);
            return View(_product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            try
            {
                // TODO: Add insert logic here
                _productCollection.InsertOne(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(string id)
        {
            var _productId = new ObjectId(id);
            var _product = _productCollection.AsQueryable<ProductModel>().SingleOrDefault(x => x.Id == _productId);
            return View(_product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, ProductModel product)
        {
            try
            {
                // TODO: Add update logic here
                var _filter = Builders<ProductModel>.Filter.Eq("_id", ObjectId.Parse(id));
                var _update = Builders<ProductModel>.Update
                    .Set("Name", product.Name)
                    .Set("Quantity", product.Quantity)
                    .Set("Price", product.Price)
                    .Set("Description", product.Description);
                var _result = _productCollection.UpdateOne(_filter, _update);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(string id)
        {
            var _productId = new ObjectId(id);
            var _product = _productCollection.AsQueryable<ProductModel>().SingleOrDefault(x => x.Id == _productId);
            return View(_product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, ProductModel product)
        {
            try
            {
                // TODO: Add delete logic here
                var _filter = Builders<ProductModel>.Filter.Eq("_id", ObjectId.Parse(id));

                _productCollection.DeleteOne(_filter);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
