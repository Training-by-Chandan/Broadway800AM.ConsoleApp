using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.ViewModels
{
    public class SubjectListViewModel
    {
        public int Id { get; set; }
        public string SubCode { get; set; }
        public string SubjectName { get; set; }
    }

    public class SubjectCreateViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
    }
}