using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("The area of a circle with a radius of " + radius + " is " + (3.14 * radius * radius));

            Console.ReadLine();
        }
    }
}
