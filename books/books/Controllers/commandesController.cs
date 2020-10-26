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
    public class commandesController : Controller
    {
        private commandeContext db = new commandeContext();

        // GET: commandes
        public ActionResult Index()
        {
            return View(db.commandes.ToList());
        }

        // GET: commandes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            commande commande = db.commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            return View(commande);
        }

        // GET: commandes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: commandes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nomclient,prixcommande")] commande commande)
        {
            if (ModelState.IsValid)
            {
                db.commandes.Add(commande);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(commande);
        }

        // GET: commandes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            commande commande = db.commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            return View(commande);
        }

        // POST: commandes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nomclient,prixcommande")] commande commande)
        {
            if (ModelState.IsValid)
            {
                db.Entry(commande).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(commande);
        }

        // GET: commandes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            commande commande = db.commandes.Find(id);
            if (commande == null)
            {
                return HttpNotFound();
            }
            return View(commande);
        }

        // POST: commandes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            commande commande = db.commandes.Find(id);
            db.commandes.Remove(commande);
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
