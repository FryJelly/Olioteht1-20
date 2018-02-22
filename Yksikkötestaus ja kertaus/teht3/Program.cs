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
            List<Fisher> fishers = new List<Fisher>();
            Fisher kirsi = new Fisher("Kirsi Kernel", "020-12345678");
            fishers.Add(kirsi);

            Console.WriteLine("A new fisher added to Fish-Register:");
            Console.WriteLine("- Fisher: " + kirsi.Name + " Phone: " + kirsi.PhoneNumber);

            kirsi.fish.Add(new Fish("salmon", 120, 4.5));
            Console.WriteLine("Fisher: " + kirsi.Name + " got a new fish");
            Console.WriteLine("- specie : " + kirsi.fish[0].Species + " " + kirsi.fish[0].Length + " cm " + kirsi.fish[0].Weight + " kg");
            Console.WriteLine("- place: The Lake of Jyväskylä");
            Console.WriteLine("- location: Jyväskylä");

            Console.WriteLine("Fisher " + kirsi.Name + "has got following fish: ");

            foreach (Fish fish in kirsi.fish)
            {
                Console.WriteLine("- specie : " + fish.Species + " " + fish.Length + " cm " + fish.Weight + " kg");
                Console.WriteLine("- place: The Lake of Jyväskylä");
                Console.WriteLine("- location: Jyväskylä");
            }
        }
    }
}
