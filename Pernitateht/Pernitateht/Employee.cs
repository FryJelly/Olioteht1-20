using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pernitateht
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // default constructor
        public Employee()
        {
        }

        // constructor takes employee firstname and lastname as a parameter
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // just one method what employee can do
        public void employeeMethod()
        {
            Console.WriteLine("This method belongs to employee!");
        }

        // return employee data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " Profession: " + Profession + " Salary: " + Salary;
        }
    }
}
