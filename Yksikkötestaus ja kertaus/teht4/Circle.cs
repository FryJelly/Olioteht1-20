using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Circle : Shape
    {
        public new string Name = "Circle"; 
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }
        public override double Circumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

    }
}
