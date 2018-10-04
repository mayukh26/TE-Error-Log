using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThirdEyeErrorLog.Context;
using ThirdEyeErrorLog.Models;

namespace ThirdEyeErrorLog.Controllers
{
    public class ErrorLists_Controller : Controller
    {
        private ErrorDBContext db = new ErrorDBContext();

        // GET: ErrorLists_
        public ActionResult Index()
        {
            return View(db.ErrorLists.ToList());
        }

        // GET: ErrorLists_/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorList errorList = db.ErrorLists.Find(id);
            if (errorList == null)
            {
                return HttpNotFound();
            }
            return View(errorList);
        }

        // GET: ErrorLists_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ErrorLists_/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Domain,Description,Status")] ErrorList errorList)
        {
            if (ModelState.IsValid)
            {
                db.ErrorLists.Add(errorList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(errorList);
        }

        // GET: ErrorLists_/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorList errorList = db.ErrorLists.Find(id);
            if (errorList == null)
            {
                return HttpNotFound();
            }
            return View(errorList);
        }

        // POST: ErrorLists_/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Domain,Description,Status")] ErrorList errorList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(errorList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(errorList);
        }

        // GET: ErrorLists_/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorList errorList = db.ErrorLists.Find(id);
            if (errorList == null)
            {
                return HttpNotFound();
            }
            return View(errorList);
        }

        // POST: ErrorLists_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ErrorList errorList = db.ErrorLists.Find(id);
            db.ErrorLists.Remove(errorList);
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
