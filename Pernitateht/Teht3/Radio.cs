using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Radio
    {
        public string Power {get; set; }
        private int MinVol = 0;
        private int MaxVol = 9;
        public int vol {get; set;}
        public int Vol
        {
            get { return vol; }
            set
            {

                if (value >= MinVol && value <= MaxVol)
                {
                    vol = value;
                }
                else
                    Console.WriteLine("The volume doesn't go to 11");
            }
        }
        public bool onOff;
        public bool OnOff
        {
            get { return onOff; }
            set {
                if (OnOff == true)
                {
                    Power = "on";
                    onOff = true;
                }
                else
                {
                    Power = "off";
                    onOff = false;
                }
            }
        } 

        private double MinFreq = 2000.0;
        private double MaxFreq = 26000.0;
        public double freq;
        public double Freq
        {
            get { return freq; }
            set
            {
                if (value >= MinFreq && value <= MaxFreq)
                {
                    freq = value;
                }
                else
                    Console.WriteLine("You hear nothing...");
            }
        }

        public override string ToString()
        {
            return "The radio is " + Power+ ". The volume is " + Vol + ". And you are listening to the frequency " + Freq + ".";
        }
    }
}
