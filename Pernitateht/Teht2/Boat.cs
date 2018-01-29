using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        public Boat()
        {

        }

        public Boat(string Name, string Model, int ModelYear, string Colour, string boatType, int seatCount)
        //: base(Name)
        {
            BoatType = boatType;
            SeatCount = seatCount;
        }

        public override string ToString()
        {
            return base.ToString() + " BoatType: " + BoatType + " SeatCount: " + SeatCount;
        }

    }
}
