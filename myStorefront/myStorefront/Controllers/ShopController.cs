using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myStorefront.Models;

namespace myStorefront.Controllers
{
    public class ShopController : Controller
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
            return View(category);
        }

    }
}
