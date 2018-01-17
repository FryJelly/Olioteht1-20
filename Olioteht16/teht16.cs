/*Tehtävä 6

Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. 
Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators.

Esimerkkitoiminta:
    Guess a number: 50 [Enter]
    Number is bigger
    Guess a number: 75 [Enter]
    Number is smaller
    Guess a number: 66 [Enter]
    Great, it takes a 3 guesses!*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht16
{
    class teht16
    {
        static void Main(string[] args)
        {
            int number, guess, tries = 0;
            Random rand = new Random();
            number = rand.Next(100);
            do
            {
                Console.Write("Guess the number (0-100): ");
                int.TryParse(Console.ReadLine(), out guess);
                tries++;
                if (guess < number)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Too high");
                    }
                    else
                    {
                        break;
                    }
                }
            } while (guess != number);
            Console.WriteLine("Great it took you " + tries + " guesses!");
            

        }
    }
}
