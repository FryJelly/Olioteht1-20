using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Program
    {
        delegate void Input(string syote);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string syote = Console.ReadLine();
            string choice = "";
            while (!choice.Contains("0"))
            {
                Console.WriteLine("Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla yhtenä numerosarjana esim '123': ");
                Console.WriteLine("1=ISOIKSI kirjaimiksi ");
                Console.WriteLine("2=pieniksi kirjaimiksi ");
                Console.WriteLine("3=Otsikoksi ");
                Console.WriteLine("4=Palindormiksi ");
                Console.WriteLine("0=lopetus /n");
                string numbers = Console.ReadLine();
                if (numbers.Contains("1"))
                {
                    Input capital = InputCapital;
                    capital(syote);
                }
                if (numbers.Contains("2"))
                {
                    Input lower = InputLower;
                    lower(syote);
                }
                if (numbers.Contains("3"))
                {
                    Input heading = InputHeading;
                    heading(syote);
                }
                if (numbers.Contains("4"))
                {
                    Input reverse = InputReverse;
                    reverse(syote);
                }
                choice = numbers;
            }
        }
        static void InputCapital(string syote)
        {
            Console.WriteLine(syote.ToUpper());
        }
        static void InputLower(string syote)
        {
            Console.WriteLine(syote.ToLower());
        }
        static void InputHeading(string syote)
        {
            Console.WriteLine(syote.First().ToString().ToUpper() + syote.Substring(1).ToLower());
        }
        static void InputReverse(string syote)
        {
            char[] charArray = syote.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
