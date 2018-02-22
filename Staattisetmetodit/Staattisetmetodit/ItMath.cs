using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    public class ItMath
    {
        public static bool IsNumber(string input)
        {
            float number;
            bool result = float.TryParse(input, out number);
            Console.Write("Input " + input + " is a number: ");
            return result;
        }

        public static bool IsDate(string input)
        {
            if (input.Contains(','))
            {
                Console.Write("Input " + input + " is a date: ");
                return false;
            }
            else
            {
                var dateFormats = new[] { "dd.MM.yyyy", "dd.MM.yy" };
                DateTime date;
                bool result = DateTime.TryParse(input, out date);
                Console.Write("Input " + input + " is a date: ");
                return result;
            }

        }
    }
}
