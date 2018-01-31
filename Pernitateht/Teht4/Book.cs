using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class Book : Object
    {
        public string Title { get; set; }
        public int PageAmount { get; set; }

        public Book()
        {

        }

        public Book(string Name, float Weight, int Year, string title, int pageAmount)
        {
            Title = title;
            PageAmount = pageAmount;
        }

        public override string ToString()
        {
            return base.ToString() + " Title: " + Title + " PageAmount: " + PageAmount;
        }
    }
}
