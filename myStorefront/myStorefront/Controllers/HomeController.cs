using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myStorefront.Controllers
{
    public class HomeController : Controller
    {
        Models.myStorefrontEntities db = new Models.myStorefrontEntities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            var list = db.Products.OrderByDescending(x => x.ProductPrice);
            return View(list);
        }

        public ActionResult getNav()
        {
            var list = db.Categories.OrderBy(x => x.CategoryName);
            return PartialView(list);
        }
    }
}
