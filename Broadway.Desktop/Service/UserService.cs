using Broadway.Desktop.Data;
using Broadway.Desktop.Data.Models;
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

        public LoginResponseViewModel CreateUser(UserViewModel model)
        {
            var res = new LoginResponseViewModel();
            try
            {
                if (db.Users.Any(p => p.Email == model.Email))
                {
                    res.Message = "User is already present";
                }
                else
                {
                    var user = new User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                        Role = model.Role
                    };
                    db.Users.Add(user);
                    db.SaveChanges();

                    res.UserId = user.Id;
                    res.Role = user.Role;
                    res.Status = true;
                    res.Message = "User added successfully";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }
            return res;
        }

        public ResponseViewModel ResetPassword(string Email)
        {
            var res = new ResponseViewModel();

            try
            {
                var existingUser = db.Users.FirstOrDefault(p => p.Email.ToLower() == Email.ToLower());
                if (existingUser == null)
                {
                    res.Message = "Email does not exists";
                }
                else
                {
                    existingUser.Password = RandomString(8);
                    db.Entry(existingUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    //todo : email jaane code
                    var subject = "Password Reset";
                    var content = $"Hi {Email}, \nYour new password is {existingUser.Password}. \n\n Please login to continue.";

                    var emailres = EmailService.SendEmail(Email, content, subject);

                    res.Status = true;
                    res.Message = "Password changed successfully";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}