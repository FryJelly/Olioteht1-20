using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class TestBed
    {
        public void TestBedFloat()
        {
            Console.Write("Your input: ");
            string input = Console.ReadLine();
            Console.WriteLine(ItMath.IsNumber(input));
        }
        public void TestBedDate()
        {
            Console.Write("Your input: ");
            string input = Console.ReadLine();
            Console.WriteLine(ItMath.IsDate(input));
        }
    }
}
