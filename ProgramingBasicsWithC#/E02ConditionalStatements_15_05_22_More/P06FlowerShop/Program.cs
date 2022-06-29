using System;

namespace P06FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceMagnolias = 3.25;
            double priceZumbuls = 4;
            double priceRouses = 3.50;
            double priceCactuses = 8;

            // -5% 

            int magnolias = int.Parse(Console.ReadLine());
            int zumbuls = int.Parse(Console.ReadLine());
            int rouses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());

            double allProof = (magnolias * priceMagnolias) + (zumbuls * priceZumbuls) + (rouses * priceRouses) + (cactuses * priceCactuses);
            allProof = allProof - allProof * 0.05;

            if (allProof >= priceForGift)
            {
                double allLeft = allProof - priceForGift;
                Console.WriteLine($"She is left with {Math.Floor(allLeft)} leva.");
            }
            else
            {
                double allNeed = priceForGift - allProof;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(allNeed)} leva.");
            }

        }
    }
}
