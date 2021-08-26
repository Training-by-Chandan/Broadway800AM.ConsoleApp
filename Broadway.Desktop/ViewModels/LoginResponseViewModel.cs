using Broadway.Desktop.Data.Models;

namespace Broadway.Desktop.ViewModels
{
    public class LoginResponseViewModel : ResponseViewModel
    {
        public Roles Role { get; set; }
        public int UserId { get; set; }
    }
}