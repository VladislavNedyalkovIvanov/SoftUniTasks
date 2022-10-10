using System;

namespace P09FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "banana")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "apple")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "kiwi")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "lemon")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (type == "tomato")
            {
                Console.WriteLine("vegetable");
            }
            else if (type == "cucumber")
            {
                Console.WriteLine("vegetable");
            }
            else if (type == "pepper")
            {
                Console.WriteLine("vegetable");
            }
            else if (type == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
