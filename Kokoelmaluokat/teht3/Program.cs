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

            try
            {
                List<Card> cards = new List<Card>();
                for (int i = 1; i > 0 && i < 14; i++)
                {
                    cards.Add(new Card { House = "Spade", Number = i });
                }
                for (int i = 1; i > 0 && i < 14; i++)
                {
                    cards.Add(new Card { House = "Heart", Number = i });
                }
                for (int i = 1; i > 0 && i < 14; i++)
                {
                    cards.Add(new Card { House = "Diamond", Number = i });
                }
                for (int i = 1; i > 0 && i < 14; i++)
                {
                    cards.Add(new Card { House = "Club", Number = i });
                }
                foreach (Card card in cards)
                {
                    Console.WriteLine((cards.IndexOf(card) + 1) + " Kortti on " + card.House + "#" + card.Number);
                }
                cards.Shuffle();
                Console.WriteLine("Deck has been shuffled: ");
                foreach (Card card in cards)
                {
                    Console.WriteLine((cards.IndexOf(card) + 1) + " Kortti on " + card.House + "#" + card.Number);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
                throw;
            }
        }
    }
}
