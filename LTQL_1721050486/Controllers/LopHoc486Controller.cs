using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050486.Models;

namespace LTQL_1721050486.Controllers
{
    public class LopHoc486Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: LopHoc486
        public ActionResult Index()
        {
            return View(db.LopHoc486.ToList());
        }

        // GET: LopHoc486/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc486 lopHoc486 = db.LopHoc486.Find(id);
            if (lopHoc486 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc486);
        }

        // GET: LopHoc486/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc486/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Malop,TenLop")] LopHoc486 lopHoc486)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc486.Add(lopHoc486);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc486);
        }

        // GET: LopHoc486/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc486 lopHoc486 = db.LopHoc486.Find(id);
            if (lopHoc486 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc486);
        }

        // POST: LopHoc486/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Malop,TenLop")] LopHoc486 lopHoc486)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc486).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc486);
        }

        // GET: LopHoc486/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc486 lopHoc486 = db.LopHoc486.Find(id);
            if (lopHoc486 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc486);
        }

        // POST: LopHoc486/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc486 lopHoc486 = db.LopHoc486.Find(id);
            db.LopHoc486.Remove(lopHoc486);
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
