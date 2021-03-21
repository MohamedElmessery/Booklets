using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskElreefelmasry2.DB;

namespace TaskElreefelmasry2.Controllers
{
    public class BookletSalesController : Controller
    {
        Test db = new Test();
        // GET: BookletSales
        public ActionResult Index()
        {
            return View(db.BookletSales.ToList());
        }
    }
}