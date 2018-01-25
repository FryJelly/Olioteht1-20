//Toteuta jokin oma villi-ideasi ja yllätä opettaja toteutuksellasi. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Olioteht20
{
    class teht20
    {
        static void Main(string[] args)
        {
            // yatzy
            int number;
            Random rand = new Random();
            int[] array = new int[5];
            Console.WriteLine("Welcome to the worst Yatzy diceroller you've ever seen!");
            Console.Write("Press enter to throw dice: ");
            Console.ReadLine();
                for (int i = 0; i < array.Length; i++)
                {
                    number = rand.Next(1, 7);
                    array[i] = number;
                    Console.WriteLine(number);
                }
                if (array[0] == array[1] && array[1] == array[2] && array[2] == array[3] && array[3] == array[4] && array[4] == array[5])
                {
                    Console.WriteLine("Yatzy!!!");
                }
                else
                {
                    Console.WriteLine("You lose, better luck next time.");
                }
        }
    }
}
