using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Broadway.Web.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string PhoneNUmber { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool Status { get; set; }
    }
}