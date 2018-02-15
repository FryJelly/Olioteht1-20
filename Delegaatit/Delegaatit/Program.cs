using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaatit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string syote = Console.ReadLine();
            int value;
            Console.WriteLine("/n Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla yhtenä numerosarjana esim '123': ");
            Console.WriteLine("1=ISOIKSI kirjaimiksi ");
            Console.WriteLine("2=pieniksi kirjaimiksi ");
            Console.WriteLine("3=Otsikoksi ");
            Console.WriteLine("4=Palindormiksi ");
            Console.WriteLine("0=lopetus /n");
            string numbers = Console.ReadLine();
            if (numbers.Contains("1"))
            {

            }


        }
    }
}
