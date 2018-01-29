using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Bicycle : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearManufacturer { get; set; }

        public Bicycle()
        {

        }

        public Bicycle(string Name, string Model, int ModelYear, string Colour, bool gearWheels,  string gearManufacturer)
            //: base(Name)
        {
            GearWheels = gearWheels;
            GearManufacturer = gearManufacturer;
        }

        public override string ToString()
        {
            return base.ToString() + " GearWheels: " + GearWheels + " Gear Manufacturer: " + GearManufacturer;
        }

    }
}
