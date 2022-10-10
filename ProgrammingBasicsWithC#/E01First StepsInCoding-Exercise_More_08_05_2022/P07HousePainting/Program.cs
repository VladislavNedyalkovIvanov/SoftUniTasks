using System;

namespace P07HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double houseHwall = double.Parse(Console.ReadLine());
            double houseYwall = double.Parse(Console.ReadLine());
            double houseXtriagle = double.Parse(Console.ReadLine());

            double frontWall = houseHwall * houseHwall;
            double otherWall = houseHwall * houseYwall;
            double frontDoor = 1.2 * 2;
            double frontAll = (frontWall * 2) - frontDoor;
            double otherWindows = (1.5 * 1.5) * 2;
            double otherAll = (otherWall * 2) - otherWindows;
            double allWalls = otherAll + frontAll;
            double allPaintNeeds = allWalls / 3.4;
            Console.WriteLine($"{allPaintNeeds:f2}");

            double theRoof1 = (houseYwall * houseHwall) * 2;
            double theRoof2 = (houseHwall * houseXtriagle / 2) * 2;
            double allRoof = theRoof1 + theRoof2;
            double allPaintRoof = allRoof / 4.3;
            Console.WriteLine($"{allPaintRoof:f2}");
              
        }
    }
}
