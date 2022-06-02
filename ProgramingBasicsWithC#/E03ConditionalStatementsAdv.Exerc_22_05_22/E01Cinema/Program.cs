using System;

namespace E01Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            decimal price = 0m;
            if (typeOfProjection == "Premiere")
            {
                price = 12.00m;
            }    
            else if (typeOfProjection == "Normal")
            {
                price = 7.50m;
            }
            else if (typeOfProjection == "Discount")
            {
                price = 5.00m;
            }
            decimal totalPrice = price * (r * c);
            Console.WriteLine($"{totalPrice:F2} leva");
        }
    }
}
