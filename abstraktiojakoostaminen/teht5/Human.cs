using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Human : Mammal
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public int Height { get; set; }

        public void Move()
        {
            Console.WriteLine("I move");
        }
        public void Grow(int age)
        {
            Age = age;
        }
    }
}
