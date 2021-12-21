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
    public class DDTSinhVien486Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: DDTSinhVien486
        public ActionResult Index()
        {
            var dDTSinhVien486 = db.DDTSinhVien486.Include(d => d.LopHoc486);
            return View(dDTSinhVien486.ToList());
        }

        // GET: DDTSinhVien486/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DDTSinhVien486 dDTSinhVien486 = db.DDTSinhVien486.Find(id);
            if (dDTSinhVien486 == null)
            {
                return HttpNotFound();
            }
            return View(dDTSinhVien486);
        }

        // GET: DDTSinhVien486/Create
        public ActionResult Create()
        {
            ViewBag.MaLop = new SelectList(db.LopHoc486, "Malop", "TenLop");
            return View();
        }

        // POST: DDTSinhVien486/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSinhVien,HoTen,MaLop")] DDTSinhVien486 dDTSinhVien486)
        {
            if (ModelState.IsValid)
            {
                db.DDTSinhVien486.Add(dDTSinhVien486);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLop = new SelectList(db.LopHoc486, "Malop", "TenLop", dDTSinhVien486.MaLop);
            return View(dDTSinhVien486);
        }

        // GET: DDTSinhVien486/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DDTSinhVien486 dDTSinhVien486 = db.DDTSinhVien486.Find(id);
            if (dDTSinhVien486 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLop = new SelectList(db.LopHoc486, "Malop", "TenLop", dDTSinhVien486.MaLop);
            return View(dDTSinhVien486);
        }

        // POST: DDTSinhVien486/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSinhVien,HoTen,MaLop")] DDTSinhVien486 dDTSinhVien486)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dDTSinhVien486).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLop = new SelectList(db.LopHoc486, "Malop", "TenLop", dDTSinhVien486.MaLop);
            return View(dDTSinhVien486);
        }

        // GET: DDTSinhVien486/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DDTSinhVien486 dDTSinhVien486 = db.DDTSinhVien486.Find(id);
            if (dDTSinhVien486 == null)
            {
                return HttpNotFound();
            }
            return View(dDTSinhVien486);
        }

        // POST: DDTSinhVien486/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DDTSinhVien486 dDTSinhVien486 = db.DDTSinhVien486.Find(id);
            db.DDTSinhVien486.Remove(dDTSinhVien486);
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
