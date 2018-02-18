using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Friend> friends = new List<Friend>();
            TextReader str = new StreamReader(@"F:\K9105\tutut.csv");
            while (!(str as StreamReader).EndOfStream)
            {
                var line = str.ReadLine();
                var values = line.Split(';');
                Friend friend = new Friend(values[0], values[1]);
                friends.Add(friend);
            }
            // write names in mailbook
            Console.WriteLine("Osoitekirjassa on " + friends.Count() + " nimeä: ");
            foreach (Friend name in friends)
            {
                Console.WriteLine(name.Name);
            }
            // Find names starting with input
            Console.WriteLine("Enter something to find a name with(Case sensitive): ");
            string input = Console.ReadLine();
            List<Friend> result = friends.FindAll(x => x.Name.StartsWith(input));
            foreach (Friend friend in result)
            {
                Console.WriteLine(friend.Name + " " + friend.Email);
            }
            str.Close();

            string file = @"F:\K9105\tutut.csv";
            Console.WriteLine("Enter new name to add: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter email of person: ");
            string newEmail = Console.ReadLine();
            string asd = (newName + ";" + newEmail);
            File.AppendAllText(file, asd);
        }
    }
}
