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
    //VendorController vc=new VendorController();

    //VendorController vc=new VendorController(vendorService); Dependency we are injecting inside controller
    // [Authorize(Roles = StringParams.Roles.Admin)]
    public class VendorController : Controller
    {
        private readonly IVendorService _vendor;

        public VendorController(IVendorService vendor)
        {
            this._vendor = vendor;
        }

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
                var res = await _vendor.CreateVendor(model);
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
