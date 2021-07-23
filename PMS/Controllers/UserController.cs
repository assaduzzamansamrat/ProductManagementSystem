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
    public class UserController : Controller
    {
        private IUserRepository repo;

        public UserController(IUserRepository repo)
        {
            this.repo = repo;
        }
        // GET: User
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
        public ActionResult Create(User user)
        {
            if (user != null)
            {
                user.IpAddress = Utilities.GetIpAddress();
                user.CreatedDate = DateTime.Now;
                user.Password = Utilities.GetPasswordHash(user.Password);
                user.ConfirmPassword = Utilities.GetPasswordHash(user.ConfirmPassword);
                this.repo.Insert(user);
                return RedirectToAction("Index", "User");
            }
           return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            User user = this.repo.Get(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (user != null)
            {
                user.IpAddress = Utilities.GetIpAddress();
                user.EditedDate = DateTime.Now;
                this.repo.Update(user);
               return RedirectToAction("Index", "User");
            }
           return RedirectToAction("Index", "User");
        }

        public ActionResult Delete(long id)
        {
            User user = this.repo.Get(id);
            this.repo.Delete(user);
           return RedirectToAction("Index", "User");
        }

        public ActionResult Details(long id)
        {
            User user = this.repo.Get(id);
            return View(user);
        }
    }
}