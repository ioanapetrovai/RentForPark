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
    public class ComenziController : Controller
    {
        private RentContext db = new RentContext();

        // GET: Comenzi
        public ActionResult Index()
        {
            var comenzi = db.Comenzi.Include(c => c.Produs).Include(c => c.User);
            return View(comenzi.ToList());
        }

        // GET: Comenzi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comanda comanda = db.Comenzi.Find(id);
            if (comanda == null)
            {
                return HttpNotFound();
            }
            return View(comanda);
        }

        // GET: Comenzi/Create
        public ActionResult Create()
        {
            ViewBag.IdProdus = new SelectList(db.Produse, "IdProdus", "Tip");
            ViewBag.IdUser = new SelectList(db.User, "IdUser", "Nume");
            return View();
        }

        // POST: Comenzi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdComanda,IdUser,IdProdus,Cantitate,Adresa,TotalPret,DataLivrare,DataReturnare")] Comanda comanda)
        {
            if (ModelState.IsValid)
            {
                db.Comenzi.Add(comanda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProdus = new SelectList(db.Produse, "IdProdus", "Tip", comanda.IdProdus);
            ViewBag.IdUser = new SelectList(db.User, "IdUser", "Nume", comanda.IdUser);
            return View(comanda);
        }

        // GET: Comenzi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comanda comanda = db.Comenzi.Find(id);
            if (comanda == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProdus = new SelectList(db.Produse, "IdProdus", "Tip", comanda.IdProdus);
            ViewBag.IdUser = new SelectList(db.User, "IdUser", "Nume", comanda.IdUser);
            return View(comanda);
        }

        // POST: Comenzi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdComanda,IdUser,IdProdus,Cantitate,Adresa,TotalPret,DataLivrare,DataReturnare")] Comanda comanda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comanda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProdus = new SelectList(db.Produse, "IdProdus", "Tip", comanda.IdProdus);
            ViewBag.IdUser = new SelectList(db.User, "IdUser", "Nume", comanda.IdUser);
            return View(comanda);
        }

        // GET: Comenzi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comanda comanda = db.Comenzi.Find(id);
            if (comanda == null)
            {
                return HttpNotFound();
            }
            return View(comanda);
        }

        // POST: Comenzi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comanda comanda = db.Comenzi.Find(id);
            db.Comenzi.Remove(comanda);
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
