using System;

namespace MK_Shape_Class7_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO = get user input

            Circle circle = new Circle("Blue Circle", "Blue", "Circle", 4.2);

            Rectangle rectangle = new Rectangle("Red Rectangle", "Red", "Rectangle", false, 3.5, 6.4);

            Rectangle square = new Rectangle("Yellow Square", "Yellow", "Rectangle", true, 8.213);

            Console.WriteLine(circle.ToString());
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(square.ToString());

            Console.ReadLine();

        }
    }
}
