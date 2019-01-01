using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class ContactController : Controller
    {
        public static List<Contact> Contacts { get; set; }

        static ContactController()
        {
            Contacts = new List<Contact>
            {
                new Contact()
                {
                    Id = 1,
                    FirstName = "Aram",
                    LastName = "Farzin"
                },
                new Contact()
                {
                    Id = 2,
                    FirstName = "Azar",
                    LastName = "Yasami"
                },
                new Contact()
                {
                    Id = 3,
                    FirstName = "Sara",
                    LastName = "Farzin"
                },
            };
        }

        // GET : Contacts
        [HttpGet]
        public ActionResult Get()
        {
            return View(Contacts);
        }

        [HttpGet]
        public ActionResult GetActives()
        {
            return View(Contacts.Where(c=> c.Status == Status.فعال));
        }

        // GET: Contact
        [HttpGet]
        [ActionName("Edit")]
        public ActionResult GetByKey(int id)
        {
            var contact = Contacts.Where(c => c.Id == id).FirstOrDefault();
            return View(contact);
        }

        // UPDATE: Contact
        [HttpPut]
        [ActionName("Update")]
        public ActionResult Put(int id)
        {
            var contact = Contacts.Where(c => c.Id == id).FirstOrDefault();
            return RedirectToAction("Get");
        }

        // GET: Contact
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create(Contact contact)
        {
            Contacts.Add(contact);
            return RedirectToAction("Get");
        }

        // GET: Contact
        [HttpDelete]
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var contact = Contacts.Where(c => c.Id == id).FirstOrDefault();
            Contacts.Remove(contact);
            return RedirectToAction("Get");
        }
    }
}
