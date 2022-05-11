using System;

namespace _08.Exesice_Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerYear = double.Parse(Console.ReadLine());

            double percentPerSneakers = double.Parse("0.40");
            double pricePerSneakers = pricePerYear - (pricePerYear * percentPerSneakers);

            double percentPerEquip = double.Parse("0.20");
            double pricePerEquip = pricePerSneakers - (pricePerSneakers * percentPerEquip);

            double percentPerBall = double.Parse("0.25");
            double pricePerBall = pricePerEquip * percentPerBall;

            double percentPerAccessories = double.Parse("0.20");
            double pricePerAccessories = pricePerBall * percentPerAccessories;

            double allCosts = pricePerYear + pricePerSneakers + pricePerEquip + pricePerBall + pricePerAccessories;

            Console.WriteLine($"{allCosts}");
        }
    }
}
