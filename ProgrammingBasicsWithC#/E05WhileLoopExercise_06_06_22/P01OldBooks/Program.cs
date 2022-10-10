using System;

namespace P01OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            string book;
            int checkedBooks = 0;
            while ((book = Console.ReadLine()) != "No More Books")
            {
                if (book == wantedBook)
                {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                checkedBooks++;
            }
            if (book != wantedBook)
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
