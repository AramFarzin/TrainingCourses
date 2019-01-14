using System;
using System.Collections.Generic;
using System.Web.Mvc;
using PresentationTier.Models;

namespace PresentationTier.Controllers
{
    public class OrderDetailController : Controller
    {
        // GET: OrderDetail
        public ActionResult Index()
        {
            var order = new Order(){ OrderId = new Guid(), Name = "Test"};
            var product = new Product(){ ProductId = new Guid(), ProductKey = "Test"};
            var orderDetails = new List<OrderDetail>
            {
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product},
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product},
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product},
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product},
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product},
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product},
                new OrderDetail {OrderDetailId = new Guid(), Order = order, Product = product}
            };
            return View(orderDetails);
        }

        // GET: OrderDetail/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: OrderDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderDetail/Create
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

        // GET: OrderDetail/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: OrderDetail/Edit/5
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

        // GET: OrderDetail/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: OrderDetail/Delete/5
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