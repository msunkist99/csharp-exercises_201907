using System;
using System.Collections.Generic;

namespace MK_CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string characterString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //characterString = characterString.ToUpper();

            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            Console.Write("input your string - ");
            string characterString = Console.ReadLine().ToUpper();

            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            foreach (char character in characterString)
            {
                if (alphabet.Contains(character))
                    {
                    if (characterCounts.ContainsKey(character))
                    {
                        characterCounts[character] += 1;
                    }
                    else
                    {
                        characterCounts.Add(character, 1);
                    }
                }
             }

            foreach (KeyValuePair<char,int> character in characterCounts)
            {
                Console.WriteLine(character.Key + ": " + character.Value);
            }

            Console.ReadLine();
        }
    }
}
