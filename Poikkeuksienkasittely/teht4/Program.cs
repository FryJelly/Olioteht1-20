using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {

                System.IO.StreamWriter fileInt = new System.IO.StreamWriter(@"F:\K9105\fileint.txt");
                System.IO.StreamWriter fileDouble = new System.IO.StreamWriter(@"F:\K9105\filedouble.txt");


            while (true)
            {
                string input;
                Console.Write("Give a number (end with something else) : ");
                input = Console.ReadLine();
                if (int.TryParse (input, out int i))
                {
                    Console.WriteLine("Int");
                    fileInt.WriteLine(input);
                    
                }
                else
                {
                    if (double.TryParse(input, out double f))
                    {
                        Console.WriteLine("Double");
                        fileDouble.WriteLine(input);
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }
            fileInt.Close();
            fileDouble.Close();
            Console.WriteLine("Integers: ");
            string ints = @"F:\K9105\fileint.txt";
            foreach (string s in File.ReadAllLines(ints))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Doubles: ");
            string doubles = @"F:\K9105\filedouble.txt";
            foreach (string s in File.ReadAllLines(doubles))
            {
                Console.WriteLine(s);
            }


        }
    }
}
