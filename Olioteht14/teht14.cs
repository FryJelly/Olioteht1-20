//Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht14
{
    class teht14
    {
        static void Main(string[] args)
        {
            int zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0;
            int[] grades = new int[16];
            int number = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                do
                {
                    Console.Write("Give grades: ");
                    int.TryParse(Console.ReadLine(), out number);
                    grades[i] = number;
                    switch (number)
                    {
                        case 0:
                            zero++;
                            break;
                        case 1:
                            one++;
                            break;
                        case 2:
                            two++;
                            break;
                        case 3:
                            three++;
                            break;
                        case 4:
                            four++;
                            break;
                        case 5:
                            five++;
                            break;
                    }
                } while (number <= 6);
                break;
            }
            Console.WriteLine("Grades: ");
            Console.Write("0: ");
            for (int i = 0; i < zero; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.Write("1: ");
            for (int i = 0; i < one; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.Write("2: ");
            for (int i = 0; i < two; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.Write("3: ");
            for (int i = 0; i < three; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.Write("4: ");
            for (int i = 0; i < four; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            Console.Write("5: ");
            for (int i = 0; i < five; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

        }
    }
}
