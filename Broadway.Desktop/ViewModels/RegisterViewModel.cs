using Broadway.Desktop.Data.Models;

namespace Broadway.Desktop.ViewModels
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Roles Role { get; set; }
    }
}
