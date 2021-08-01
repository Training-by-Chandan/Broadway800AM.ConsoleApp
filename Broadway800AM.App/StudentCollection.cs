using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    internal class StudentCollection : ICollection<Student>
    {
        private ICollection<Student> studentList { get; set; }
        private int _count;

        public int Count
        {
            get { return _count; }
        }

        public bool IsReadOnly => false;

        public StudentCollection()
        {
            studentList = GenerateDummyData();
        }

        private static List<Student> GenerateDummyData()
        {
            var listoStudent = new List<Student>();
            listoStudent.Add(new Student { id = 1, Name = "Chandan", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 2, Name = "Kasturi", Email = "kasturi@gmail.com" });
            listoStudent.Add(new Student { id = 3, Name = "Bikash", Email = "bikash@gmail.com" });
            listoStudent.Add(new Student { id = 4, Name = "Bibek", Email = "Bibek@gmail.com" });
            listoStudent.Add(new Student { id = 5, Name = "Bijay", Email = "Bijay@gmail.com" });
            listoStudent.Add(new Student { id = 6, Name = "Saroj", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 7, Name = "Niroj", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 8, Name = "binita", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 9, Name = "Pratik", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 10, Name = "John", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 11, Name = "Charles", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 12, Name = "Tony", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 13, Name = "Steve", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 14, Name = "Nick", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 15, Name = "Barton", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 16, Name = "Natasha", Email = "chandan@gmail.com" });
            listoStudent.Add(new Student { id = 17, Name = "Bucky", Email = "chandan@gmail.com" });

            return listoStudent;
        }

        public void Add(Student item)
        {
            //
        }

        public void Clear()
        {
            //studentList.Clear();
        }

        public bool Contains(Student item)
        {
            return studentList.Contains(item);
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return studentList.GetEnumerator();
        }

        public bool Remove(Student item)
        {
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}