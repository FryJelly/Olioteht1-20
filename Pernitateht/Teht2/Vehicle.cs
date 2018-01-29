using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Colour { get; set; }


        // default constructor
        public Vehicle()
        {
        }

        // return vehicle data as a one string, override Object class ToString()-method
        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " ModelYear: " + ModelYear + " Colour: " + Colour ;
        }
    }
}
