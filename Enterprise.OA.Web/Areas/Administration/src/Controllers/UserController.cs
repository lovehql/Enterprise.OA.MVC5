using Enterprise.OA.Data;
using Enterprise.OA.Web.Administration.Models;
using Enterprise.OA.Web.Infrastructure.Identity;
using Enterprise.OA.Web.Infrastructure.Services;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enterprise.OA.Web.Administration.Controllers
{
    public class UserController : Controller
    {
        private IAppUserManager _userManager;

        public UserController(IAppUserManager userManager)
        {
            if (userManager == null)
                throw new ArgumentNullException(nameof(userManager));

            _userManager = userManager;
        }

        protected IAppUserManager UserManager
        {
            get { return _userManager; }
        }

        // GET: User
        public ActionResult Index()
        {
            var result = UserManager.GetUsersAsync().Result;

            foreach (var user in result)
            {

            }

            var model = new List<UserListViewModel>();

            //var model = result
            //    .Select(m => new UserListViewModel()
            //     {
            //         UserName = m.UserName,

            //         FullName = m.UserProfile.FullName,

            //         Alias = m.UserProfile.Alias,

            //         SubsidiaryName = "aa",

            //         DepartementName = "bb"
            //     });

            return View(model);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
