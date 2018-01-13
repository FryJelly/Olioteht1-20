//Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht3
{
    class teht3
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.Write("Enter three numbers: ");
            int.TryParse(Console.ReadLine(), out a); //kokeillaan onko input numero ja jos on tulee ulos int tyypin a arvo
            int.TryParse(Console.ReadLine(), out b); 
            int.TryParse(Console.ReadLine(), out c);
            sum = a + b + c; // summa = a+b+c
            Console.Write("Sum={0} ", sum);
            float average = sum / 3; // keskiarvo on = (a+b+c)/3
            Console.Write("Average={0} ", average);
            Console.ReadKey();
        }

    }
}
