
/* Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.


    Give a number: 7 [Enter]    
        *
       ***
      *****
     *******
    *********
        *
        *
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht15
{
    class teht15
    {

        static void Main()
        {
            int height, starNumber, spaceNumber;
            int heightCount, spaceCount, starCount, trunkCount, trunkSpaceCount;

            Console.Write("Enter tree height: ");
            int.TryParse(Console.ReadLine(), out height);

            for (heightCount = 1; heightCount <= height; heightCount++)
            {
                starNumber = heightCount * 2 - 1;
                spaceNumber = heightCount + height - starNumber;

                for (spaceCount = 0; spaceCount < spaceNumber; spaceCount++)
                    Console.Write(" ");

                for (starCount = 0; starCount < starNumber; starCount++)
                    Console.Write("*");

                Console.Write("\n");
            }

            for (trunkCount = 0; trunkCount < 2; trunkCount++)
            {
                for (trunkSpaceCount = 0; trunkSpaceCount < (height * 2 + 1) / 2; trunkSpaceCount++)
                    Console.Write(" ");
                    Console.WriteLine("*");
            }
        }
    }
}