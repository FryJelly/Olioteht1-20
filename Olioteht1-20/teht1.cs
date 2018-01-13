//Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht1_20
{
    class teht1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number 1, 2 tai 3.");
            string line = Console.ReadLine();
            int number = 0;   
            
            if (int.TryParse(line, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;

                    default:
                        Console.WriteLine("This is not 1, 2 or 3.");
                        break;
                }
            }
            else
            {

            }
        }
    }
}
