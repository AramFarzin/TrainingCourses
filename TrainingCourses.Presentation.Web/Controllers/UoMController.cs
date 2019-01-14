using System;
using System.Collections.Generic;
using System.Web.Mvc;
using PresentationTier.Models;

namespace PresentationTier.Controllers
{
    public class UoMController : Controller
    {
        // GET: UoM
        public ActionResult Index()
        {
            var uoMs = new List<UoM>
            {
                new UoM {UoMId = new Guid(), Name = "inch"},
                new UoM {UoMId = new Guid(), Name = "kilogram"},
                new UoM {UoMId = new Guid(), Name = "Meter"},
            };
            return View(uoMs);
        }

        // GET: UoM/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: UoM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UoM/Create
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

        // GET: UoM/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: UoM/Edit/5
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

        // GET: UoM/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: UoM/Delete/5
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