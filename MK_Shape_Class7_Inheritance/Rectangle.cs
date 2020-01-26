using System;
using System.Collections.Generic;
using System.Text;

namespace MK_Shape_Class7_Inheritance
{
    public class Rectangle : Shape
    {
        public bool IsSquare { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, string color, string type, bool isSquare, double width, double height = 0) : base(name, color, type)
        {
            IsSquare = isSquare;
            Width = width;

            if (IsSquare == true)
            {
                Height = width;
            }
            else
            {
                Height = height;
            }
        }
        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            if (IsSquare == true)
            {
                return Width * 4;
            }
            else
            {
                return (Width * 2) + (Height * 2);
            }
        }

        public override String ToString()
        {
            if (IsSquare)
            {
                return "ID:  " + Id +
                    "  Name:  " + Name +
                    "  Color:  " + Color +
                    "  Shape Type:  " + Type +
                    "  Is Square:  " + IsSquare +
                    "  Height:  " + Height +
                    "  Width:  " + Width +
                    "  Perimeter:  " + CalculatePerimeter() +
                    "  Area:  " + CalculateArea();
            }
            else
            {
                return "ID:  " + Id +
                    "  Name:  " + Name +
                    "  Color:  " + Color +
                    "  Shape Type:  " + Type +
                    "  Is Square:  " + IsSquare +
                    "  Height:  " + Height +
                    "  Width:  " + Width +
                    "  Perimeter:  " + CalculatePerimeter() +
                    "  Area:  " + CalculateArea();
            }
        }
    }
}
