using System;

namespace P04TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double prices = 0;

            if (n < 20)
            {
                prices += 0.70;
                switch (timeOfDay)
                {
                    case "day":
                        prices += 0.79 * n;
                        break;
                    case "night":
                        prices += 0.90 * n;
                        break;
                }

            }
        
            else if (n >= 20 && n < 100)
            {
                prices += 0.09 * n;
            }
            else
            {
                prices += 0.06 * n;
            }
            Console.WriteLine($"{prices:f2}");
        }
    }
}
