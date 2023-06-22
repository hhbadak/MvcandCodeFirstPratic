using MVCAndCodeFirstPracticaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAndCodeFirstPracticaWeb.Controllers
{
    public class DefaultController : Controller
    {
        MVCAndCodeFirstPracticaModel db = new MVCAndCodeFirstPracticaModel();
        // GET: Default
        public ActionResult Index()
        {
            return View();
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