using System;

namespace P07TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsN = int.Parse(Console.ReadLine());

            int allThePpl = 0;
            double pplForMusala = 0;
            double pplForMonblan = 0;
            double pplForKilimandjaro = 0;
            double pplForK2 = 0;
            double pplForEverest = 0;

            for (int i = 1; i <= groupsN; i++)
            {
                int pplInGroup = int.Parse(Console.ReadLine());
                allThePpl += pplInGroup;
                if (pplInGroup <= 5)
                {
                    pplForMusala += pplInGroup;
                }
                else if (pplInGroup >= 6 && pplInGroup <= 12)
                {
                    pplForMonblan += pplInGroup;
                }
                else if (pplInGroup >= 13 && pplInGroup <= 25)
                {
                    pplForKilimandjaro += pplInGroup;
                }
                else if (pplInGroup >= 26 && pplInGroup <= 40)
                {
                    pplForK2 += pplInGroup;
                }
                else
                {
                    pplForEverest += pplInGroup;
                }

            }

            pplForMusala = (pplForMusala / allThePpl) * 100;
            pplForMonblan = (pplForMonblan / allThePpl) * 100;
            pplForKilimandjaro = (pplForKilimandjaro / allThePpl) * 100;
            pplForK2 = (pplForK2 / allThePpl) * 100;
            pplForEverest = (pplForEverest / allThePpl) * 100;

            Console.WriteLine($"{pplForMusala:F2}%");
            Console.WriteLine($"{pplForMonblan:F2}%");
            Console.WriteLine($"{pplForKilimandjaro:F2}%");
            Console.WriteLine($"{pplForK2:F2}%");
            Console.WriteLine($"{pplForEverest:F2}%");
        }
    }
}
