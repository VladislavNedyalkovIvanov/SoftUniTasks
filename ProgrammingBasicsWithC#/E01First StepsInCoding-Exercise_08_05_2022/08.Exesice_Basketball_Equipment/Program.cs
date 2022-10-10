using System;

namespace _08.Exesice_Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerYear = double.Parse(Console.ReadLine());

            double percentPerSneakers = 0.40;
            double pricePerSneakers = pricePerYear - (pricePerYear * percentPerSneakers);

            double percentPerEquip = 0.20;
            double pricePerEquip = pricePerSneakers - (pricePerSneakers * percentPerEquip);

            double percentPerBall = 0.25;
            double pricePerBall = pricePerEquip * percentPerBall;

            double percentPerAccessories = 0.20;
            double pricePerAccessories = pricePerBall * percentPerAccessories;

            double allCosts = pricePerYear + pricePerSneakers + pricePerEquip + pricePerBall + pricePerAccessories;

            Console.WriteLine($"{allCosts}");
        }
    }
}
