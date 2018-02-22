using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.Write("How many times do you want to throw a dice: ");
            dice.DiceThrow(Console.ReadLine());
        }
    }
}
