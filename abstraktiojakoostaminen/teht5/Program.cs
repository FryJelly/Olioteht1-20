/* Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.
Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).
Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). 
Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. 
Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". 
Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). 
Lisää vauvalle ominaisuus vaippa (String).
Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = 15;
            human.Name = "Teenager1";
            human.Weight = "37kg";
            human.Height = 160;

            Adult adult = new Adult();
            adult.Age = 25;
            adult.Name = "Adult1";
            adult.Weight = "65kg";
            adult.Height = 180;
            adult.Car = "Toyota";

            Baby baby = new Baby();
            baby.Age = 1;
            baby.Name = "Babby1";
            baby.Weight = "6,5kg";
            baby.Height = 50;
            baby.Diaper = "Pampers";

            human.PrintData();
            human.Move();

            adult.PrintData();
            adult.Move();

            baby.PrintData();
            baby.Move();
        }
    }
}
