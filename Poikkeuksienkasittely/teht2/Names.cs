using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Names
    {

        public void PrintNames()
        {
            try
            {
                string text = @"D:\K9105\names.txt";
                System.Console.WriteLine(File.Exists(text) ? "Contents of names.txt:\n": "File does not exist!");
                if (File.Exists(text) == true)
                {
                    var namesFile = File.ReadAllLines(text);
                    var namesList = new List<string>(namesFile);
                    Console.WriteLine("Löytyi " + namesList.Count() + " riviä, ja " + " nimeä.");
                    
                    foreach (var name in namesList)
                    {
                        
                        Console.WriteLine("Nimi " + name + " esiintyy " + name.Count() + " kertaa");
                    }
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

        }

        
    }
}
