using System;

namespace P01_BasicSyntax_Conditional_Statements_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int ageOfStudent = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {ageOfStudent}, Grade: {averageGrade:f2}");
        }
    }
}
