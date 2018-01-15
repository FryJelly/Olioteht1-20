//Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht13
{
    class teht13
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int number, points = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Give points: ");
                int.TryParse(Console.ReadLine(), out number);
                array[i] = number;
            }
            points = array[0] + array[1] + array[2] + array[3] + array[4] - array.Max() - array.Min();
            Console.WriteLine("Total points are " + points);
        }
    }
}
