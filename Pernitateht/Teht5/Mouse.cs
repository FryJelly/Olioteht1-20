using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Mouse : Peripherals
    {
        public int DPI { get; set; }
        public Mouse()
        {

        }

        public Mouse(string Name, string Price, int dpi)
        {
            DPI = dpi;
        }

        public override string ToString()
        {
            return base.ToString() + " DPI: " + DPI;
        }
    }
}
