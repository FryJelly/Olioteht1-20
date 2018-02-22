using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Shapes
    {
        List<Shape> circles = new List<Shape>();
        List<Shape> rectangles = new List<Shape>();

        public void CreateShapes()
        {
            circles.Add(new Circle(1));
            circles.Add(new Circle(2));
            circles.Add(new Circle(3));
            rectangles.Add(new Rectangle(10, 20));
            rectangles.Add(new Rectangle(20, 30));
            rectangles.Add(new Rectangle(40, 50));
        }

        public void PrintShapes()
        {
            foreach(Circle c in circles)
            {
                Console.WriteLine(c.Name + " Radius=" + c.Radius + " Area=" + Math.Round(c.Area(), 2) + " Circumference=" + Math.Round(c.Circumference(), 2));
            }

            foreach(Rectangle r in rectangles)
            {
                Console.WriteLine(r.Name + " Width=" + r.Width + " Height=" + r.Height + " Area=" + Math.Round(r.Area(), 2) + " Circumference=" + Math.Round(r.Circumference(), 2));
            }
        }
    }
}
