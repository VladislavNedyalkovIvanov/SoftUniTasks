using System;

namespace P02EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int f = firstNum; f <= secondNum; f++)
            {
                string thisNum = f.ToString();
                int oddNum = 0;
                int evenNum = 0;
                for (int s = 0; s < thisNum.Length; s++)
                {
                    int currentNumb = int.Parse(thisNum[s].ToString());
                    if (s % 2 == 0)
                    {
                        evenNum += currentNumb;
                    }    
                    else
                    {
                        oddNum += currentNumb;
                    }
                }
                if (oddNum == evenNum)
                {
                    Console.Write($"{f} ");
                }
            }
        }
    }
}
