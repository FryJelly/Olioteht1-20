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

                System.IO.StreamWriter fileint = new System.IO.StreamWriter(@"F:\K9105\fileint.txt");
                System.IO.StreamWriter filefloat = new System.IO.StreamWriter(@"F:\K9105\filefloat.txt");


            while (true)
            {
                string input;
                Console.Write("Give a number (end with something else) : ");
                input = Console.ReadLine();
                if (int.TryParse (input, out int i))
                {
                    Console.WriteLine("Int");
                    fileint.WriteLine(input);
                    fileint.Close();
                }
                else
                {
                    if (float.TryParse(input, out float f))
                    {
                        Console.WriteLine("Float");
                        filefloat.WriteLine(input);
                        filefloat.Close();
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
