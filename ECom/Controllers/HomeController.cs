using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECom.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private Services.ProductServices products = new Services.ProductServices();
        private Services.MenuServices menu = new Services.MenuServices();

        [AllowAnonymous]
        public ActionResult Index()
        {
            var data = products.GetAllProducts();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FetchMenu()
        {
            var names = menu.GetParentCategories();
            return PartialView("_LeftMenu", names);
        }

        public ActionResult Categories(string name)
        {
            var data = products.GetAllProducts(name);
            return View("Index", data);
        }
    }
}