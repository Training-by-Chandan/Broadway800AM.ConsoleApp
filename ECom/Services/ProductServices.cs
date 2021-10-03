using ECom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECom.Services
{
    public class ProductServices
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<ViewModels.ProductsViewModel> GetAllProducts(string categoryName = "")
        {
            var res = new List<ViewModels.ProductsViewModel>();
            try
            {
                var product = db.Products.ToList();
                if (!string.IsNullOrWhiteSpace(categoryName))
                {
                    product = product.Where(p => p.Category.Name == categoryName || (p.Category.ParentCategory != null && p.Category.ParentCategory.Name == categoryName)).ToList();
                }

                res = product.Select(p => new ViewModels.ProductsViewModel
                {
                    Id = p.Id,
                    Description = p.Description,
                    Name = p.Name,
                    Picture = p.PicturePath,
                    Price = p.Price
                }).ToList();
            }
            catch (Exception ex)
            {
            }

            return res;
        }
    }
}