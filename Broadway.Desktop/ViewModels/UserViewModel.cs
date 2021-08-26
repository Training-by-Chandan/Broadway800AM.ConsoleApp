using Broadway.Desktop.Data.Models;

namespace Broadway.Desktop.ViewModels
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}