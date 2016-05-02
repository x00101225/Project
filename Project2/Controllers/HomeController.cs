using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Repository;
using Project2.Entities;
using Project2.ViewModels;
namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            var repository = new PostRepository();
            var post = repository.GetById(1);

            var model = new IndexViewModel
            {
                Post = post,
                PostLikes = post.PostLikes.Count(e => e.UserLike)
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}