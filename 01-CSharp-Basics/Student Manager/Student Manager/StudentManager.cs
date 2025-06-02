using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>()
        {
            new Student("Jany", 13, "Female"),
            new Student("Selpo", 23, "Female"),
            new Student("Kida", 18, "Male")
        };

        public void Add(Student student)
        {
            students.Add(student);
        }
        public void Remove(Student student)
        {
            students.Remove(student);
        }
        public void List()
        {
            foreach (Student student in students)
            {
                student.PrintInfo();
            }
        }

        public Student FindOneByName(string name)
        {
            return students.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).First();
        }
    }
}
