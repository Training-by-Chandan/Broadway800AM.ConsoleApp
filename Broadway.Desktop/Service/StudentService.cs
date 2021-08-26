using Broadway.Desktop.Data;
using Broadway.Desktop.Data.Models;
using Broadway.Desktop.ViewModels;
using System;

namespace Broadway.Desktop.Service
{
    public class StudentService
    {
        public DefaultContext db = new DefaultContext();

        public ResponseViewModel CreateStudent(StudentCreateViewModel model)
        {
            var res = new ResponseViewModel();
            try
            {
                UserService us = new UserService();
                UserViewModel uvm = new UserViewModel()
                {
                    Email = model.Email,
                    Password = model.Password,
                    Role = Roles.Student
                };
                var userRes = us.CreateUser(uvm);
                if (userRes.Status)
                {
                    var student = new Student()
                    {
                        Address = model.Address,
                        DOB = model.Dob,
                        Name = model.Name,
                        UserId = userRes.UserId
                    };
                    db.Students.Add(student);
                    db.SaveChanges();

                    res.Status = true;
                    res.Message = "Student created successfully";
                }
                else
                {
                    res.Message = userRes.Message;
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