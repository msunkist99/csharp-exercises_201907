using System;

namespace MK_Arrays_CreateInitializeInSingleLineOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int integer in integers)
            {
                Console.WriteLine(integer);
            }

            Console.ReadLine();
        }
    }
}
