using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace myStorefront.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            try
            {
                //Create the user
                var newUser = Membership.CreateUser("test123", "test", "test@test.com");

                //To login a user
                FormsAuthentication.SetAuthCookie("test123", true);

                //To validate a user 
                if (Membership.ValidateUser("test123", "test"))
                {
                    //Log them in
                }
                else
                {
                    //The user name/ password is incorrect
                    //ViewBag.ErrorMessage = "The user name or password is incorrect";
                    //return View();
                }
            }
            catch (Exception exeption)
            {
                ViewBag.ErrorMessage = exeption.Message;
                //return Content(exeption.Message);
            }

            return PartialView("index", "account");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("index", "home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Models.Login login)
        {
            if (Membership.ValidateUser(login.Username, login.Password))
            {
                //Valid User
                FormsAuthentication.SetAuthCookie(login.Username, false);
                return RedirectToAction("index", "home");
            }
            else
            {
                //Invalid User
                ViewBag.ErrorMessage = "Invalid user name or password. Please try again";
                return View(login);
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.Register register)
        {
            try
            {
                var user = Membership.CreateUser(register.Username, register.Password, register.Email);
                FormsAuthentication.SetAuthCookie(register.Username, false);
                return RedirectToAction("index", "home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View(register);
            }
        }
    }
}
