using MvcandCodeFirstPratic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcandCodeFirstPratic.Controllers
{
    public class CategoryController : Controller
    {
        CodeFirstPraticDB db = new CodeFirstPraticDB();
        // GET: Category
        public ActionResult Index()
        {
            List<Categories> categoryList = db.Categories.ToList();
            return View(categoryList);
        }
    }
}