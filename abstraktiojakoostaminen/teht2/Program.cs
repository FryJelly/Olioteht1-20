﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge HomeFridge = new Fridge("Electrolux 9000");
            HomeFridge.PrintFridge();

            GC.Collect();
            Console.ReadKey();
        }
    }
}
