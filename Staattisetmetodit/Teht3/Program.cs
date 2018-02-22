using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1-10 integers separated by ,");
            string input = Console.ReadLine();

             Console.WriteLine("Merkkijonossa " + input + " on " + ItParser.Count(input) + " lukua, lukujen summa on " + ItParser.Sum(input) + " ja keskiarvo on " + ItParser.Average(input));
        }
    }
}
