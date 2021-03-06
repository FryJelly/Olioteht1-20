﻿/* Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.

Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). 
Laadi luokka kannettavan radion toteutukseksi. Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla. 
Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.OnOff = true;
            radio.Vol = 3;
            radio.Freq = 24000.2;
            Console.WriteLine(radio.ToString());
        }
    }
}
