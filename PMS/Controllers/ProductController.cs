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
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (product != null)
            {
                product.IpAddress = Utilities.GetIpAddress();
                product.CreatedDate = DateTime.Now;
                this.repo.Insert(product);
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            Product product = this.repo.Get(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (product != null)
            {
                product.IpAddress = Utilities.GetIpAddress();
                product.EditedDate = DateTime.Now;
                this.repo.Update(product);
                return RedirectToAction("Index", "Product");
            }
            return RedirectToAction("Index", "Product");
        }

        public ActionResult Delete(long id)
        {
            Product product = this.repo.Get(id);
            this.repo.Delete(product);
            return RedirectToAction("Index", "Product");
        }

        public ActionResult Details(long id)
        {
            Product product = this.repo.Get(id);
            return View(product);
        }
    }
}