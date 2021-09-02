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
    public class SubjectService
    {
        private DefaultContext db = new DefaultContext();

        public List<SubjectListViewModel> GetAllSubjects()
        {
            var data = db.Subjects.Select(p => new SubjectListViewModel
            {
                Id = p.Id,
                SubCode = p.SubCode,
                SubjectName = p.SubjectName
            });

            return data.ToList();
        }

        public ResponseViewModel CreateSubject(SubjectCreateViewModel model)
        {
            var res = new ResponseViewModel();

            try
            {
                int? clsid = null;
                var cls = db.Class.FirstOrDefault(p => p.Class == model.Class);
                if (cls != null)
                {
                    clsid = cls.Id;
                }

                var subject = new Subject()
                {
                    SubCode = model.Code,
                    SubjectName = model.Name,
                    ClassId = clsid
                };
                db.Subjects.Add(subject);
                db.SaveChanges();

                res.Status = true;
                res.Message = "Subject Created Successfully";
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }
    }
}