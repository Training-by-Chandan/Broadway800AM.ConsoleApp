using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECom.ViewModels
{
    public class ProductsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }

        public static List<ProductsViewModel> GenerateDummyData()
        {
            var list = new List<ProductsViewModel>();
            list.Add(new ProductsViewModel() { Id = Guid.NewGuid(), Name = "Nike Shoes", Picture = "/Themes/dist/img/prod-1.jpg", Price = 80.50 });
            list.Add(new ProductsViewModel() { Id = Guid.NewGuid(), Name = "Goldstar Shoes", Picture = "/Themes/dist/img/prod-1.jpg", Price = 85.50 });
            list.Add(new ProductsViewModel() { Id = Guid.NewGuid(), Name = "Some Shoes", Picture = "/Themes/dist/img/prod-1.jpg", Price = 30.50 });
            list.Add(new ProductsViewModel() { Id = Guid.NewGuid(), Name = "Other Shoes", Picture = "/Themes/dist/img/prod-1.jpg", Price = 50.0 });
            list.Add(new ProductsViewModel() { Id = Guid.NewGuid(), Name = "Latest Shoes", Picture = "/Themes/dist/img/prod-1.jpg", Price = 70.0 });
            return list;
        }
    }
}