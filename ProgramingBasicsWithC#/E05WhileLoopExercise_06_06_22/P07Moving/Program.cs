using System;

namespace P07Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = (width * length) * height;
            string boxes;
            while ((boxes = Console.ReadLine()) != "Done")
            {
                int boxesMoved = int.Parse(boxes);
                volume -= boxesMoved;
                if (volume < 0)
                {
                    break;
                }
            }
            if (volume >= 0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else if (volume < 0)
            {
                volume = volume * -1;
                Console.WriteLine($"No more free space! You need {volume} Cubic meters more.");
            }
        }
    }
}
