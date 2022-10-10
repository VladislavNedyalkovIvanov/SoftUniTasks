using System;

namespace P06VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int character = 0;
            for (int w = 0; w < input.Length; w++)
            {
                char letter = input[w];
                if (letter == 'a')
                {
                    character += 1;
                }
                else if (letter == 'e')
                {
                    character += 2;
                }
                else if (letter == 'i')
                {
                    character += 3;
                }
                else if (letter == 'o')
                {
                    character += 4;
                }
                else if (letter == 'u')
                {
                    character += 5;
                }

            }
            Console.WriteLine(character);
        }
    }
}
