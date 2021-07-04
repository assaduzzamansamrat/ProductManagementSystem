using PMSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repo;

        public CategoryController(ICategoryRepository repo)
        {
            this.repo = repo;
        }

        public ActionResult Index()
        {
            return View(this.repo.GetAll());
        }
    }
}