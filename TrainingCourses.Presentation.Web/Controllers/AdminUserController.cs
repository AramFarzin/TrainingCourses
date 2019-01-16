//using System;
//using System.Collections.Generic;
//using System.Web.Mvc;
//using TrainingCourses.Presentation.Web.Models;

//namespace TrainingCourses.Presentation.Web.Controllers
//{
//    public class AdminUserController : Controller
//    {
//        // GET: User
//        public ActionResult Index()
//        {
//            var users = new List<User>
//            {
//                new User {UserId = new Guid(), UserName = "John"},
//                new User {UserId = new Guid(), UserName = "Steve"},
//                new User {UserId = new Guid(), UserName = "Bill"},
//                new User {UserId = new Guid(), UserName = "Ram"},
//                new User {UserId = new Guid(), UserName = "Ron"},
//                new User {UserId = new Guid(), UserName = "Chris"},
//                new User {UserId = new Guid(), UserName = "Rob"}
//            };

//            return View(users);
//        }

//        // GET: User/Details/5
//        public ActionResult Details(Guid id)
//        {
//            return View();
//        }

//        // GET: User/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: User/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: User/Edit/5
//        public ActionResult Edit(Guid id)
//        {
//            return View();
//        }

//        // POST: User/Edit/5
//        [HttpPost]
//        public ActionResult Edit(Guid id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: User/Delete/5
//        public ActionResult Delete(Guid id)
//        {
//            return View();
//        }

//        // POST: User/Delete/5
//        [HttpPost]
//        public ActionResult Delete(Guid id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}