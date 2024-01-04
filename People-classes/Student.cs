using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_classes
{
    internal class Student : People
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string HEI { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, int course, string group, string faculty, string hEI)
            : base(firstName, lastName, birthDate)

        {
            Course = course;
            Group = group;
            Faculty = faculty;
            HEI = hEI;
        }

        public Student() { }

    }
}
