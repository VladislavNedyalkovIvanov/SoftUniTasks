﻿using System;

namespace _07.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = int.Parse("3");
            int allHours = projects * hours;

            Console.WriteLine($"The architect {name} will need {allHours} hours to complete {projects} project/s.");
        }
    }
}
