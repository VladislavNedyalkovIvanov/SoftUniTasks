using System;

namespace P07_ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine();
            string familyName = Console.ReadLine();
            string character = Console.ReadLine();
            Console.WriteLine($"{firstName}{character}{familyName}");
        }
    }
}
