//Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron): 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht2
{
    class teht2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give point limit: ");
            string line = Console.ReadLine();
            int number = 0;

            if (int.TryParse(line, out number))
            {
                switch (number)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("School number is 0");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("School number is 1");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("School number is 2");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("School number is 3");
                        break;
                    case 8:
                    case 9:
                        Console.WriteLine("School number is 4");
                        break;
                    case 10:
                    case 11:
                    case 12:
                        Console.WriteLine("School number is 5");
                        break;

                    default:
                        Console.WriteLine("Not a number between 0-12");
                        break;

                }
            }

        }
    }
}
