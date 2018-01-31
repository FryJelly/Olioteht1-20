/*ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne.
 *Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) esiintyy ja käytä apua perintää, jos tavaroille löytyy yhteisiä ominaisuuksia. 
 *Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. 
 *Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            DVD dvd = new DVD();
            dvd.Name = "DVD";
            dvd.Weight = 0.2;
            dvd.Year = 1994;
            dvd.Title = "Pulp Fiction";
            dvd.Length = "154 min";
            Console.WriteLine("DVD:");
            Console.WriteLine(dvd.ToString());
            Console.WriteLine();

            Book book = new Book();
            book.Name = "Book";
            book.Weight = 0.5;
            book.Year = 2006;
            book.Title = "How to eat an apple";
            book.PageAmount = 120;
            Console.WriteLine("Book:");
            Console.WriteLine(book.ToString());
            Console.WriteLine();

            NintendoDS ds = new NintendoDS();
            ds.Name = "Nintendo DS";
            ds.Weight = 0.3;
            ds.Year = 2004;
            ds.Color = "Light blue";
            ds.InsertedGame = "Super Mario";
            Console.WriteLine("DS:");
            Console.WriteLine(ds.ToString());
            Console.WriteLine();


        }
    }
}
