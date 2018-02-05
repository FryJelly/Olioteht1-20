using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Adult : Human
    {
        public string Car { get; set; }
        public override void Move()
        {
            Console.WriteLine("Walking");
        }

        public override void PrintData()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Height: " + Height + " Car: " + Car);
        }
    }
}
