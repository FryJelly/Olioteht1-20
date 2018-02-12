using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Names names = new Names();

                names.PrintNames();
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
