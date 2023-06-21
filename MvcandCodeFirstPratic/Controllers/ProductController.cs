using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using MvcandCodeFirstPratic.Models;


namespace MvcandCodeFirstPratic.Controllers
{
    public class ProductController : Controller
    {
        CodeFirstPraticDB db = new CodeFirstPraticDB();
        // GET: Product
        public ActionResult Index()
        {
            List<Products> productList = db.Products.ToList();
            return View(productList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Categories, "ID", "Name");
            ViewBag.ID = new SelectList(db.Suppliers, "ID", "CompanyName");
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
            ViewBag.ID = new SelectList(db.Categories, "ID", "Name");
            ViewBag.ID = new SelectList(db.Suppliers, "ID", "CompanyName");
            return View(model);
        }
    }
}