using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.Desktop.Data.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string Class { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}