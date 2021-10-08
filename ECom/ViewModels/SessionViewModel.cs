using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECom.ViewModels
{
    public class SessionViewModel
    {
        public SessionViewModel()
        {
            this.Lists = new List<SessionItemsViewModel>();
        }

        public List<SessionItemsViewModel> Lists { get; set; }

        public void AddProductToSession(Guid Id)
        {
            var item = this.Lists.FirstOrDefault(p => p.ProductId == Id);
            if (item == null)
            {
                this.Lists.Add(new SessionItemsViewModel { ProductId = Id, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }
        }

        public int GetTotalCount()
        {
            return this.Lists.Sum(p => p.Quantity);
        }
    }

    public class SessionItemsViewModel
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class SessionItemDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double Total
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }
    }
}