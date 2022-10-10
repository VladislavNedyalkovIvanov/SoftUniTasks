using System;

namespace P06CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student = 0;
            int standard = 0;
            int kid = 0;

            int freePlaces = 0;
            string nameOfMovie;
            int totalTickets = 0;
            bool finish = false;
            while ((nameOfMovie = Console.ReadLine()) != "Finish")
            {
                if (nameOfMovie == "Finish")
                {
                    finish = true;
                    break;
                }
                freePlaces = int.Parse(Console.ReadLine());
                string type;
                int ticketsPerMovie = 0;
                while ((type = Console.ReadLine()) != "End" && ticketsPerMovie < freePlaces && finish == false)
                {
                    totalTickets++;
                    ticketsPerMovie++;

                    string typeOfBillet = type;

                    if (typeOfBillet == "student")
                    {
                        student++;
                    }
                    else if (typeOfBillet == "standard")
                    {
                        standard++;
                    }
                    else if (typeOfBillet == "kid")
                    {
                        kid++;
                    }
                    if (finish == true || type == "End" || ticketsPerMovie >= freePlaces)
                    {
                        break;
                    }
                }
                double percentOfFull = ((double)ticketsPerMovie / freePlaces) * 100;
                Console.WriteLine($"{nameOfMovie} - {percentOfFull:f2}% full.");
            }
            double studentPercent = ((double)student / (double)totalTickets) * 100;
            double standardPercent = ((double)standard / (double)totalTickets) * 100;
            double kidPercent = ((double)kid / (double)totalTickets) * 100;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercent:f2}% student tickets.");
            Console.WriteLine($"{standardPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidPercent:f2}% kids tickets.");



        }
    }
}
