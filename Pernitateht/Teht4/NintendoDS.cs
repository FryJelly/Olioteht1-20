using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class NintendoDS : Object
    {
        public string Color { get; set; }
        public string InsertedGame { get; set; }

        public NintendoDS()
        {

        }

        public NintendoDS(string Name, float Weight, int Year, string color, string insertedGame)
        {
            Color = color;
            InsertedGame = insertedGame;
        }

        public override string ToString()
        {
            return base.ToString() + " Color: " + Color + " Inserted Game: " + InsertedGame;
        }
    }
}
