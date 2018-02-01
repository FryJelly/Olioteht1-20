using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Porsche = new Vehicle("Porsche", "model 911");
            Tyre Nokia = new Tyre("Hakkapeliitta", "Nokia", "205R16");
            Porsche.Tyres.Add(Nokia);
            Porsche.Tyres.Add(Nokia);
            Porsche.Tyres.Add(Nokia);
            Porsche.Tyres.Add(Nokia);

            Porsche.PrintVehicle();
            Nokia.PrintTyre();


            GC.Collect();
            Console.ReadKey();
        }
    }
}
