using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Peripherals
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public Peripherals()
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + " Price: " + Price;
        }
    }
}
