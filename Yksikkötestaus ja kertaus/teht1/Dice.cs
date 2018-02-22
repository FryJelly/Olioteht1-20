using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    public class Dice
    {
        public void DiceThrow(string input)
        {
            int number;
            int.TryParse(input, out number);
            List<int> numbers = new List<int>();
            List<int> ones = new List<int>();
            List<int> twos = new List<int>();
            List<int> threes = new List<int>();
            List<int> fours = new List<int>();
            List<int> fives = new List<int>();
            List<int> sixes = new List<int>();

            for (int i=0; i<number; i++)
            {
                int result;
                Random rnd = new Random();
                result = rnd.Next(1, 7);
                numbers.Add(result);
                if (result == 1) { ones.Add(result); }
                if (result == 2) { twos.Add(result); }
                if (result == 3) { threes.Add(result); }
                if (result == 4) { fours.Add(result); }
                if (result == 5) { fives.Add(result); }
                if (result == 6) { sixes.Add(result); }
                //System.Threading.Thread.Sleep(1);
            }

            Console.WriteLine("Dice is thrown " + number + " times");
            Console.WriteLine("- average is " + numbers.Average());
            Console.WriteLine("- 1 count is " + ones.Count());
            Console.WriteLine("- 2 count is " + twos.Count());
            Console.WriteLine("- 3 count is " + threes.Count());
            Console.WriteLine("- 4 count is " + fours.Count());
            Console.WriteLine("- 5 count is " + fives.Count());
            Console.WriteLine("- 6 count is " + sixes.Count());

            Console.ReadKey();
        }
    }
}
