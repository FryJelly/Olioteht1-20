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
            int[] table = new int[5];
            
            for (int i = 0; i < table.Length; i++)
            {
                Console.Write("Give a number: ");
                int.TryParse(Console.ReadLine(), out number);
                table[i] = number;
            }
            Console.WriteLine("Numbers are " + table[4] + ", " + table[3] + ", " + table [2] + ", " + table[1] + ", " + table[0]); //miten tämä lyhyemmin
        }
    }
}
