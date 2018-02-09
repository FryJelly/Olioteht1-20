using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD nightwish = new CD("Endless Forms Most Beautiful", "Nightwish");
            nightwish.CreateSongs();

            Console.WriteLine("CD data: \n - name: " + nightwish.Name + "\n - artist: " + nightwish.Artist + "\n - songs: ");
            foreach (Song song in nightwish.songs)
            {
                Console.WriteLine(" - " + song.SongName + ", " + song.SongLength);
            }
            Console.ReadKey();
        }
    }
}
