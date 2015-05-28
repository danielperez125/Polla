using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApuestasPolla.Models;

namespace ApuestasPolla.Controllers
{
    public class TipoPuntajeController : Controller
    {
        private PollaEntities db = new PollaEntities();

        //
        // GET: /TipoPuntaje/

        public ActionResult Index()
        {
            return View(db.TipoPuntaje.ToList());
        }

        //
        // GET: /TipoPuntaje/Details/5

        public ActionResult Details(int id = 0)
        {
            TipoPuntaje tipopuntaje = db.TipoPuntaje.Find(id);
            if (tipopuntaje == null)
            {
                return HttpNotFound();
            }
            return View(tipopuntaje);
        }

        //
        // GET: /TipoPuntaje/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoPuntaje/Create

        [HttpPost]
        public ActionResult Create(TipoPuntaje tipopuntaje)
        {
            if (ModelState.IsValid)
            {
                db.TipoPuntaje.Add(tipopuntaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipopuntaje);
        }

        //
        // GET: /TipoPuntaje/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TipoPuntaje tipopuntaje = db.TipoPuntaje.Find(id);
            if (tipopuntaje == null)
            {
                return HttpNotFound();
            }
            return View(tipopuntaje);
        }

        //
        // POST: /TipoPuntaje/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoPuntaje tipopuntaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipopuntaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipopuntaje);
        }

        //
        // GET: /TipoPuntaje/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TipoPuntaje tipopuntaje = db.TipoPuntaje.Find(id);
            if (tipopuntaje == null)
            {
                return HttpNotFound();
            }
            return View(tipopuntaje);
        }

        //
        // POST: /TipoPuntaje/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoPuntaje tipopuntaje = db.TipoPuntaje.Find(id);
            db.TipoPuntaje.Remove(tipopuntaje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}