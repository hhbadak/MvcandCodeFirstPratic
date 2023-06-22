using MVCAndCodeFirstPracticaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAndCodeFirstPracticaWeb.Controllers
{
    public class SupplierController : Controller
    {
        MVCAndCodeFirstPracticaModel db = new MVCAndCodeFirstPracticaModel();
        // GET: Supplier
        public ActionResult Index()
        {
            List<Suppliers> supplierList = db.Suppliers.ToList();
            return View(supplierList);
        }
    }
}