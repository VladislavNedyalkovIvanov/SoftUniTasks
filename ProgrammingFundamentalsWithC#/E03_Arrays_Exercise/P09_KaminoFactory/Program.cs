using System;
using System.Linq;

namespace P09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dnaStructure = new int[int.Parse(Console.ReadLine())];
            int[] bestDnaStructure = new int[dnaStructure.Length];
            int bestResult = 0;
            int bestIndex = 0;

            while (true)
            {
                string[] dnaInput = Console.ReadLine()
                    .Split('!')
                    .ToArray();
                if (dnaInput[0] == "Clone them")
                {
                    break;
                }
                for (int i = 0; i < dnaStructure.Length; i++)
                {
                    dnaStructure[i] = int.Parse(dnaInput[i]);
                }
                for (int i = 0; i < dnaStructure.Length; i++)
                {
                    int bestSequenceSum = 0;
                    if (bestDnaStructure[i] < dnaStructure[i])
                    {
                        bestSequenceSum++;
                    }
                }
            }
            //Console.WriteLine("While is good");

        }
    }
}
