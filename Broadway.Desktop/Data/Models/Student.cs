using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Broadway.Desktop.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public Gender? Gender { get; set; }
        public int? UserId { get; set; }

        public int? ClassId { get; set; }

        [ForeignKey("ClassId")]
        public virtual Classes Class { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1,
        Others = 2
    }
}