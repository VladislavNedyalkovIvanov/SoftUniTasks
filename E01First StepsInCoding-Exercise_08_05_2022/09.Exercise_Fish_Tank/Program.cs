using System;

namespace _09.Exercise_Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtAqua = int.Parse(Console.ReadLine());
            int widhtAqua = int.Parse(Console.ReadLine());
            int heightAqua = int.Parse(Console.ReadLine());
            double percentFull = double.Parse(Console.ReadLine());

            int volumeAquaSm = lenghtAqua * widhtAqua * heightAqua;
            double decimetersPercent = 0.001;

            double volumeAuqaDecimeters = volumeAquaSm * decimetersPercent;
            double percentFullCalc = 0.01;
            double percentAquaTaken = percentFull * percentFullCalc;

            double AquaNeeds = volumeAuqaDecimeters - (volumeAuqaDecimeters * percentAquaTaken);

            Console.WriteLine(AquaNeeds);
            



        }
    }
}
