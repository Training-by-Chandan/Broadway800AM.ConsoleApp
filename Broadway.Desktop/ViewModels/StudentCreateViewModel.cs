using Broadway.Desktop.Data.Models;
using System;

namespace Broadway.Desktop.ViewModels
{
    public class StudentCreateViewModel
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
    }
}