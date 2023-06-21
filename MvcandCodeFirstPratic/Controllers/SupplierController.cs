using MvcandCodeFirstPratic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcandCodeFirstPratic.Controllers
{
    public class SupplierController : Controller
    {
        CodeFirstPraticDB db = new CodeFirstPraticDB();
        // GET: Supplier
        public ActionResult Index()
        {
            List<Suppliers> supplierList = db.Suppliers.ToList();
            return View(supplierList);
        }
    }
}