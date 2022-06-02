 using System;

namespace _06.Exercise_Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceProtectiveNylon = 1.50;
            double pricePaint = 14.50;
            double pricePaintThinner = 5.00;
        

            double needsProtectiveNylon = double.Parse(Console.ReadLine());
            double needsPaint = double.Parse(Console.ReadLine());
            double needsPaintThiner = double.Parse(Console.ReadLine());
            double needsHoursPerWork = double.Parse(Console.ReadLine());

            double addProtectiveNylon = 2;
            double addPaint = 1.1;
            double addPercentPerAllForMaster = 0.30;
            double allBags = 0.40;

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
