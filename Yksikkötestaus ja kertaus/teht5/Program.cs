using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

            Console.WriteLine("Sum = " + Math.Round(ArrayCalcs.Sum(array), 2));
            Console.WriteLine("Avg = " + Math.Round(ArrayCalcs.Average(array), 2));
            Console.WriteLine("Min = " + Math.Round(ArrayCalcs.Min(array), 2));
            Console.WriteLine("Max = " + Math.Round(ArrayCalcs.Max(array), 2));
            Console.ReadKey();
        }
    }
}
