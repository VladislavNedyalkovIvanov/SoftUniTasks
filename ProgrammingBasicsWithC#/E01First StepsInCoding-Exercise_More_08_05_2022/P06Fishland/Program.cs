using System;

namespace P06Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerSkum = double.Parse(Console.ReadLine());
            double pricePerCaca = double.Parse(Console.ReadLine());
            double kilogramsPalamud = double.Parse(Console.ReadLine());
            double kilogramsSafrid = double.Parse(Console.ReadLine());
            int KilogramsMidi = int.Parse(Console.ReadLine());

            double pricePerPalamud = pricePerSkum + (pricePerSkum * 0.60);
            double pricePerSafrid = pricePerCaca + (pricePerCaca * 0.80);
            double pricePerMidi = 7.50;

            double allForPalamud = kilogramsPalamud * pricePerPalamud;
            double allForSafrid = kilogramsSafrid * pricePerSafrid;
            double allForMidi = KilogramsMidi * pricePerMidi;
            double allCost = allForPalamud + allForSafrid + allForMidi;
            Console.WriteLine($"{allCost:f2}");
        }
    }
}
