//Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht6
{
    class teht6
    {
        static void Main(string[] args)
        {
            float distance;
            Console.WriteLine("Give distance: ");
            float.TryParse(Console.ReadLine(), out distance);
            float consume = 7.02f*(distance*0.01f);
            float cost = consume * 1.595f;
            Console.WriteLine("Gasoline consume is " + consume + " liters and cost is " + cost +" euros");
        }
    }
}
