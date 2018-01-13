/* Tee ohjelma, joka alustaa sovellukseen käyttöön seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht10
{
    class teht10
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine("{0} HEP ", numbers[i]);
            }
            else
            {
                    Console.WriteLine(numbers[i]);
            };
        }
    }
}
