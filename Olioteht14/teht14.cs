//Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht14
{
    class teht14
    {
        static void Main(string[] args)
        {
            int[] grades = new int[8];
            int number;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Give grades: ");
                int.TryParse(Console.ReadLine(), out number);
                grades[i] = number;
            }
        }
    }
}
