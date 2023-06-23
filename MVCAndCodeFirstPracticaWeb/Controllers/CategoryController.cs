using MVCAndCodeFirstPracticaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAndCodeFirstPracticaWeb.Controllers
{
    public class CategoryController : Controller
    {

        MVCAndCodeFirstPracticaModel db = new MVCAndCodeFirstPracticaModel();
        // GET: Category
        public ActionResult Index()
        {
            List<Categories> categoryList = db.Categories.ToList();
            return View(categoryList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Categories model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Create");
            }
            return View();
        }

    }
}