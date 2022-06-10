using System;

namespace P05Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forbiden1 = "Facebook";
            string forbiden2 = "Instagram";
            string forbiden3 = "Reddit";

            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= openTabs && salary > 0; i++)
            {
                string sites = Console.ReadLine();
                if (sites == forbiden1)
                    salary -= 150;
                else if (sites == forbiden2)
                    salary -= 100;
                else if (sites == forbiden3)
                    salary -= 50;
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
