using PMSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class ProductController : Controller
    {
        private ICategoryRepository catRepo;
        private IProductRepository repo;

        public ProductController(IProductRepository repo, ICategoryRepository catRepo)
        {
            this.repo = repo;
            this.catRepo = catRepo;
        }

        public ActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
           // ViewBag.Categories = this.catRepo.GetAll();
            return View();
        }
    }
}