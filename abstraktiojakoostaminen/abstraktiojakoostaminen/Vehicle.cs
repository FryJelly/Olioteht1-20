using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Vehicle
    {
        public List<Tyre> Tyres;
        public string Name { get; set; }
        public string Model { get; set; }

        public Vehicle(string name, string model)
        {
            this.Model = model;
            this.Name = name;
            this.Tyres = new List<Tyre>();
        }

        ~Vehicle()
        {
            Console.WriteLine();
        }
        public void PrintVehicle()
        {
            Console.WriteLine("Vehicle name: " + Name + Model);
            foreach (Tyre tyre in Tyres)
            {
                Console.WriteLine(tyre);
            }
        }

    }
}
