using Broadway.Desktop.Data;
using Broadway.Desktop.Data.Models;
using Broadway.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

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
                        UserId = userRes.UserId,
                        Gender = model.Gender
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

        public List<StudentListViewModel> GetAllStudentList(string searchStr = "")
        {
            var data = db.Students.Select(p => new StudentListViewModel
            {
                Address = p.Address,
                Dob = p.DOB,
                Email = p.User == null ? "" : p.User.Email,
                Id = p.Id,
                Name = p.Name, 
                Gender=p.Gender
            });
            if (!string.IsNullOrWhiteSpace(searchStr))
            {
                data = data.Where(p => p.Email.Contains(searchStr) || p.Name.Contains(searchStr) || p.Address.Contains(searchStr));
            }
            return data.ToList();
        }

        public ResponseViewModel DeleteStudent(int id)
        {
            var res = new ResponseViewModel();
            if (id <= 0)
            {
                res.Message = "No a valid id";
            }
            else
            {
                var data = db.Students.Find(id);
                if (data == null)
                {
                    res.Message = $"User with {id} id not found";
                }
                else
                {
                    db.Students.Remove(data);
                    db.SaveChanges();
                    res.Status = true;
                    res.Message = "User deleted successfully";
                }
            }

            return res;
        }
    }
}