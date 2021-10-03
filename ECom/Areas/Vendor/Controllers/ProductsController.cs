using ECom.Models;
using ECom.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ECom.Areas.Vendor.Controllers
{
    public class ProductsController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();

        // GET: Vendor/Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.categoriesList = db.Categories.Select(p => new SelectListItem { Text = p.Name, Value = p.Id.ToString() });
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = User.Identity.GetUserId();
                var vendorId = db.Vendors.FirstOrDefault(p => p.UserId == currentUserId).Id;

                var extension = System.IO.Path.GetExtension(model.PicturePath.FileName);
                var file = Guid.NewGuid().ToString() + extension;
                model.PicturePath.SaveAs(Server.MapPath("~/Uploaded/Product/" + file));

                var product = new Product()
                {
                    Name = model.Name,
                    CategoryId = model.CategoryId,
                    Description = model.Description,
                    PicturePath = "/Uploaded/Product/" + file,
                    VendorId = vendorId, 
                    Price=model.Price
                };
                db.Products.Add(product);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}