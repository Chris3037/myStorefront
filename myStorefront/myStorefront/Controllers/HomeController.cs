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
            return View(/*list*/);
        }

        public ActionResult Navigation()
        {
            var categories = db.Categories.Where(x => x.ParentID == null);
            return PartialView(categories);
        }

        public ActionResult Breadcrumbs(int id)
        {
            //Get our category
            var category = db.Categories.Find(id);
            //Create a new list to return our breadcrumbs
            var breadcrumbList = new List<Models.Category>();
            //TODO: figure out how t fill the list with a loop
            while (category.ParentID != null)
            {
                breadcrumbList.Add(category);
                category = category.ParentCategory;
            }
            //add the root parent category to the list
            breadcrumbList.Add(category);
            //reverse and return the list
            breadcrumbList.Reverse();
            return PartialView("breadcrumbs", breadcrumbList);
        }
    }
}
