using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCndEF;

namespace MVCndEF.Controllers
{
    public class BankingTBLsController : Controller
    {
        private BankingEntities db = new BankingEntities();

        // GET: BankingTBLs
        public ActionResult Index()
        {
            return View(db.BankingTBLs.ToList());
        }

        // GET: BankingTBLs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankingTBL bankingTBL = db.BankingTBLs.Find(id);
            if (bankingTBL == null)
            {
                return HttpNotFound();
            }
            return View(bankingTBL);
        }

        // GET: BankingTBLs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankingTBLs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Account_Type,Balance")] BankingTBL bankingTBL)
        {
            if (ModelState.IsValid)
            {
                db.BankingTBLs.Add(bankingTBL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankingTBL);
        }

        // GET: BankingTBLs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankingTBL bankingTBL = db.BankingTBLs.Find(id);
            if (bankingTBL == null)
            {
                return HttpNotFound();
            }
            return View(bankingTBL);
        }

        // POST: BankingTBLs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Account_Type,Balance")] BankingTBL bankingTBL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankingTBL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankingTBL);
        }

        // GET: BankingTBLs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankingTBL bankingTBL = db.BankingTBLs.Find(id);
            if (bankingTBL == null)
            {
                return HttpNotFound();
            }
            return View(bankingTBL);
        }

        // POST: BankingTBLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BankingTBL bankingTBL = db.BankingTBLs.Find(id);
            db.BankingTBLs.Remove(bankingTBL);
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
