using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskElreefelmasry2.DB;
using TaskElreefelmasry2.Models;

namespace TaskElreefelmasry2.Controllers
{
    public class BookletsController : Controller
    {
        Test db = new Test();
        // GET: Booklets
        public ActionResult Index()
        {
            
            return View(db.Booklets.ToList());
        }
    }
}