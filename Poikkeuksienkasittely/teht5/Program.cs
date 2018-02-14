using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            TVPrograms program1 = new TVPrograms("MacGyver", "Nelonen", "16:00", "17:00", "The great MacGyver");
            TVPrograms program2 = new TVPrograms("Mythbusters", "Discovery Channel", "20:00", "21:00", "Bustin' makes me feel good");
            TVPrograms program3 = new TVPrograms("Pikku Kakkonen", "Yle TV2", "12:00", "13:00", "Varokaa heikkoja jäitä");

            List<TVPrograms> programList = new List<TVPrograms>();
            programList.Add(program1);
            programList.Add(program2);
            programList.Add(program3);

            if (File.Exists(@"F:\K9105\p1.txt"))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(@"F:\K9105\p1.txt"))
                {
                    sw.WriteLine(program1.Name);
                    sw.WriteLine(program1.Channel);
                    sw.WriteLine(program1.StartTime);
                    sw.WriteLine(program1.EndTime);
                    sw.WriteLine(program1.Info);
                }
            }
            if (File.Exists(@"F:\K9105\p2.txt"))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(@"F:\K9105\p2.txt"))
                {
                    sw.WriteLine(program2.Name);
                    sw.WriteLine(program2.Channel);
                    sw.WriteLine(program2.StartTime);
                    sw.WriteLine(program2.EndTime);
                    sw.WriteLine(program2.Info);
                }
            }
            if (File.Exists(@"F:\K9105\p3.txt"))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(@"F:\K9105\p3.txt"))
                {
                    sw.WriteLine(program3.Name);
                    sw.WriteLine(program3.Channel);
                    sw.WriteLine(program3.StartTime);
                    sw.WriteLine(program3.EndTime);
                    sw.WriteLine(program3.Info);
                }
            }

            string p1 = @"F:\K9105\p1.txt";
            string p2 = @"F:\K9105\p2.txt";
            string p3 = @"F:\K9105\p3.txt";
            Console.WriteLine("Program1: ");
            foreach (string s in File.ReadAllLines(p1))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Program2: ");
            foreach (string s in File.ReadAllLines(p2))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Program3: ");
            foreach (string s in File.ReadAllLines(p3))
            {
                Console.WriteLine(s);
            }


        }
    }
}
