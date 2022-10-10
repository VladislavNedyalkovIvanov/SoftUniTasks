using System;

namespace P07AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            if (typeOfFigure == "square")
            {
                double sideOfSquare = double.Parse(Console.ReadLine());
                double faceOfSquare = sideOfSquare * sideOfSquare;
                Console.WriteLine($"{faceOfSquare:F3}");
            }
            if (typeOfFigure == "rectangle")
            {
                double side1OfRectangle = double.Parse(Console.ReadLine());
                double side2OfRectangle = double.Parse(Console.ReadLine());
                double faceOfRectangle = side1OfRectangle * side2OfRectangle;
                Console.WriteLine($"{faceOfRectangle:F3}");
            }
            if (typeOfFigure == "circle")
            {
                double sideOfCircle = double.Parse(Console.ReadLine());
                double faceOfCircle = Math.PI * sideOfCircle * sideOfCircle;
                Console.WriteLine($"{faceOfCircle:F3}");
            }
            if (typeOfFigure == "triangle")
            {
                double sideOfTriangle = double.Parse(Console.ReadLine());
                double highOfTriangle = double.Parse(Console.ReadLine());
                double faceOfCircle = (sideOfTriangle * highOfTriangle) / 2;
                Console.WriteLine($"{faceOfCircle:F3}");
            }
        }
    }
}
