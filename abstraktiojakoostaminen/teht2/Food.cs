using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Food
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Amount { get; set; }

        public Food(string name, string brand, int amount)
        {
            Name = name;
            Brand = brand;
            Amount = amount;
        }

        ~Food()
        {

        }
    }
}
