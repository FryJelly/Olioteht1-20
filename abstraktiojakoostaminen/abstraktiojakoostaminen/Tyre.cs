using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Tyre
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string TyreSize { get; set; }

        public Tyre(string model, string type, string tyresize)
        {
            this.Model = model;
            this.Type = type;
            this.TyreSize = tyresize;
        }

        public void PrintTyre()
        {
            
            /*Console.WriteLine("Tyres:");
            Console.WriteLine("-Name: " + Type + " Model: " + Model + " TyreSize: " + TyreSize);
            Console.WriteLine("-Name: " + Type + " Model: " + Model + " TyreSize: " + TyreSize);
            Console.WriteLine("-Name: " + Type + " Model: " + Model + " TyreSize: " + TyreSize);
            Console.WriteLine("-Name: " + Type + " Model: " + Model + " TyreSize: " + TyreSize);*/
        }
        ~Tyre()
        {

        }
    }
}
