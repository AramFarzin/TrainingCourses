using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TrainingCourses.Model.Orders;

namespace TrainingCourses.Presentation.Web.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            var orders = new List<Order>
            {
                new Order {Id = new Guid(), Name = "o1"},
                new Order {Id = new Guid(), Name = "o2"},
                new Order {Id = new Guid(), Name = "o3"},
                new Order {Id = new Guid(), Name = "o4"},
                new Order {Id = new Guid(), Name = "o5"},
                new Order {Id = new Guid(), Name = "o6"},
            };
            return View(orders);
        }

        // GET: Order/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
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

        // GET: Order/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
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

        // GET: Order/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
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