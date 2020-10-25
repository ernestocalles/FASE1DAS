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
    public class CarrerasController : Controller
    {
        private Database1Entities db = new Database1Entities();

        //
        // GET: /Carreras/

        public ViewResult Index()
        {
            var carreras = db.Carreras.Include("TipoCarrera1");
            return View(carreras.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}