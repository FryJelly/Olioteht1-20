using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Object
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Year { get; set; }

        public Object()
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + " Weight: " + Weight + " Year: " + Year;
        }
    }
}
