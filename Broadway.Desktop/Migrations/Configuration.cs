namespace Broadway.Desktop.Migrations
{
    using Broadway.Desktop.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Broadway.Desktop.Data.DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Broadway.Desktop.Data.DefaultContext db)
        {
            var adminUser = new User() { Email = "admin@admin.com", HashPwd = Hashes.CreateMd5Hash("Admin@123"), Role = Roles.Admin };
            var teacherUser = new User() { Email = "teacher@teacher.com", HashPwd = Hashes.CreateMd5Hash("Teacher@123"), Role = Roles.Teacher };
            var studentUser = new User() { Email = "student@student.com", HashPwd = Hashes.CreateMd5Hash("Student@123"), Role = Roles.Student };

            var existingadmin = db.Users.FirstOrDefault(p => p.Email.ToLower() == adminUser.Email.ToLower());
            if (existingadmin == null)
            {
                db.Users.Add(adminUser);
                db.SaveChanges();
            }

            var existingteacher = db.Users.FirstOrDefault(p => p.Email.ToLower() == teacherUser.Email.ToLower());
            if (existingteacher == null)
            {
                db.Users.Add(teacherUser);
                db.SaveChanges();
            }

            var existingStudent = db.Users.FirstOrDefault(p => p.Email.ToLower() == studentUser.Email.ToLower());
            if (existingStudent == null)
            {
                db.Users.Add(studentUser);
                db.SaveChanges();
            }

            #region Change Password to Hash

            //var users = db.Users.Where(p => p.HashPwd == null);
            //foreach (var item in users)
            //{
            //    item.HashPwd = Hashes.CreateMd5Hash(item.Password);
            //    db.Entry(item).State = EntityState.Modified;
            //}
            //db.SaveChanges();

            #endregion Change Password to Hash
        }
    }
}