using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myStorefront.Models;

namespace myStorefront.Controllers
{
    public class ShopController : BaseController
    {
        
        private myStorefrontEntities db = new myStorefrontEntities();

        //
        // GET: /Shop/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ByCategory(int id)
        {
            //If you want to return only one item
            var category = db.Categories.Find(id);
            category.AllProducts = db.GetProductsByCategoryID(id).ToList();
            return View(category);
        }

        [HttpGet]
        public ActionResult Product(int id)
        {
            //Get the product from DB
            var product = db.Products.Find(id);
            //Pass it to the view
            return View(product);
        }

        [HttpPost]
        public ActionResult Product(int id, FormCollection values)
        {
            int qty = int.Parse(values["qty"]);
            int orderID = GetOrderID();
            //Get our oorder
            db.Orders.Find(orderID);
            //Make a new order line
            var orderLine = new Models.OrderLine();
            orderLine.ProductID = id;
            orderLine.Quantity = qty;
            orderLine.UnitPrice = decimal.Parse(values["price"]);
            orderLine.OrderID = orderID;

            //Add the order line to the database
            db.OrderLines.Add(orderLine);
            db.SaveChanges();

            var product = db.Products.Find(id);
            ViewBag.SuccessMessage = "Added " + qty + " to the cart.";

            return View(product);
        }
    }
}
