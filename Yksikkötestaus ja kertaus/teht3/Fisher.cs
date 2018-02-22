using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Fisher
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Fish> fish;

        public Fisher(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
