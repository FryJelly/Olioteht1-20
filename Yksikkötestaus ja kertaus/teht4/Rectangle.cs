using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Rectangle : Shape
    {
        public new string Name = "Rectangle";
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            double area = Width * Height;
            return area;
        }
        public override double Circumference()
        {
            double circumference = Width * 2 + Height * 2;
            return circumference;
        }
    }
}
