//Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht8
{
    class teht8
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Give a number: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Give a number: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Give a number: ");
            int.TryParse(Console.ReadLine(), out c);
            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is {0}", a);
            }
            else
            {
                if (b > a && b > c)
                {
                    Console.WriteLine("The biggest number is {0}", b);
                }
                else
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }

        }
    }
}
