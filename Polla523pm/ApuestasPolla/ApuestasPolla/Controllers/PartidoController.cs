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
    public class PartidoController : Controller
    {
        private PollaEntities db = new PollaEntities();

        //
        // GET: /Partido/

        public ActionResult Index()
        {
            var partido = db.Partido.Include(p => p.FasePartido);
            return View(partido.ToList());
        }

        //
        // GET: /Partido/Details/5

        public ActionResult Details(int id = 0)
        {
            Partido partido = db.Partido.Find(id);
            if (partido == null)
            {
                return HttpNotFound();
            }
            return View(partido);
        }

        //
        // GET: /Partido/Create

        public ActionResult Create()
        {
            ViewBag.IdFase = new SelectList(db.FasePartido, "IdFasePartido", "Descripcion");
            return View();
        }

        //
        // POST: /Partido/Create

        [HttpPost]
        public ActionResult Create(Partido partido)
        {
            if (ModelState.IsValid)
            {
                db.Partido.Add(partido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdFase = new SelectList(db.FasePartido, "IdFasePartido", "Descripcion", partido.IdFase);
            return View(partido);
        }

        //
        // GET: /Partido/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Partido partido = db.Partido.Find(id);
            if (partido == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdFase = new SelectList(db.FasePartido, "IdFasePartido", "Descripcion", partido.IdFase);
            return View(partido);
        }

        //
        // POST: /Partido/Edit/5

        [HttpPost]
        public ActionResult Edit(Partido partido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdFase = new SelectList(db.FasePartido, "IdFasePartido", "Descripcion", partido.IdFase);
            return View(partido);
        }

        //
        // GET: /Partido/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Partido partido = db.Partido.Find(id);
            if (partido == null)
            {
                return HttpNotFound();
            }
            return View(partido);
        }

        //
        // POST: /Partido/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Partido partido = db.Partido.Find(id);
            db.Partido.Remove(partido);
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