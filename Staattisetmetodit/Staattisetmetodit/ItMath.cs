using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
     public class ItMath
    {
        public static bool onkoluku;
        public static bool OnkoLuku(string input)
        {
            double retNum;
            bool onkoluku = Double.TryParse(Convert.ToString("asd"), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return onkoluku;
            
        }

    }
    public class TestBed
    {
        public static void Testing()
        {
            Console.WriteLine("S: {0}");

        }
    }
}
