using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myStorefront.Controllers
{
    public class BaseController : Controller
    {
    //    public Models.Order _myOrder
    //    {
    //        get
    //        {
    //            //is _myOrder in the function
    //            if (_myOrder == null)
    //{
    //     _myOrder = _myOrder();
    //}
    //        }

        public Models.myStorefrontEntities db = new Models.myStorefrontEntities();

        public int GetOrderID()
        {
            if (Session["OrderID"] == null)
            {
                //Create new order
                var newOrder = new Models.Order();
                newOrder.dtCreated = DateTime.Now;
                newOrder.Status = "Cart";
                newOrder.SalesTax = 0;
                newOrder.Subtotal = 0;
                newOrder.ShippingCost = 0;
                newOrder.TotalPrice = 0;
                //Add order to DB
                db.Orders.Add(newOrder);
                db.SaveChanges();

                //Set the session orderID to the new orderID
                Session["OrderID"] = newOrder.OrderID;
                return newOrder.OrderID;
            }
            return int.Parse(Session["OrderID"].ToString());
        }
    }
}
