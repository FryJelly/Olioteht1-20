using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Drinks
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Amount { get; set; }

        public Drinks(string name, string brand, int amount)
        {
            Name = name;
            Brand = brand;
            Amount = amount;
        }

        ~Drinks()
        {

        }
    }
}
