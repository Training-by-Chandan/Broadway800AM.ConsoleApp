using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECom.Areas.Vendor.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Vendor/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}