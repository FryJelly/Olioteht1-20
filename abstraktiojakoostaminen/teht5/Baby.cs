using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Baby : Human
    {
        public string Diaper { get; set; }
        public override void Move()
        {
            Console.WriteLine("Crawling");
        }

        public override void PrintData()
        {
            Console.WriteLine("Name: " + Name + " Age: " + Age + " Weight: " + Weight + " Height: " + Height + " Diaper: " + Diaper);
        }
    }
}
