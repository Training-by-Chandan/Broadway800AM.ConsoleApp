using ECom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECom.Services
{
    public interface IMenuServices
    {
        List<string> GetParentCategories();
    }

    public class MenuServices : IMenuServices
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public List<string> GetParentCategories()
        {
            return db.Categories.Where(p => p.ParentId == null).Select(p => p.Name).ToList();
        }
    }
}
