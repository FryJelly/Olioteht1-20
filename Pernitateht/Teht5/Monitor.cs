using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class Monitor : Peripherals
    {
        public string RefreshRate { get; set; }
        public string Resolution { get; set; }
        public Monitor()
        {

        }

        public Monitor(string Name, string Price, string refreshRate, string resolution)
        {
            RefreshRate = refreshRate;
            Resolution = resolution;
        }

        public override string ToString()
        {
            return base.ToString() + " RefreshRate: " + RefreshRate + " Resolution: " + Resolution;
        }
    }
}
