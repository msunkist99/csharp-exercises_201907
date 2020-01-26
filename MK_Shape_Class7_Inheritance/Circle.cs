using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Shape_Class7_Inheritance
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, string color, string type, double radius) : base(name, color, type)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override String ToString()
        {
            return "ID:  " + Id +
                "  Name:  " + Name +
                "  Color:  " + Color +
                "  Shape Type:  " + Type +
                "  Radius:  " + Radius +
                "  Perimeter:  " + CalculatePerimeter() +
                "  Area:  " + CalculateArea();
        }
    }
}
