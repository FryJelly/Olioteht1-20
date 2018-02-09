using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Song
    {
        public string SongName { get; set; }
        public string SongLength { get; set; }

        public Song(string songName, string songLength)
        {
            SongName = songName;
            SongLength = songLength;
        }
    }
}
