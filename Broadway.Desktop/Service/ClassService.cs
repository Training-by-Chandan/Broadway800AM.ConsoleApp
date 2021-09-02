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
    public class ClassService
    {
        private DefaultContext db = new DefaultContext();

        public ResponseViewModel CreateClass(string classname)
        {
            var res = new ResponseViewModel();
            try
            {
                var existingclass = db.Class.FirstOrDefault(p => p.Class == classname);
                if (existingclass == null)
                {
                    var classModel = new Classes()
                    {
                        Class = classname
                    };
                    db.Class.Add(classModel);
                    db.SaveChanges();

                    res.Status = true;
                    res.Message = "class created successfully";
                }
                else
                {
                    res.Message = "class with that name already exists";
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }

        public List<ClassListViewModel> GetAllClass(string query = "")
        {
            var data = db.Class.Select(p => new ClassListViewModel
            {
                Id = p.Id,
                ClassName = p.Class
            });
            if (!string.IsNullOrWhiteSpace(query))
            {
                data = data.Where(p => p.ClassName.Contains(query));
            }
            return data.ToList();
        }

        public List<StudentListViewModel> GetAllStudentByClassId(int id)
        {
            var list = new List<StudentListViewModel>();

            var existingClass = db.Class.Find(id); ;
            if (existingClass != null)
            {
                var students = existingClass.Students.Select(p => new StudentListViewModel
                {
                    Address = p.Address,
                    Dob = p.DOB,
                    Email = p.User != null ? p.User.Email : "",
                    Gender = p.Gender,
                    Id = p.Id,
                    Name = p.Name
                });
                list = students.ToList();
            }

            return list;
        }

        public List<string> GetAllClassName()
        {
            var data = db.Class.Select(p => p.Class);
            return data.ToList();
        }
    }
}