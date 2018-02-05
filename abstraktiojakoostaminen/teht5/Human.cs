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

        public override void Move()
        {
            Console.WriteLine("I move");
        }
        public void Grow(int age)
        {
            age++;
            Age = age;
        }

        public override void PrintData()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Height: " + Height);
        }
    }
}
