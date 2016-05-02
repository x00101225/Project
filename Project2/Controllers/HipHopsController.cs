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
    public class HipHopsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HipHops
        public ActionResult Index()
        {
            return View(db.HipHops.ToList());
        }

        // GET: HipHops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HipHop hipHop = db.HipHops.Find(id);
            if (hipHop == null)
            {
                return HttpNotFound();
            }
            return View(hipHop);
        }

        // GET: HipHops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HipHops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactId,Name,Location,SubGenre,Comment,Link")] HipHop hipHop)
        {
            if (ModelState.IsValid)
            {
                db.HipHops.Add(hipHop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hipHop);
        }

        // GET: HipHops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HipHop hipHop = db.HipHops.Find(id);
            if (hipHop == null)
            {
                return HttpNotFound();
            }
            return View(hipHop);
        }

        // POST: HipHops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactId,Name,Location,SubGenre,Comment,Link")] HipHop hipHop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hipHop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hipHop);
        }

        // GET: HipHops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HipHop hipHop = db.HipHops.Find(id);
            if (hipHop == null)
            {
                return HttpNotFound();
            }
            return View(hipHop);
        }

        // POST: HipHops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HipHop hipHop = db.HipHops.Find(id);
            db.HipHops.Remove(hipHop);
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
