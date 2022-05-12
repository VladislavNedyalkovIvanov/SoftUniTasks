using System;

namespace _04_Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value of the inches that you want to calculate to santimeters:");
            double inch = double.Parse(Console.ReadLine());
            double santimeters = 2.54;

            double allSantimeters = inch * santimeters;
            Console.WriteLine("Okey the result of your calculation in santimeters is:");
            Console.WriteLine(allSantimeters);
        }
    }
}
