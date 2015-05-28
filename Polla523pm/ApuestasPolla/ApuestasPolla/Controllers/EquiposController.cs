﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ApuestasPolla.Models;

namespace ApuestasPolla.Controllers
{
    public class EquiposController : Controller
    {
        private PollaEntities db = new PollaEntities();

        //
        // GET: /Equipos/

        public ActionResult Index()
        {
            var equipo = db.Equipo.Include(e => e.Grupo);
            return View(equipo.ToList());
        }

        //
        // GET: /Equipos/Details/5

        public ActionResult Details(int id = 0)
        {
            Equipo equipo = db.Equipo.Find(id);
            if (equipo == null)
            {
                return HttpNotFound();
            }
            return View(equipo);
        }

        //
        // GET: /Equipos/Create

        public ActionResult Create()
        {
            ViewBag.IdGrupo = new SelectList(db.Grupo, "IdGrupo", "Descripcion");
            return View();
        }

        //
        // POST: /Equipos/Create

        [HttpPost]
        public ActionResult Create(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                db.Equipo.Add(equipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdGrupo = new SelectList(db.Grupo, "IdGrupo", "Descripcion", equipo.IdGrupo);
            return View(equipo);
        }

        //
        // GET: /Equipos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Equipo equipo = db.Equipo.Find(id);
            if (equipo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdGrupo = new SelectList(db.Grupo, "IdGrupo", "Descripcion", equipo.IdGrupo);
            return View(equipo);
        }

        //
        // POST: /Equipos/Edit/5

        [HttpPost]
        public ActionResult Edit(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdGrupo = new SelectList(db.Grupo, "IdGrupo", "Descripcion", equipo.IdGrupo);
            return View(equipo);
        }

        //
        // GET: /Equipos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Equipo equipo = db.Equipo.Find(id);
            if (equipo == null)
            {
                return HttpNotFound();
            }
            return View(equipo);
        }

        //
        // POST: /Equipos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Equipo equipo = db.Equipo.Find(id);
            db.Equipo.Remove(equipo);
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