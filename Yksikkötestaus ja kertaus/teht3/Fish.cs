using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Fish
    {
        public string Species { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }

        public Fish(string species, int length, double weight)
        {
            Species = species;
            Length = length;
            Weight = weight;
        }
    }
}
