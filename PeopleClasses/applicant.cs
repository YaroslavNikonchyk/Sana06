using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleClasses
{
    public class Applicant : People
    {
        public int EIEScore { get; set; }
        public int EducationDocumentScore { get; set; }
        public string HEI { get; set; }

        public Applicant(string firstName, string lastName, DateTime birthDate, int eieScore, int educationDocumentScore, string hEI)
          : base(firstName, lastName, birthDate)
        {
            EIEScore = eieScore;
            EducationDocumentScore = educationDocumentScore;
            HEI = hEI;
        }
        public Applicant()
        {
            EIEScore = 150;
            EducationDocumentScore = 10;
            HEI = "ZSPU";
        }
        public override string ShowInfo()
        {
            return $"Name:{FirstName}; Lastname:{LastName}; BirthDate:{BirthDate}; EIEscore: {EIEScore}; EducationDocumentScore: {EducationDocumentScore}; HEI:{HEI}";
        }
    }
}
