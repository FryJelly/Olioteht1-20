using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht4
{
    class teht4
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Insert your age: ");
            int.TryParse(Console.ReadLine(), out age);

            if (age < 18)
            {
                Console.WriteLine("Underage");
            }
            else
            {
                if (age < 65)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Senior");
                }
            }
        }
    }
}
