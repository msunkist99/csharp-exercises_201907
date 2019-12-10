using System;
namespace AreaBonus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            float radius = float.Parse(Console.ReadLine());

            if (radius > 0)
            {
                Console.WriteLine("The area of a circle with a radius of " + radius + " is " + (3.14 * radius * radius));
            }
            else
            {
                Console.WriteLine("Invalid input for radius");
            }

            Console.ReadLine();
        }
    }
}