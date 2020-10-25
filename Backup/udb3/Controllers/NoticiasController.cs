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
    public class NoticiasController : Controller
    {
        private Database1Entities db = new Database1Entities();

        //
        // GET: /Noticias/

        public ViewResult Index()
        {
            return View(db.Noticias.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}