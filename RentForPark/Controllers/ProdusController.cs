using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentForPark.DAL;
using RentForPark.Models;

namespace RentForPark.Controllers
{
    public class ProdusController : Controller
    {
        private RentContext db = new RentContext();

        // GET: Produs
        public ActionResult Index()
        {
            return View(db.Produse.ToList());
        }

        // GET: Produs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produs produs = db.Produse.Find(id);
            if (produs == null)
            {
                return HttpNotFound();
            }
            return View(produs);
        }

        // GET: Produs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProdus,Tip,Nume,Descriere,Pret")] Produs produs)
        {
            if (ModelState.IsValid)
            {
                db.Produse.Add(produs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produs);
        }

        // GET: Produs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produs produs = db.Produse.Find(id);
            if (produs == null)
            {
                return HttpNotFound();
            }
            return View(produs);
        }

        // POST: Produs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProdus,Tip,Nume,Descriere,Pret")] Produs produs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produs);
        }

        // GET: Produs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produs produs = db.Produse.Find(id);
            if (produs == null)
            {
                return HttpNotFound();
            }
            return View(produs);
        }

        // POST: Produs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produs produs = db.Produse.Find(id);
            db.Produse.Remove(produs);
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
