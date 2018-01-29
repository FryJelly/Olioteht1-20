using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pernitateht
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one Employee object
            Employee employee = new Employee();
            employee.FirstName = "Kirsi";
            employee.LastName = "Kernel";
            employee.Profession = "Principal";
            employee.Salary = 1200;
            Console.WriteLine("Employee:");
            Console.WriteLine(employee.ToString());
            Console.WriteLine();

            // create one Boss Object
            Boss boss = new Boss();
            boss.FirstName = "Jukka";
            boss.LastName = "Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;
            Console.WriteLine("Boss: ");
            Console.WriteLine(boss.ToString());
            Console.WriteLine();

            employee.FirstName = "Kirsi";
            employee.LastName = "Kernel";
            employee.Profession = "Head Principal";
            employee.Salary = 2200;
            Console.WriteLine("Employee:");
            Console.WriteLine(employee.ToString());
            Console.WriteLine();


            // do something methods
            //employee.employeeMethod(); // This method belongs to employee!
            //boss.EmployeeMethod(); // This method belongs to employee! (derived class can use it!)
            //boss.BossMethod(); // This method belongs to Boss!
        }
    }
}
