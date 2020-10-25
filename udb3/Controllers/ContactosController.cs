using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using udb3.Models;

namespace udb3.Controllers
{ 
    public class ContactosController : Controller
    {
        private Database1Entities db = new Database1Entities();

        //
        // GET: /Contactos/

        public ViewResult Index()
        {
            var contactos = db.Contactos.Include("TipoContacto1");
            return View(contactos.ToList());
        }

        //
        // GET: /Contactos/Create

        public ActionResult Create()
        {
            ViewBag.TipoContacto = new SelectList(db.TipoContacto, "Id", "Titulo");
            return View();
        } 

        //
        // POST: /Contactos/Create

        [HttpPost]
        public ActionResult Create(Contactos contactos)
        {
            if (ModelState.IsValid)
            {


                db.Contactos.AddObject(contactos);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.TipoContacto = new SelectList(db.TipoContacto, "Id", "Titulo", contactos.TipoContacto);
            return View(contactos);
        }
        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }

    public class Controller
    {
    }
}