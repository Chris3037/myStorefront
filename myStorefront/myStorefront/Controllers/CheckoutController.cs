using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using AuthorizeNet;namespace myStorefront.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreditCardTest()
        {
            //What sends our transaction request
            Gateway target = new Gateway("7es9Ud9Zj2TH", "93LxQ9m54wUh26Y7", true);
            //Creating an authorization request

            IGatewayRequest request = new AuthorizationRequest("5424000000000015", "0224", (decimal)20.10, "AuthCap transaction approved testing", true);
            string description = "AuthCap transaction approved testing";
            IGatewayResponse response = target.Send(request, description);
            request.Address = "123 Main St. Denver CO 80203";
            
            return Content("OK");
        }
    }
}
