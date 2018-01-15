using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht11
{
    class teht11
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Give a number: ");
            int.TryParse(Console.ReadLine(), out number);
            for (int i = 0; i < number; i++)
            {
                for (int b = -1; b < i; b++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }
                
        }
    }
}
