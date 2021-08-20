using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App.CF
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {
        }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public virtual ObjectResult<Teacher> DemoStoredProc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Teacher>("DemoStroredProcNew");
        }
    }

    public class People
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }
    }

    [Table("Teacher_info")]
    public class Teacher
    {
        [Key]
        public Guid TeacherId { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Address { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; } = true;
        public DateTime DateofJoining { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Class { get; set; }
        public Guid TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public virtual Teacher Teachers { get; set; }
    }
}