 using System;

namespace _06.Exercise_Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceProtectiveNylon = double.Parse("1.50");
            double pricePaint = double.Parse("14.50");
            double pricePaintThinner = double.Parse("5.00");
        

            double needsProtectiveNylon = double.Parse(Console.ReadLine());
            double needsPaint = double.Parse(Console.ReadLine());
            double needsPaintThiner = double.Parse(Console.ReadLine());
            double needsHoursPerWork = double.Parse(Console.ReadLine());

            double addProtectiveNylon = double.Parse("2");
            double addPaint = double.Parse("1.1");
            double addPercentPerAllForMaster = double.Parse("0.30");
            double allBags = double.Parse("0.40");

            double allProtectiveNylon = (needsProtectiveNylon + addProtectiveNylon) * priceProtectiveNylon;
            double allPaint = (needsPaint * addPaint) * pricePaint;
            double allPaintThinker = (needsPaintThiner * pricePaintThinner);
            double allMaterials = allProtectiveNylon + allPaint + allPaintThinker + allBags;
            double allForMasterPerHour = allMaterials * addPercentPerAllForMaster;

            double allForMasters = needsHoursPerWork * allForMasterPerHour;
            double allCosts = allMaterials + allForMasters;

            Console.WriteLine($"{allCosts}");
        }
    }
}
