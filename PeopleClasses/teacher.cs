using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleClasses
{
    public class Teacher : People
    {
        public string Position { get; set; }
        public string Departament { get; set; }
        public string HEI { get; set; }
        public Teacher(string firstName, string lastName, DateTime birthDate, string position, string departament, string hEI)
        : base(firstName, lastName, birthDate)
        {
            Position = position;
            Departament = departament;
            HEI = hEI;
        }
        public Teacher()
        {
            Position = "rector";
            Departament = "IPZ";
            HEI = "ZDSU";
        }
        public override string ShowInfo()
        {
            return $"{FirstName} {LastName} {BirthDate} {Position} {Departament} {HEI}";
        }
    }
}
