using System;

namespace AreaBonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");

            float radius = float.Parse(Console.ReadLine());
            while (radius >= 0)
            {
                Console.WriteLine("The area of a circle with a radius of " + radius + " is " + (3.14 * radius * radius));
                Console.WriteLine("Enter a radius: ");
                radius = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Goodbye");

            Console.ReadLine();
        }
    }
}