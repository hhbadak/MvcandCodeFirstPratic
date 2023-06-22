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
    }
}