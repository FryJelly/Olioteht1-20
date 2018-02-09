using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class CD
    {
        public List<Song> songs = new List<Song>();
        public string Name { get; set; }
        public string Artist { get; set; }

        public CD(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }

        public void CreateSongs()
        {
            Song song1 = new Song("Shudder Before the Beautiful", "6:29");
            songs.Add(song1);
            Song song2 = new Song("Weak Fantasy", "5:23");
            songs.Add(song2);
            Song song3 = new Song("Elan", "4:45");
            songs.Add(song3);
            Song song4 = new Song("Yours Is an Empty Hope", "5:34");
            songs.Add(song4);
            Song song5 = new Song("Our Decades in the Sun", "6:37");
            songs.Add(song5);
            Song song6 = new Song("My Walden", "4:38");
            songs.Add(song6);
            Song song7 = new Song("Endless Forms Most Beautiful", "5:07");
            songs.Add(song7);
            Song song8 = new Song("Edema Ruh", "5:15");
            songs.Add(song8);
            Song song9 = new Song("Alpenglow", "4:45");
            songs.Add(song9);
            Song song10 = new Song("The Eyes of Sharbat Gula", "6:03");
            songs.Add(song10);
            Song song11 = new Song("The Greatest Show on Earth", "24:00");
            songs.Add(song11);
        }

    }
}
