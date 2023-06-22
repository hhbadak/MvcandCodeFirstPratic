using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using MVCAndCodeFirstPracticaWeb.Models;

namespace MVCAndCodeFirstPracticaWeb.Controllers
{
    public class ProductController : Controller
    {
        MVCAndCodeFirstPracticaModel db = new MVCAndCodeFirstPracticaModel();
        // GET: Product
        public ActionResult Index()
        {
            List<Products> productList = db.Products.ToList();
            return View(productList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "ID", "CompanyName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Products model)
        {
            if (ModelState.IsValid)
            {
                model.Status = true;
                db.Products.Add(model);
                db.SaveChanges();
                return RedirectToAction("Create");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "Name");
            ViewBag.SupplierID = new SelectList(db.Suppliers, "ID", "CompanyName");
            return View(model);
        }
    }
}