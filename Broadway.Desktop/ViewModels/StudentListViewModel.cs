using Broadway.Desktop.Data.Models;
using System;

namespace Broadway.Desktop.ViewModels
{
    public class StudentListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Gender? Gender { get; set; }
        public string Class { get; set; }
    }
}