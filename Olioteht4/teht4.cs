//Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". 
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
