using MongocinAPI.App_Start;
using MongocinAPI.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MongocinAPI.Controllers
{

    public class OrderController : Controller
    {
        private MongoDBContext _dbContext;
        private IMongoCollection<Order> _orderCollection;

        public OrderController()
        {
            _dbContext = new MongoDBContext();
            _orderCollection = _dbContext.Database.GetCollection<Order>("Order");
        }

        // GET: Order
        public ActionResult Index()
        {
            var response = new JsonResult();
            response.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            response.Data = _orderCollection.Find(order => true).ToList();
            return response;
        }

        // GET: Order/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            Order order = _orderCollection.AsQueryable<Order>().SingleOrDefault();
            return View(order);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Order order)
        {
            try
            {
                _orderCollection.InsertOne(order);
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            Order order = _orderCollection.AsQueryable<Order>().SingleOrDefault();
            return View(order);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
           try
            {
                /*var Filter = Builders<Order>.Filter.Eq("_id", ObjectId.Parse(id));
                var update = Builders<Order>.Update.Set("")*/
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
