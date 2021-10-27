using ECom.Models;
using ECom.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ECom.Areas.Admin.Services
{
    public class VendorService : IVendorService
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public VendorService()
        {
            var userStore = new UserStore<ApplicationUser>(db);
            _userManager = new UserManager<ApplicationUser>(userStore);
            var roleStore = new RoleStore<IdentityRole>(db);
            _roleManager = new RoleManager<IdentityRole>(roleStore);
        }

        public async Task<ResponeViewModel> CreateVendor(VendorCreateViewModel model)
        {
            var res = new ResponeViewModel();
            try
            {
                //create a user
                var user = new ApplicationUser { UserName = model.Email, Email = model.Email, FirstName = model.Firstname, LastName = model.Lastname };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //Assign Vendor role to that user
                    await _userManager.AddToRoleAsync(user.Id, StringParams.Roles.Vendor);

                    //create a vendor
                    var vendor = new ECom.Models.Vendor()
                    {
                        Id = Guid.NewGuid(),
                        UserId = user.Id
                    };
                    db.Vendors.Add(vendor);
                    db.SaveChanges();
                    res.Message = "Vendor Created Successfully";
                    res.Status = true;
                }
                res.Message = string.Join(", ", result.Errors.ToArray());
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }
    }

    public interface IVendorService
    {
        Task<ResponeViewModel> CreateVendor(VendorCreateViewModel model);
    }
}
