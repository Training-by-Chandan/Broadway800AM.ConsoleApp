using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string HashedPwd
        {
            get { return Hashes.CreateMd5Hash(Password); }
        }
    }
}