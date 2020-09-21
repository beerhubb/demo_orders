using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demo_.Models;
using MongoDB.Driver;

namespace demo_.Controllers
{
    public class OrdersController : Controller
    {
        private IMongoCollection<Orders> orders;
        public OrdersController()
        {
            var dbcilent = new MongoClient("mongodb://Beeradmin:admin1234@cluster0-shard-00-00.pqdfa.azure.mongodb.net:27017,cluster0-shard-00-01.pqdfa.azure.mongodb.net:27017,cluster0-shard-00-02.pqdfa.azure.mongodb.net:27017/test?replicaSet=Cluster0-shard-0&ssl=true&authSource=admin");
            var database = dbcilent.GetDatabase("Orders");
            orders = database.GetCollection<Orders>("OrderByCustomers");
        }

        public IActionResult Index()
        {
            var result = orders.Find(it => true).ToList();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Orders data)
        {
            var neworder = new Orders
            {
                Orders_ID = Guid.NewGuid().ToString(),
                Customers = data.Customers,
                Orderdate = data.Orderdate
            };
            orders.InsertOne(neworder);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var item = orders.Find(it => it.Orders_ID == id).FirstOrDefault();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Orders data)
        {
            var item = Builders<Orders>.Update
                .Set(it => it.Customers, data.Customers)
                .Set(it => it.Orderdate, data.Orderdate);
            orders.UpdateOne(it => it.Orders_ID == data.Orders_ID, item);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(string id)
        {
            orders.DeleteOne(it => it.Orders_ID == id);
            return RedirectToAction(nameof(Index));
        }
    }
}
