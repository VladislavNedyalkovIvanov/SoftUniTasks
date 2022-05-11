using System;

namespace _05.Exercise_Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceChemicals = double.Parse("5.80");
            double priceMarkers = double.Parse("7.20");
            double priceBoardDetergent = double.Parse("1.20");

            int needsPackedChemicals = int.Parse(Console.ReadLine());
            int needsPackedMarkers = int.Parse(Console.ReadLine());
            int needsLitresBoardDetergent = int.Parse(Console.ReadLine());
            int percentLessCosts = int.Parse(Console.ReadLine());

            double allCostsWithoutLess = (priceChemicals * needsPackedChemicals) + (priceMarkers * needsPackedMarkers) + (priceBoardDetergent * needsLitresBoardDetergent);
            double percentLessCostsCalc = percentLessCosts * 0.01;
            double totalCosts = allCostsWithoutLess - (allCostsWithoutLess * percentLessCostsCalc);
            Console.WriteLine(totalCosts);

        }
    }
}
