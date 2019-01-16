using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TrainingCourses.Model.Customers;

namespace TrainingCourses.Presentation.Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = new Guid(), FirstName = "John"},
                new Customer {Id = new Guid(), FirstName = "Steve"},
                new Customer {Id = new Guid(), FirstName = "Bill"},
                new Customer {Id = new Guid(), FirstName = "Ram"},
                new Customer {Id = new Guid(), FirstName = "Ron"},
                new Customer {Id = new Guid(), FirstName = "Chris"},
                new Customer {Id = new Guid(), FirstName = "Rob"}
            };
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
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

        // GET: Customer/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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