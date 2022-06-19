using System;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            while ((destination = Console.ReadLine()) != "End")
            {
                if (destination == "End")
                {
                    return;
                }
                double minimalBoudget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (minimalBoudget > savedMoney)
                {
                    string saved = Console.ReadLine();
                    if (saved == "End")
                    {
                        break;
                    }
                    double newMoney = double.Parse(saved);
                    savedMoney += newMoney;
                    if (minimalBoudget <= savedMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }

                }
            }
        }
    }
}
