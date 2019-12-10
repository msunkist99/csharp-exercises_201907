using System;
using System.Collections.Generic;

namespace MK_ListsSumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Console.WriteLine("Sum of Positive Integers - using For loop - " + SumPositiveIntegersUsingForLoop(integers));
            Console.WriteLine("Sum of Positive Integers - using ForEach loop - " + SumPositiveIntegersUsingForEachLoop(integers));
            Console.WriteLine("Sum of Positive Integers - using While loop - " + SumPositiveIntegersUsingWhileLoop(integers));
            Console.WriteLine("Sum of Positive Integers - using Do loop - " + SumPositiveIntegersUsingDoLoop(integers));

            Console.ReadLine();

            static int SumPositiveIntegersUsingForLoop (List<int> integers)
            {
                int sumOfPositiveIntegers = 0;

                for (int i = 0; i < integers.Count; i++)
                {
                    if (integers[i] % 2 == 0)
                    {
                        sumOfPositiveIntegers += integers[i];
                    }
                }

                return sumOfPositiveIntegers;
            }

            static int SumPositiveIntegersUsingForEachLoop(List<int> integers)
            {
                int sumOfPositiveIntegers = 0;

                foreach (int integer in integers)
                {
                    if (integer % 2 == 0)
                    {
                        sumOfPositiveIntegers += integer;
                    }
                }

                return sumOfPositiveIntegers;
            }

            static int SumPositiveIntegersUsingWhileLoop(List<int> integers)
            {
                int sumOfPositiveIntegers = 0;
                int index = 0;

                while (index < integers.Count)
                {
                    if (integers[index] % 2 == 0)
                    {
                        sumOfPositiveIntegers += integers[index];
                    }
                    index += 1;
                }

                return sumOfPositiveIntegers;
            }

            static int SumPositiveIntegersUsingDoLoop(List<int> integers)
            {
                int sumOfPositiveIntegers = 0;
                int index = 0;

                do
                {
                    if (integers[index] % 2 == 0)
                    {
                        sumOfPositiveIntegers += integers[index];
                    }
                    index += 1;
                } while (index < integers.Count);

                return sumOfPositiveIntegers;
            }
        }
    }
}
