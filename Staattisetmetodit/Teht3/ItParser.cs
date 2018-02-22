using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    public class ItParser
    {
        public int Input;
        public static int Count(string input)
        {
            string[] numbers = input.Split(',');
            int result = numbers.Count();
            return result;
        }

        public static int Sum(string input)
        {
            string[] numbers = input.Split(',');
            int result = numbers.Sum(int.Parse);
            return result;

        }

        public static int Average(string input)
        {
            string[] numbers = input.Split(',');
            int result = numbers.Sum(int.Parse) / numbers.Count();
            
            return result;
        }
    }
}
