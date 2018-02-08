using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            foreach (Card card in cards)
            {
                Console.WriteLine((card.Pos+1) + "Kortti on " + card.House + "#" + card.Number);
            }
        }
    }
}
