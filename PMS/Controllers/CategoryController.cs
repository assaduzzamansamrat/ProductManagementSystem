using PMS.HelperClasses;
using PMSEntity;
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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (category != null)
            {
                category.IpAddress = Utilities.GetIpAddress();
                category.CreatedDate = DateTime.Now;
                this.repo.Insert(category);
                return RedirectToAction("Index", "Category");
            }
            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            Category category = this.repo.Get(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (category != null)
            {
                category.IpAddress = Utilities.GetIpAddress();
                category.CreatedDate = DateTime.Now;
                this.repo.Update(category);
                return RedirectToAction("Index", "Category");
            }
            return RedirectToAction("Index", "Category");
        }

        public ActionResult Delete(long id)
        {
            Category category = this.repo.Get(id);
            this.repo.Delete(category);
            return RedirectToAction("Index", "Category");
        }

        public ActionResult Details(long id)
        {
            Category category = this.repo.Get(id);
            return View(category);
        }
    }
}