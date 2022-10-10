using System;

namespace P08FuelTankPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceGasoline = 2.22;
            double priceDiesel = 2.33;
            double priceGas = 0.93;

            double lessPriceGasoline = 0.18;
            double lessPriceDiesel = 0.12;
            double lessPriceGas = 0.08;

            string typeOfFuel = Console.ReadLine();
            double litresFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double totalPrice = 0;

            if (clubCard == "Yes")
            {
                priceGasoline -= lessPriceGasoline;
                priceDiesel -= lessPriceDiesel;
                priceGas -= lessPriceGas;
            }
            switch (typeOfFuel)
            {
                case "Gasoline":
                    totalPrice = priceGasoline * litresFuel;
                    break;
                case "Diesel":
                    totalPrice = priceDiesel * litresFuel;
                    break;
                case "Gas":
                    totalPrice = priceGas * litresFuel;
                    break;
            }
            if (litresFuel >= 20 && litresFuel <= 25)
            {
                totalPrice = totalPrice - totalPrice * 0.08;
            }    
            else if (litresFuel > 25)
            {
                totalPrice = totalPrice - totalPrice * 0.10;
            }
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
