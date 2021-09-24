using Broadway.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway.Web.Controllers
{
    public class StudentNewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentNew
        [HttpGet]
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
            else
            {
                return View(student);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }
    }
}