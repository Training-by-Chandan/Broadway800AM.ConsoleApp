using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.Data.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubCode { get; set; }
        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Classes { get; set; }
    }
}