using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Broadway800AM.App.EF;

namespace Broadway800AM.App
{
    public class DatabaseV2
    {
        public OurEntities db = new OurEntities();

        public void GetAll()
        {
            var data = db.tbls.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"{item.id}\t{item.firstname} {item.lastname}");
            }
        }

        public void Add()
        {
            var tblObj = new tbl();

            Console.WriteLine("Enter First name");
            tblObj.firstname = Console.ReadLine();
            Console.WriteLine("Enter last name");
            tblObj.lastname = Console.ReadLine();
            Console.WriteLine("Enter Gender (M/F)");
            tblObj.gender = Console.ReadLine();
            Console.WriteLine("Enter Address");
            tblObj.address = Console.ReadLine();
            Console.WriteLine("Enter age");
            tblObj.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter City");
            tblObj.city = Console.ReadLine();
            Console.WriteLine("Enter country");
            tblObj.country = Console.ReadLine();

            db.tbls.Add(tblObj);
            db.SaveChanges();
        }

        public void Edit()
        {
            Console.WriteLine("Enter id");
            var id = Convert.ToInt32(Console.ReadLine());
            var tblObj = db.tbls.Find(id);
            if (tblObj != null)
            {
                Console.WriteLine("Enter First name");
                tblObj.firstname = Console.ReadLine();
                Console.WriteLine("Enter last name");
                tblObj.lastname = Console.ReadLine();
                Console.WriteLine("Enter Gender (M/F)");
                tblObj.gender = Console.ReadLine();
                Console.WriteLine("Enter Address");
                tblObj.address = Console.ReadLine();
                Console.WriteLine("Enter age");
                tblObj.age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter City");
                tblObj.city = Console.ReadLine();
                Console.WriteLine("Enter country");
                tblObj.country = Console.ReadLine();

                db.Entry(tblObj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No record found for {id}");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter id");
            var id = Convert.ToInt32(Console.ReadLine());
            var tblObj = db.tbls.Find(id);
            if (tblObj != null)
            {
                db.tbls.Remove(tblObj);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No record found for {id}");
            }
        }

        public void StudentParentView()
        {
            var data = db.vw_studentparentView.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"{item.studentname}\t{item.FatherName}\t{item.MotherName}");
            }
        }
    }
}