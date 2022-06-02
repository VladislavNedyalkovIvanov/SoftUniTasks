using System;

namespace _06.Concentrate_Data_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me what is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please tell me what is your family name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please tell me what is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please tell me where are you live?");
            string town = Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
