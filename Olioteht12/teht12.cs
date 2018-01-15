/*Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua.Luvut tulee sijoittaa taulukkoon.Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht12
{
    class teht12
    {
        static void Main(string[] args)
        {
            int number;
            int[] array = new int[5];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Give a number: ");
                int.TryParse(Console.ReadLine(), out number);
                array[i] = number;
            }
            Console.WriteLine("Numbers are " + array[4] + ", " + array[3] + ", " + array[2] + ", " + array[1] + ", " + array[0]); //miten tämä lyhyemmin
        }
    }
}
