using Broadway.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Broadway.Web.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? i, string name)
        {
            ViewBag.Num = i;
            ViewBag.Name = name;
            return View();
        }

        public ActionResult SearchPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchResultPage(string search)
        {
            return View();
        }

        public ActionResult IndexNew()
        {
            return View("~/Views/Home/Contact.cshtml");
        }

        public ActionResult SomeNewPage()
        {
            var data = new SomeViewModel() { Id = 1, Address = "Ktm", Name = "Chandan" };
            ViewBag.data = data;

            return View();
        }

        public ActionResult SomeNewPageV2()
        {
            var data = new SomeViewModel() { Id = 1, Address = "Ktm", Name = "Chandan" };
            return View(data);
        }
    }
}