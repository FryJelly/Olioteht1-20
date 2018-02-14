using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"F:\K9105\names.txt";
            int rows = 0; //rowcount
            var nameCount = new Dictionary<string, int>();

            foreach (string s in File.ReadAllLines(text))
            {
                if (nameCount.ContainsKey(s))
                {
                    rows++;
                    nameCount[s] = nameCount[s] + 1;
                }
                else
                {
                    rows++;
                    nameCount.Add(s, 1);
                }
            }
            
            // printing
            Console.WriteLine("Löytyi " + rows + " riviä, ja " + nameCount.Count() + " nimeä sortattuna: ");
            foreach (var pair in nameCount.OrderBy(x => x.Key))
            {
                Console.WriteLine("Nimi {0} esiintyy {1} kertaa", pair.Key, pair.Value);
            }
            Console.ReadKey();
        }
    }
}
