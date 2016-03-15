using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stripe;

namespace Project2.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay
        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult Charge()
        {
            return View();
        }

    }


}