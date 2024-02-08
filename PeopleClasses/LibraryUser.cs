using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeopleClasses
{
    public class LibraryUser : People
    {
        public int UserCardNumber { set; get; }
        public DateTime IssueDate { set; get; }
        public int ReaderFee { set; get; }

        public LibraryUser(string firstName, string lastName, DateTime birthDate, int userCardNumber, DateTime issueDate, int readerFee)
            : base(firstName, lastName, birthDate)
        {
            UserCardNumber = userCardNumber;
            IssueDate = issueDate;
            ReaderFee = readerFee;
        }
        public LibraryUser()
        {
            UserCardNumber = 123213;
            IssueDate = new DateTime(2024, 3, 21);
            ReaderFee = 100;
        }

        public override string ShowInfo()
        {
            return $"Name:{FirstName}; Lastname:{LastName}; BirthDate:{BirthDate}; UserCardNumber : {UserCardNumber}; " +
                $"IssueDate: {IssueDate}; ReaderFee:{ReaderFee};";
        }
    }
}
