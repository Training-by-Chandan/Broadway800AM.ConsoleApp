using ECom.Areas.Admin.Services;
using ECom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ECom.Areas.Admin.Controllers
{
    [Authorize(Roles = StringParams.Roles.Admin)]
    public class VendorController : Controller
    {
        // GET: Admin/Vendor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(VendorCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var vendor = new VendorService();
                var res = await vendor.CreateVendor(model);
                if (res.Status)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }
    }
}