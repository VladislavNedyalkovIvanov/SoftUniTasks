using System;

namespace P06Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string first = "L";

            //while (floors > 0)
            for (int f = floors; f > 0; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f == floors)
                    {
                        Console.Write($"{first}{f}{r} ");
                    }
                    else if (f % 2 == 0)
                    {
                        first = "O";
                        Console.Write($"{first}{f}{r} ");
                    }
                    else
                    {
                        first = "A";
                        Console.Write($"{first}{f}{r} ");
                    }

                }
                Console.WriteLine();
                //floors--;
            }
        }
    }
}
