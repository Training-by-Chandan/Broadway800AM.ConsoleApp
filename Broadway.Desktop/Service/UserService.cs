using Broadway.Desktop.Data;
using Broadway.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.Service
{
    public class UserService
    {
        public DefaultContext db = new DefaultContext();

        public LoginResponseViewModel Login(LoginViewModel model)
        {
            var res = new LoginResponseViewModel();
            try
            {
                //find the existing user
                var existingUser = db.Users.FirstOrDefault(p => p.Email.ToLower() == model.Username.ToLower());
                if (existingUser == null)
                {
                    res.Message = "User not found";
                }
                else
                {
                    if (existingUser.Password == model.Password)
                    {
                        res.Status = true;
                        res.Role = existingUser.Role;
                        res.UserId = existingUser.Id;
                        res.Message = "User Loggedin Successfully";
                    }
                    else
                    {
                        res.Message = "Password does not match.";
                    }
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }
            return res;
        }
    }
}