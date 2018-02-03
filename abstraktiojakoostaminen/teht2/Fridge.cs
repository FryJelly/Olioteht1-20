using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Fridge
    {
        private Drinks saku = new Drinks("Saku Original", "Saku", 6);
        private Drinks milk = new Drinks("Kevyt maito", "Valio", 1);
        private Food sandwich = new Food("Juustovoileipä", "", 1);
        private Ingredients tomato = new Ingredients("Tomato", "Pirkka", 4);
        public string FridgeModel { get; set; }

        public Fridge(string fridgeModel)
        {
            FridgeModel = fridgeModel;
        }

        ~Fridge()
        {
            Console.WriteLine();
        }
        public void PrintFridge()
        {
            Console.WriteLine("Fridge model " + FridgeModel + ". Contents: ");

            Console.WriteLine("-Type: Drink, Name: " + saku.Name + ", Brand: " + saku.Brand + ", Amount: " + saku.Amount);
            Console.WriteLine("-Type: Drink, Name: " + milk.Name + ", Brand: " + milk.Brand + ", Amount: " + milk.Amount);
            Console.WriteLine("-Type: Food, Name: " + sandwich.Name + ", Brand: " + sandwich.Brand + ", Amount: " + sandwich.Amount);
            Console.WriteLine("-Type: Ingredient, Name: " + tomato.Name + ", Brand: " + tomato.Brand + ", Amount: " + tomato.Amount);
        }
    }
}
