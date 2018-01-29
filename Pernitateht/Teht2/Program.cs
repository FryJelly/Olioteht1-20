using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {

            // create one Bicycle Object
            Bicycle bicycle = new Bicycle();
            bicycle.Name = "Jopo";
            bicycle.Model = "Street";
            bicycle.ModelYear = 2016;
            bicycle.Colour = "Red";
            bicycle.GearWheels = false;
            bicycle.GearManufacturer = "none";
            Console.WriteLine("Bike info: ");
            Console.WriteLine(bicycle.ToString());
            Console.WriteLine();

            // create one Bicycle Object
            Bicycle bicycle2 = new Bicycle();
            bicycle2.Name = "Tunturi";
            bicycle2.Model = "Street Power";
            bicycle2.ModelYear = 2010;
            bicycle2.Colour = "Green";
            bicycle2.GearWheels = true;
            bicycle2.GearManufacturer = "Shimano";
            Console.WriteLine("Bike2 info: ");
            Console.WriteLine(bicycle2.ToString());
            Console.WriteLine();

            // create one Boat Object
            Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.ModelYear = 1990;
            boat.Colour = "Blue";
            boat.BoatType = "Rowboat";
            boat.SeatCount = 3;
            Console.WriteLine("Boat info: ");
            Console.WriteLine(boat.ToString());
            Console.WriteLine();

            // create one Boat Object
            Boat boat2 = new Boat();
            boat2.Name = "Yamaha";
            boat2.Model = "Model 1000";
            boat2.ModelYear = 2010;
            boat2.Colour = "Yellow";
            boat2.BoatType = "Motorboat";
            boat2.SeatCount = 5;
            Console.WriteLine("Boat2 info: ");
            Console.WriteLine(boat2.ToString());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
