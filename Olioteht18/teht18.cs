//Tee ohjelma, joka kysyy käyttäjältä merkkijonon (lause). Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi. 
using System;

class Program
{
    public static bool IsPalindrome(string value) // palindrome check
    {
        int min = 0;
        int max = value.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = value[min];
            char b = value[max];

            while (!char.IsLetterOrDigit(a))
            {
                min++;
                if (min > max)
                {
                    return true;
                }
                a = value[min];
            }

            while (!char.IsLetterOrDigit(b))
            {
                max--;
                if (min > max)
                {
                    return true;
                }
                b = value[max];
            }

            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }
    }

    static void Main()
    {
        Console.Write("Write something to try if it's a palindrome: ");
        string value = Console.ReadLine();
        Console.WriteLine("{0} = {1}", value, IsPalindrome(value));   
    }
}