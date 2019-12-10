using System;
using System.Collections.Generic;

namespace MK_ListStrings_FiveLetterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "cat", "bird", "horse", "ferret", "snake" };

            PrintFiveLetterWords(words);

            Console.ReadLine();
        }

        static void PrintFiveLetterWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length == 5)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
