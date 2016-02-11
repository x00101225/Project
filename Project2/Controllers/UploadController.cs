using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Project2.Models;

namespace Project2.Controllers
{
    public class UploadController : Controller
    {
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(UploadModel u)
        {
            return View(u);
        }
    }
}