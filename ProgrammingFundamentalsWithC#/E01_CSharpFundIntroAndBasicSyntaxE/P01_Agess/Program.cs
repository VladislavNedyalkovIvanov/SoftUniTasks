﻿using System;

namespace P01_Agess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            string whatIsThePerson = null;

            if (ages >= 0 && ages <= 2)
            {
                whatIsThePerson = "baby";
            }
            else if (ages >= 3 && ages <= 13)
            {
                whatIsThePerson = "child";
            }
            else if (ages >= 14 && ages <= 19)
            {
                whatIsThePerson = "teenager";
            }
            else if (ages >= 20 && ages <= 65)
            {
                whatIsThePerson = "adult";
            }
            else if (ages >= 66)
            {
                whatIsThePerson = "elder";
            }
            Console.WriteLine(whatIsThePerson);
        }
    }
}
