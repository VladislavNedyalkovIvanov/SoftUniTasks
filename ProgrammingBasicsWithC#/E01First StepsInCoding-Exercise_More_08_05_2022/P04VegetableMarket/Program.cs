using System;

namespace P04VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Градинар продавал реколтата от градината си на зеленчуковата борса.
            //Продава зеленчуци за N лева на килограм и плодове за M лева за килограм.
            //Напишете програма, която да пресмята приходите от реколтата в евро ( ако приемем, че едно евро е равно на 1.94лв).
            double vegetableN = double.Parse(Console.ReadLine());
            double vegetableM = double.Parse(Console.ReadLine());
            double vegetableNkG = double.Parse(Console.ReadLine());
            double vegetableMkG = double.Parse(Console.ReadLine());
            double courseOfEu = 1.94;

            double finalPriceN = (vegetableN * vegetableNkG) / courseOfEu;
            double finalPriceM = (vegetableM * vegetableMkG) / courseOfEu;
            double finalPriceAll = finalPriceN + finalPriceM;

            Console.WriteLine($"{finalPriceAll:f}");

        }
    }
}
