/* Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. Tulosta lopuksi lajitellun taulukon sisältö.

Esimerkkitoiminta:


    Numbers in an array 1: 10,20,30,40,50
    Numbers in an array 2: 5,15,25,35,45
    Numbers in the combined array: 5,10,15,20,25,30,35,40,45,50*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht17
{
    class teht17
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 20, 30, 40, 50 };
            int[] array2 = { 5, 15, 25, 35, 45 };
            int[] comarray = new int[array1.Length + array2.Length];
            Array.Copy(array1, comarray, array1.Length);
            Array.Copy(array2, 0, comarray, array1.Length, array2.Length);
            Array.Sort(comarray);
            Console.WriteLine(string.Join(", ", comarray));

        }
    }
}
