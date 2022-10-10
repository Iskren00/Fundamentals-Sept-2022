using System;
using System.Linq;
using System.Linq.Expressions;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int[] bestArray = new int[lenght];
            int bestSequanceLong = int.MinValue;
            int bestIndex = int.MaxValue;
            int bestSum = int.MinValue;
            int bestSemple = 0;
            int semple = 0;

            string command;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] array = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sequanceLong = 1;
                int index = 0;
                int sum = 0;
                semple++;

                if (lenght == 1)
                {
                    bestSum = 1;
                    bestArray = array;
                    bestIndex = 0;
                    bestSemple = semple;
                    break;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 1)
                    {
                        index = i;

                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[j] == 0)
                            {
                                break;
                            }
                            else if (array[i] == 1 && array[j] == array[i])
                            {
                                sequanceLong++;
                            }
                        }
                    }

                    if (array[i] == array[i + 1])
                    {
                        break;
                    }
                }

                for (int s = 0; s < array.Length; s++)
                {
                    if (array[s] == 1)
                    {
                        sum++;
                    }

                }

                if (sequanceLong >= bestSequanceLong && index < bestIndex)
                {
                    bestSequanceLong = sequanceLong;
                    bestIndex = index;
                    bestArray = array;
                    bestSum = sum;
                    bestSemple = semple;                   
                }
                else if(index == bestIndex && sum > bestSum)
                {
                    bestSum = sum;
                    bestSequanceLong = sequanceLong;
                    bestIndex = index;
                    bestArray = array;
                    bestSemple = semple;
                }
                    
            }

            Console.WriteLine($"Best DNA sample {bestSemple} with sum: {bestSum}.");
            Console.WriteLine(String.Join(" ", bestArray));
        }
    }
}
