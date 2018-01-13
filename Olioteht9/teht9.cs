//Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht9
{
    class teht9
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            Console.Write("Give a number: "); int.TryParse(Console.ReadLine(), out number);
            sum = number + sum;
            while (number > 0 || number < 0)
            {
                Console.Write("Give a number: "); int.TryParse(Console.ReadLine(), out number);
                sum = number + sum;
            }
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
