using System;

namespace P06Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int size = length * width;
            string pieces;
            while ((pieces = Console.ReadLine()) != "STOP")
            {
                int taken = int.Parse(pieces);
                size -= taken;
                if (size < 0)
                {
                    break;
                }    
            }
            if (size > 0)
            {
                Console.WriteLine($"{size} pieces are left.");
            }
            else if (size <= 0)
            {
                size = size * -1;
                Console.WriteLine($"No more cake left! You need {size} pieces more.");
            }
        }
    }
}
