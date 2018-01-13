//Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht5
{
    class teht5
    {
        static void Main(string[] args)
        {
            int seconds;
            Console.WriteLine("Give seconds: ");
            int.TryParse(Console.ReadLine(), out seconds);
            TimeSpan t = TimeSpan.FromSeconds(seconds); // otetaan aika timespaniin käyttäjän antamien sekuntien avulla
            Console.Write("Seconds can be shown as "+ t.Hours + " hours "+ t.Minutes + " minutes and "+ t.Seconds + " seconds. \n"); //tuodaan timespanista hours, minutes ja seconds arvot
            Console.ReadKey();
        }
    }
}
