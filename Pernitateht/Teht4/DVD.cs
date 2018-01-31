using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class DVD : Object
    {
        public string Title { get; set; }
        public string Length { get; set; }

        public DVD()
        {

        }

        public DVD(string Name, float Weight, int Year, string title, string length)
        {
            Title = title;
            Length = length;
        }

        public override string ToString()
        {
            return base.ToString() + " Title: " + Title + " Length: " + Length;
        }
    }
}
