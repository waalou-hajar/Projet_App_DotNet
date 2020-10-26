using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using books.Data;
using books.Models;

namespace books.Controllers
{
    public class paniersController : Controller
    {
        private panierContext db = new panierContext();

        // GET: paniers
        public ActionResult Index()
        {
            return View(db.paniers.ToList());
        }

        // GET: paniers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panier panier = db.paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // GET: paniers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: paniers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nomcl,prixtotal")] panier panier)
        {
            if (ModelState.IsValid)
            {
                db.paniers.Add(panier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(panier);
        }

        // GET: paniers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panier panier = db.paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // POST: paniers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nomcl,prixtotal")] panier panier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(panier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(panier);
        }

        // GET: paniers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            panier panier = db.paniers.Find(id);
            if (panier == null)
            {
                return HttpNotFound();
            }
            return View(panier);
        }

        // POST: paniers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            panier panier = db.paniers.Find(id);
            db.paniers.Remove(panier);
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
