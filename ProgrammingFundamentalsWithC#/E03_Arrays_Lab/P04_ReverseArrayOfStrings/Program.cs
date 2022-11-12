using System;
using System.Linq;

namespace P04_ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < letters.Length / 2; i++)
            {
                string temp = letters[i];
                letters[i] = letters[letters.Length - 1 - i];
                letters[letters.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", letters));
        }
    }
}
