using System;

namespace P07FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            int litresFuel = int.Parse(Console.ReadLine());

            if (typeOfFuel == "Diesel" || typeOfFuel == "Gasoline" || typeOfFuel == "Gas")
            {
                typeOfFuel = typeOfFuel.ToLower();
                if (litresFuel >= 25)
                {
                    Console.WriteLine($"You have enough {typeOfFuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {typeOfFuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
