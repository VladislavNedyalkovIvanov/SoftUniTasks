using System;

namespace _03CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете градуси по скалата на Целзий (°C)
            // и ги преобразува до градуси по скалата на Фаренхайт (°F).
            // °F = °C × 1.8 + 32
            // Форматирате изхода до втория знак след десетичната запетая. 

            double celsius = double.Parse(Console.ReadLine());
            double faren = celsius * 1.8 + 32;

            Console.WriteLine($"{faren:f2}");

        }
    }
}
