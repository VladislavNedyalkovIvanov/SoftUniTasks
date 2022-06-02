using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            if (username == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }

    }
}
