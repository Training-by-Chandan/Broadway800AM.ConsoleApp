using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }

        [Obsolete("Use HashedPwd instead of Password", true)]
        [NotMapped]// we added this when the references was changed to 0
        public string Password { get; set; }

        public string HashPwd { get; set; }

        public Roles Role { get; set; }
    }
}