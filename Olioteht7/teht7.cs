/* Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.

Algoritmi:
4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht7
{
    class teht7
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Give a year: ");
            int.TryParse(Console.ReadLine(), out year);
            if (year % 400 == 0) // 400 jaolliset vuodet ovat karkausvuosia
                Console.WriteLine("Year {0} is leap year.", year);
            else if (year % 100 == 0) // täydet vuosisadat eivät ole karkausvuosia
                Console.WriteLine("Year {0} is not a leap year.", year);
            else if (year % 4 == 0) // neljällä jaolliset vuodet ovat karkausvuosia
                Console.WriteLine("Year {0} is a leap year.", year);
            else
                Console.WriteLine("Year {0} is not a leap year.", year);
            Console.ReadKey();
        }
    }
}
