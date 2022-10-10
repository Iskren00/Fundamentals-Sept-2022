using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int equalElements = int.MinValue;

            int counter = 1;
            int[] equalNumbers = new int[counter];

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > equalElements)
                {
                    equalElements = counter;

                    equalNumbers = new int[counter];

                    for (int k = 0; k < equalNumbers.Length; k++)
                    {
                        equalNumbers[k] = numbers[i];

                    }
                }
                if (i == numbers.Length - 1)
                {
                    Console.WriteLine(String.Join(" ", equalNumbers));
                }
            }
        }
    }
}
