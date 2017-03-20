using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad3.Models;

namespace zad3
{
    class AddPresenceMenuBinding
    {
        public List<Student> Students { get; private set; }
        public List<Course> Courses { get; private set; }
        public string[] Values { get; private set; }

        public AddPresenceMenuBinding(List<Student> students, List<Course> courses)
        {
            Students = students;
            Courses = courses;
            Values = new string[2] { "Tak", "Nie" };
        }
    }
}
