using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myStorefront.Controllers
{
    public class CartController : BaseController
    {


        //
        // GET: /Cart/

        public ActionResult Index()
        {
            //return Content(GetOrderID().ToString());
            return View(db.Orders.Find(GetOrderID().ToString()));
        }


    }
}
