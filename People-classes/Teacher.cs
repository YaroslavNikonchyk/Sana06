﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_classes
{
    internal class Teacher : People
    {
        public string Position { get; set; }
        public string Departament { get; set; }
        public string HEI { get; set; }
        public Teacher(string firstName, string lastName, DateTime birthDate, string position, string departament, string hEI)
        : base(firstName, lastName, birthDate)
        {
            Position = position;
            Departament = departament;
            HEI= hEI;
        }

    }
}