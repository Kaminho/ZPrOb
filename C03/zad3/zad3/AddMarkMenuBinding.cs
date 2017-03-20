using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad3.Models;

namespace zad3
{
    class AddMarkMenuBinding
    {
        public List<Student> Students { get; private set; }
        public List<Course> Courses { get; private set; }
        public double[] Values { get; private set; }

        public AddMarkMenuBinding(List<Student> students, List<Course> courses)
        {
            Students = students;
            Courses = courses;
            Values = new double[11] { 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.5, 6.0 };
        }
    }
}
