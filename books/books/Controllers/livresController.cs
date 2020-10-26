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
    public class livresController : Controller
    {
        private LivreContext db = new LivreContext();

        // GET: livres
        public ActionResult Index()
        {
            return View(db.livres.ToList());
        }

        // GET: livres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            livres livres = db.livres.Find(id);
            if (livres == null)
            {
                return HttpNotFound();
            }
            return View(livres);
        }

        // GET: livres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: livres/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,img,titre,prix,quantite,categorie")] livres livres)
        {
            if (ModelState.IsValid)
            {
                db.livres.Add(livres);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(livres);
        }

        // GET: livres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            livres livres = db.livres.Find(id);
            if (livres == null)
            {
                return HttpNotFound();
            }
            return View(livres);
        }

        // POST: livres/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,img,titre,prix,quantite,categorie")] livres livres)
        {
            if (ModelState.IsValid)
            {
                db.Entry(livres).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(livres);
        }

        // GET: livres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            livres livres = db.livres.Find(id);
            if (livres == null)
            {
                return HttpNotFound();
            }
            return View(livres);
        }

        // POST: livres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            livres livres = db.livres.Find(id);
            db.livres.Remove(livres);
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
