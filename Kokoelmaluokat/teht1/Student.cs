using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioID { get; set; }
        public string Group { get; set; }

        public Student(string firstName, string lastName, string asioID, string group)
        {
            FirstName = firstName;
            LastName = lastName;
            AsioID = asioID;
            Group = group;
        }
    }
}
