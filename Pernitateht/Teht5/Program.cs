using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            mouse.Name = "CM Storm Sentinel Advance";
            mouse.Price = "70 e";
            mouse.DPI = 6600;
            Console.WriteLine(mouse.ToString());

            Monitor monitor = new Monitor();
            monitor.Name = "Acer Predator";
            monitor.Price = "500 e";
            monitor.RefreshRate = "144hz";
            monitor.Resolution = "2440p";
            Console.WriteLine(monitor.ToString());


        }
    }
}
