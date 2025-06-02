using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Manager
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Student()
        {
            Name = "No name";
            Age = 0;
            Gender = "Unknown";
        }

        public Student(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }
}
