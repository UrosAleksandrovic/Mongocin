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
        public ActionResult Index()
        {
            var response = new JsonResult();
            List<ProductModel> _products = _productCollection.AsQueryable<ProductModel>().ToList();
            response.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            response.Data = _products;
            return response;
        }

        // GET: Product/Details/5
        [HttpGet]
        public ActionResult Details(string id)
        {   
            
            var _product = _productCollection.AsQueryable<ProductModel>().SingleOrDefault();
            return View(_product);
        }

   

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            try
            {
                // TODO: Add insert logic here
                _productCollection.InsertOne(product);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }

       

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModel product)
        {
            try
            {
                // TODO: Add update logic here
                var _filter = Builders<ProductModel>.Filter.Eq("_id", ObjectId.Parse(product.Id));
                var _update = Builders<ProductModel>.Update
                    .Set("Name", product.Name)
                    .Set("Quantity", product.Quantity)
                    .Set("Price", product.Price)
                    .Set("Description", product.Description);
                var _result = _productCollection.UpdateOne(_filter, _update);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
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
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }
    }
}
