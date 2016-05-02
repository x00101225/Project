using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class ElectronicsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Electronics
        public ActionResult Index()
        {
            return View(db.Electronics.ToList());
        }

        // GET: Electronics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Electronic electronic = db.Electronics.Find(id);
            if (electronic == null)
            {
                return HttpNotFound();
            }
            return View(electronic);
        }

        // GET: Electronics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Electronics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Location,SubGenre,Comment,Link")] Electronic electronic)
        {
            if (ModelState.IsValid)
            {
                db.Electronics.Add(electronic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(electronic);
        }

        // GET: Electronics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Electronic electronic = db.Electronics.Find(id);
            if (electronic == null)
            {
                return HttpNotFound();
            }
            return View(electronic);
        }

        // POST: Electronics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Location,SubGenre,Comment,Link")] Electronic electronic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(electronic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(electronic);
        }

        // GET: Electronics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Electronic electronic = db.Electronics.Find(id);
            if (electronic == null)
            {
                return HttpNotFound();
            }
            return View(electronic);
        }

        // POST: Electronics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Electronic electronic = db.Electronics.Find(id);
            db.Electronics.Remove(electronic);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
