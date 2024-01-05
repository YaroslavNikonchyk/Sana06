using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleClasses
{
    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public People(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public People()
        {
            FirstName = "David";
            LastName = "Paklin";
            BirthDate = new DateTime(2005, 9, 16);
        }

        public virtual string ShowInfo()
        {
            return $"{FirstName} {LastName} {BirthDate}";
        }
    }
}
