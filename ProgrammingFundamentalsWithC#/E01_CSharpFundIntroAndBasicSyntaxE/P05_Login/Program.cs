using System;

namespace P05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loginName = Console.ReadLine();
            string password = string.Empty;
            for (int i = loginName.Length - 1; i >= 0; i--)
            {
                char currentChar = loginName[i];
                password += currentChar;
            }
            string enteredPassword = Console.ReadLine();
            int allowedPass = 0;
            bool passwordIsTrue = true;
            while (enteredPassword != password)
            {
                if (enteredPassword != password)
                {
                    allowedPass++;
                }
                else
                {
                    break;
                }
                if (allowedPass == 4)
                {
                    passwordIsTrue = false;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                enteredPassword = Console.ReadLine();
            }
            if (passwordIsTrue == true)
            {
                Console.WriteLine($"User {loginName} logged in.");
            }
            else
            {
                Console.WriteLine($"User {loginName} blocked!");
            }
        }
    }
}
