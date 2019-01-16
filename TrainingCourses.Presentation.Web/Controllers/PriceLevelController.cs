using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TrainingCourses.Model.PriceLevels;

namespace TrainingCourses.Presentation.Web.Controllers
{
    public class PriceLevelController : Controller
    {
        // GET: PriceLevel
        public ActionResult Index()
        {
            var priceLevels = new List<PriceLevel>
            {
                new PriceLevel {Id = new Guid(), Name = "l1"},
                new PriceLevel {Id = new Guid(), Name = "l2"},
                new PriceLevel {Id = new Guid(), Name = "l3"},
                new PriceLevel {Id = new Guid(), Name = "l4"}
            };
            return View(priceLevels);
        }

        // GET: PriceLevel/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: PriceLevel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PriceLevel/Create
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

        // GET: PriceLevel/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: PriceLevel/Edit/5
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

        // GET: PriceLevel/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: PriceLevel/Delete/5
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